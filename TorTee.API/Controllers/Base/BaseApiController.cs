﻿using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Models;
using TorTee.Core.Exceptions.IExceptions;
using TorTee.Core.Helpers;
using NLog;
using ILogger = NLog.ILogger;
using TorTee.API.Constants;

namespace TorTee.API.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private readonly ILogger logger = LogManager.GetLogger(AppDomain.CurrentDomain.FriendlyName);
        private IActionResult BuildSuccessResult(ServiceActionResult result)
        {
            var successResult = new ApiResponse(true)
            {
                Data = result.Data,
                StatusCode = StatusCodes.Status200OK
            };

            var detail = result.Detail ?? ApiMessageConstants.SUCCESS;
            successResult.AddSuccessMessage(detail);
            return base.Ok(successResult);
        }

        private IActionResult BuildErrorResult(Exception ex)
        {
            var errorResult = new ApiResponse(false);
            errorResult.AddErrorMessage(ex.Message);

            var statusCode = StatusCodes.Status500InternalServerError;
            if (ex.GetType().IsAssignableTo(typeof(INotFoundException)))
                statusCode = StatusCodes.Status404NotFound;
            else if (ex.GetType().IsAssignableTo(typeof(IBusinessException)))
                statusCode = StatusCodes.Status409Conflict;
            else if (ex.GetType().IsAssignableTo(typeof(IForbiddenException)))
                statusCode = StatusCodes.Status403Forbidden;
            errorResult.StatusCode = statusCode;
            return base.Ok(errorResult);
        }

        protected async Task<IActionResult> ExecuteServiceLogic(Func<Task<ServiceActionResult>> serviceLogicFunc)
        {
            return await ExecuteServiceLogic(serviceLogicFunc, null);

        }
        protected async Task<IActionResult> ExecuteServiceLogic(Func<Task<ServiceActionResult>> serviceLogicFunc, Func<Task<ServiceActionResult>>? errorHandler)
        {
            var startTime = DateTime.Now;
            StringInterpolationHelper.AppendToStart(serviceLogicFunc.Method.Name!);
            var methodInfo = StringInterpolationHelper.BuildAndClear();
            logger.Info($"[START] [API-Method] - {methodInfo}");

            try
            {
                var result = await serviceLogicFunc();

                StringInterpolationHelper.Append(result.Detail ?? "no details.");
                logger.Info(StringInterpolationHelper.BuildAndClear());

                return result.IsSuccess ? BuildSuccessResult(result) : Problem(result.Detail);
            }
            catch (Exception ex)
            {
                if (errorHandler is not null)
                    await errorHandler();

                StringInterpolationHelper.Append(ex.Message);
                logger.Info(StringInterpolationHelper.BuildAndClear());

                return BuildErrorResult(ex);
            }
            finally
            {
                StringInterpolationHelper.AppendToStart($"[END] - {methodInfo}. ");
                StringInterpolationHelper.Append("Total: ");
                StringInterpolationHelper.Append((DateTime.Now - startTime).Milliseconds.ToString());
                StringInterpolationHelper.Append(" ms.");
                logger.Info(StringInterpolationHelper.BuildAndClear());
            }
        }
    }
}

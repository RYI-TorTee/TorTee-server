using System.Security.Authentication;
using TorTee.Core.Exceptions.IExceptions;

namespace TorTee.Core.Exceptions
{
    public class InvalidPasswordException : InvalidCredentialException, IBusinessException
    {
        private readonly string? _customMessage;
        public override string Message => _customMessage ?? Message;

        public InvalidPasswordException(string customMessage)
        {
            _customMessage = customMessage;
        }

        public InvalidPasswordException()
        {
            _customMessage = "Invalid Password";
        }
    }
}

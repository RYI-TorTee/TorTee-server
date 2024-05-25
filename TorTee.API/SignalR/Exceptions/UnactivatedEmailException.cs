using TorTee.Core.Exceptions.IExceptions;

namespace TorTee.BLL.Exceptions
{
    public class UnactivatedEmailException : ArgumentException, IForbiddenException
    {
        private readonly string? _customMessage;
        public override string Message => _customMessage ?? Message;

        public UnactivatedEmailException(string customMessage)
        {
            _customMessage = customMessage;
        }

        public UnactivatedEmailException()
        {
            _customMessage = "Email is not activated";
        }
    }
}

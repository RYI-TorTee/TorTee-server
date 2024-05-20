using TorTee.Core.Exceptions.IExceptions;

namespace TorTee.Core.Exceptions
{
    public class UserNotFoundException : ArgumentNullException, INotFoundException
    {
        private readonly string? _customMessage;
        public override string Message => _customMessage ?? Message;

        public UserNotFoundException(string customMessage)
        {
            _customMessage = customMessage;
        }

        public UserNotFoundException()
        {
            _customMessage = "User not found";
        }
    }
}

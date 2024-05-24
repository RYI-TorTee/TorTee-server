using TorTee.Core.Exceptions.IExceptions;

namespace TorTee.BLL.Exceptions
{
    public class AddRoleException: ArgumentException, IBusinessException
    {
        private readonly string? _customMessage;
        public override string Message => _customMessage ?? Message;

        public AddRoleException(string customMessage)
        {
            _customMessage = customMessage;
        }

        public AddRoleException()
        {
            _customMessage = "Can add account with mentee role";
        }
    }
}

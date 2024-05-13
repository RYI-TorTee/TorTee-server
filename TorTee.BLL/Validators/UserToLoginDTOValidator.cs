using FluentValidation;
using TorTee.Common.Dtos;


namespace TorTee.BLL.Validators
{
    public class UserToLoginDTOValidator : AbstractValidator<UserToLoginDTO>
    {
        public UserToLoginDTOValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}

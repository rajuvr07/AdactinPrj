using FluentValidation;
using Insurance.Models;

namespace Insurance.Api.Validators
{
   
    public class CustomerModelValidator : AbstractValidator<CustomerModel>
    {
        public CustomerModelValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(_ => _.Age).NotEmpty().WithMessage("Please provide a valid age");

            RuleFor(_ => _.DateOfBirth).NotEmpty().WithMessage("Please provide a valid Date of birth");

            RuleFor(_ => _.Occupation).NotEmpty().WithMessage("Please provide a valid occupation");
        }
    }
}

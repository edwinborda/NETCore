using FluentValidation;
using MillionAndUp.Admin.API.Application.Models;

namespace MillionAndUp.Admin.API.Application.Validators
{
    public class EditorialValidator: AbstractValidator<EditorialModel>
    {
        public EditorialValidator()
        {
            RuleFor(it => it.Name)
                .NotNull().WithMessage("Name is required")
                .NotEmpty().WithMessage("Name is required");
            RuleFor(it => it.Campus)
                .NotNull().WithMessage("Campus is required")
                .NotEmpty().WithMessage("Campus is required");
        }
    }
}

using System;
using FluentValidation;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Validators
{
    public class QuestionValidator : AbstractValidator<Quest>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.Question)
                .NotEmpty().WithMessage("Soru boş bırakılamaz")
                .MinimumLength(10).WithMessage("Soru minimum 10 karakter olmalıdır")
                .MaximumLength(200).WithMessage("Soru maksimum 200 karakter olmalıdır");

            RuleFor(x => x.Answer)
                .NotEmpty().WithMessage("Cevap boş bırakılamaz")
                .MinimumLength(10).WithMessage("Cevap minimum 10 karakter olmalıdır")
                .MaximumLength(200).WithMessage("Cevap maksimum 200 karakter olmalıdır");
        }
    }
}

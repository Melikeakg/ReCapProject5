
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyisim alanı boş geçilemez.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
        }
    }
}

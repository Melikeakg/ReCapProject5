using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(3).WithMessage("En az 3 karakter uzunluğunda olmalıdır.");
            RuleFor(c => c.DailyPrice).GreaterThan(15).WithMessage("Günlük fiyat 15 liradan fazla olamlıdır.");
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2000).WithMessage("Arabanın modeli 2000 yılı ve üzerinde olmalıdır.");
        }
    }
}

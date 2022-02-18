using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practices.Entities.ViewModels;

namespace WebAPI_Practices.Validations
{
    public class ProductValidator : AbstractValidator<PostProductQueryViewModel>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().MinimumLength(3).MaximumLength(20);

            RuleFor(p => p.CategoryId).LessThanOrEqualTo(100).NotEmpty();

            RuleFor(p => p.StockAmount).NotEmpty().GreaterThan(0);

        }
    }
}
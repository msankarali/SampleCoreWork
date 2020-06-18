using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p=>p.CategoryId == 1);
        }
    }
}

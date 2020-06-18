using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Ninject.Modules;
using SampleCoreWork.Northwind.Business.ValidationRules.FluentValidation;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.Business.DependencyResolver.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using SampleCoreWork.Northwind.Business.Abstract;
using SampleCoreWork.Northwind.Business.Concrete.Managers;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework;

namespace SampleCoreWork.Northwind.Business.DependencyResolver.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();
        }
    }
}

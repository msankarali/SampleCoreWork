using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Ninject.Modules;
using SampleCoreWork.Core.DataAccess;
using SampleCoreWork.Core.DataAccess.EntityFramework;
using SampleCoreWork.Core.DataAccess.NHibernate;
using SampleCoreWork.Northwind.Business.Abstract;
using SampleCoreWork.Northwind.Business.Concrete.Managers;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework;
using SampleCoreWork.Northwind.DataAccess.Concrete.NHibernate.Helpers;

namespace SampleCoreWork.Northwind.Business.DependencyResolver.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}

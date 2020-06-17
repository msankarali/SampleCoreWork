using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreWork.Core.DataAccess.NHibernate;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.DataAccess.Concrete
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}

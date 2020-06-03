using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SampleCoreWork.Core.DataAccess.EntityFramework;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        
    }
}

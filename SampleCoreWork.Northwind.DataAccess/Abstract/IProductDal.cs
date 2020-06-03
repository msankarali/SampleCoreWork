using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreWork.Core.DataAccess;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}

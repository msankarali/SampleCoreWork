using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreWork.Northwind.Business.Abstract;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.Business.Concrete.Managers
{
    class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
    }
}

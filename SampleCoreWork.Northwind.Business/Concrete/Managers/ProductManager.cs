using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreWork.Core.Aspects.Postsharp;
using SampleCoreWork.Core.CrossCuttingConcerns.Validation.FluentValidation;
using SampleCoreWork.Northwind.Business.Abstract;
using SampleCoreWork.Northwind.Business.ValidationRules.FluentValidation;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.Business.Concrete.Managers
{
    public class ProductManager:IProductService
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

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            ValidatorTool.FluentValidate(new ProductValidator(), product);
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            ValidatorTool.FluentValidate(new ProductValidator(), product);
            return _productDal.Update(product);
        }
    }
}

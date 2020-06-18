using System;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCoreWork.Northwind.Business.Concrete.Managers;
using SampleCoreWork.Northwind.DataAccess.Abstract;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}

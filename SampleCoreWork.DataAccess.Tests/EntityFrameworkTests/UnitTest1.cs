using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework;

namespace SampleCoreWork.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p => p.ProductName.Contains("no"));

            Assert.AreEqual(6, result.Count);
        }
    }
}

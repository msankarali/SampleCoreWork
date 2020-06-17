using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework;
using SampleCoreWork.Northwind.DataAccess.Concrete.NHibernate;
using SampleCoreWork.Northwind.DataAccess.Concrete.NHibernate.Helpers;


namespace SampleCoreWork.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p => p.ProductName.Contains("no"));

            Assert.AreEqual(6, result.Count);
        }
    }
}

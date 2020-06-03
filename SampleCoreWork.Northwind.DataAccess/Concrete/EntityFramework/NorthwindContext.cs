using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using SampleCoreWork.Northwind.Entities.Concrete;

namespace SampleCoreWork.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public DbSet<Product> Products { get; set; }
    }
}

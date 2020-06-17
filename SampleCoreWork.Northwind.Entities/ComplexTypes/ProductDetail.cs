using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCoreWork.Northwind.Entities.ComplexTypes
{
    public class ProductDetail
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SampleCoreWork.Core.Entities;

namespace SampleCoreWork.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}

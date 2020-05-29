using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleCoreWork.Core.Entities;

namespace SampleCoreWork.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
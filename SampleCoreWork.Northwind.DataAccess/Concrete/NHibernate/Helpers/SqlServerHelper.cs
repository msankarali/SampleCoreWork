using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SampleCoreWork.Core.DataAccess.NHibernate;

namespace SampleCoreWork.Northwind.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently
                .Configure()
                .Database(
                    MsSqlConfiguration.MsSql2012
                        .ConnectionString(c => c.Database("NorthwindContext")
                        )
                )
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}

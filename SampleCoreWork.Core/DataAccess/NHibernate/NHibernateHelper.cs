using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace SampleCoreWork.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory => _sessionFactory ?? (_sessionFactory = InitializeFactory());

        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

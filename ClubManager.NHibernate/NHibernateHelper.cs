using NHibernate;
using NHibernate.Cfg;
using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;

namespace ClubManager.NHibernate
{
    public static class NHibernateHelper 
    {
        public static ISession OpenSession()
        {
            Configuration c = new Configuration();
            c.AddAssembly(Assembly.GetCallingAssembly());
            ISessionFactory f = c.BuildSessionFactory();
            return f.OpenSession();
        }
    }
}

using NHibernate;
using NHibernate.Cfg;
using System;
using System.Reflection;

namespace ClubManager.NHibernate
{
    public class SessionGetter
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

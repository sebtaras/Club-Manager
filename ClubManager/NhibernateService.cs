using ClubManager.DAL_File.Mappers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager
{
    public class NhibernateService
    {
        private static ISessionFactory _sessionFactory;

        static NhibernateService()
        {
            _sessionFactory = OpenSessionFactory();
        }
        public ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        public static ISessionFactory OpenSessionFactory()
        {
            var connectionString = "Data Source=DESKTOP-ES2R24K\\SQLEXPRESS;Initial Catalog=ClubManager;Integrated Security=True";

            var _fluentConfig = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
                .ShowSql().FormatSql())
                .Mappings(mapper =>
                {
                    mapper
                    .FluentMappings
                    .AddFromAssemblyOf<PersonMap>();
                }
                );

            var nhConfiguration = _fluentConfig.BuildConfiguration();
            new SchemaExport(nhConfiguration).Create(Console.WriteLine, true);
            return nhConfiguration.BuildSessionFactory();
        }
    }
}

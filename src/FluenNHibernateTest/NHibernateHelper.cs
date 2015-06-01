using FluenNHibernateTest;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FluenNHibernateTest
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                               .Database(MsSqlConfiguration.MsSql2008
                               .ConnectionString(@"Data Source=IVANOVO02\SQLEXPRESS;Initial Catalog=FluenNHibernateTest;Integrated Security=True")
                               .ShowSql()
                               )
                               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                //.ExposeConfiguration(cfg => new SchemaExport(cfg)
                //  .Create(true, true))
                                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
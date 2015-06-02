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
using System.Windows.Forms;

namespace StoreNHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return sessionFactory;
            }
        }

        public static void InitializeSessionFactory()
        {
            sessionFactory = Fluently.Configure()
                            .Database(MsSqlConfiguration.MsSql2008
                //.ConnectionString(@"Data Source=АЛЕКСЕЙ-ПК;Initial Catalog=StoreNHibernate;Integrated Security=True"))
                .ConnectionString(@"Data Source=IVANOVO02\SQLEXPRESS;Initial Catalog=StoreNHibernate;Integrated Security=True"))
                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapping.ProductMap>())
                //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                //.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                            .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
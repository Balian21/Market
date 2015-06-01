using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNHibernateTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SchemaExport();
            Console.ReadLine();
        }

        public static void SchemaExport()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=IVANOVO02\\SQLEXPRESS;Initial Catalog=AttributeNHibernateTest;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            //new SchemaExport(cfg).Execute(true, true, false);
            //new SchemaUpdate(cfg).Execute(true, true);
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Create(false, true);
        }
    }
}
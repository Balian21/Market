using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //AddCustomer();
            GetCustomers();
            DeleteCustomer();
            //UpdateCustomer();
            GetCustomers();
        }

        public static void GetCustomers()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var customers = session.CreateCriteria<Customer>()
                                       .List<Customer>();
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0} {1}", customer.FirstName, customer.LastName);
                }
                tx.Commit();
            }
            Console.WriteLine("Press <ENTER> to exit..");
            Console.ReadLine();
        }

        public static void AddCustomer()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var customer = new Customer { FirstName = "Jack", LastName = "Rielly" };
                session.Save(customer);
                tx.Commit();
            }
        }

        public static void UpdateCustomer()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var query = from customer in session.Query<Customer>()
                            where customer.FirstName == "Jack"
                            select customer;
                var c = query.First();
                c.LastName = "Riemy";
                session.Update(c);
                tx.Commit();
            }
            Console.WriteLine("Press <ENTER> to exit..");
            Console.ReadLine();
        }

        public static void DeleteCustomer()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var query = from customer in session.Query<Customer>()
                            where customer.FirstName == "Jack"
                            select customer;
                var c = query.First();
                session.Delete(c);
                tx.Commit();
            }
            Console.WriteLine("Press <ENTER> to exit..");
            Console.ReadLine();
        }
    }
}
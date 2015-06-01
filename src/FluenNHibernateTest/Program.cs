using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenNHibernateTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //NHibernateHelper.InitializeSessionFactory();
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                Department departmentObject = new Department
                {
                    Name = "IT",
                    PhoneNumber = "11111111111111"
                };
                session.Save(departmentObject);
                transaction.Commit();
                Console.WriteLine("Department Created: " + departmentObject.Name);
            }

            //using (ISession session = NHibernateHelper.OpenSession())
            //{
            //    using (ITransaction transaction = session.BeginTransaction())
            //    {
            //        Employee emp = new Employee
            //        {
            //            FirstName = "Andrew",
            //            Position = "3"
            //        };
            //        session.Save(emp);
            //        transaction.Commit();
            //        Console.WriteLine("Employee Created: " + emp.FirstName);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
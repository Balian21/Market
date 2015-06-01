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
using System.Windows.Forms;

namespace Hiber_Diary
{
    public class MessageManager
    {
        public ListForm listForm;
        public EditForm editForm;

        public IList<Message> GetMessages()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=iDiaryDB;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            //new SchemaExport(cfg).Execute(true, true, false);
            //new SchemaUpdate(cfg).Execute(true, true);

            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                //var messages = session.QueryOver<Message>().List<Message>();

                var messages = session.CreateCriteria<Message>().List<Message>();

                //foreach (var message in messages)
                //{
                //    messages.Add(message);
                //}

                tx.Commit();
                return messages;
            }
        }

        public void AddMessage(Message msg)
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration
            (
               x =>
               {
                   x.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=iDiaryDB;Integrated Security=True";
                   x.Driver<SqlClientDriver>();
                   x.Dialect<MsSql2008Dialect>();
               }
            );
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var sessionFactory = cfg.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                session.Save(msg);
                tx.Commit();
            }
        }
    }
}
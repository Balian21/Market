using iBlogs.Data;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NEnvironment = NHibernate.Cfg.Environment;

namespace iBlog.Init
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.SetProperty(NEnvironment.Hbm2ddlAuto, "create");

            MemoryStream mapping = HbmSerializer.Default.Serialize(Assembly.Load("iBlogs.Data"));
            configuration.AddInputStream(mapping);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();



            /*Blogger blogger = new Blogger();
            bloger.Login = "anton";
            bloger.Articles.Add(new Article() { Text = "test!" });

            session.Save(bloger);
            session.Flush();

            IList<Blogger> bloggers = session.CreateCriteria<Blogger>()
                .List<Blogger>();

            Blogger bloger0 = bloggers[0];
            bloger0.Login = "andr";
            session.Save(bloger0);
            session.Flush();

            Blogger bloger1 = bloggers[1];
            session.Delete(bloger1);
            session.Flush();

            Blogger bloger2 = session.Get<Blogger>("54acdda11cc94edf94e3293c6530456a");
            bloger2.Login = "test";
            session.Save(bloger2);
            session.Flush();*/

            Console.Out.Write("111");
            Console.In.ReadLine();

            session.Close();
        }
    }
}

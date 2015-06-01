using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iBlogs.Data
{
    public class SessionManager
    {
        private readonly ISessionFactory sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                return Instance.sessionFactory;
            }
        }

        private ISessionFactory GetSessionFactory()
        {
            return sessionFactory;
        }

        public static SessionManager Instance
        {
            get
            {
                return NestedSessionManager.sessionManager;
            }
        }

        public static ISession OpenSession()
        {
            return Instance.GetSessionFactory().OpenSession();
        }

        public static ISession CurrentSession
        {
            get
            {
                return Instance.GetSessionFactory().GetCurrentSession();
            }
        }

        private SessionManager()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();

            configuration.AddInputStream(HbmSerializer.Default.Serialize(Assembly.Load("iBlogs.Data")));
            sessionFactory = configuration.BuildSessionFactory();
        }

        class NestedSessionManager
        {
            internal static readonly SessionManager sessionManager = new SessionManager();
        }
    }
}

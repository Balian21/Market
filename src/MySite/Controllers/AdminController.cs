using Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session.QueryOver<Product>()
                    .Where(p => p.Name != "").List();
                return View(products);
            }
        }
    }
}
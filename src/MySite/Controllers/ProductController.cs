using System;
using Model;
using NHibernate;
using NHibernate.Linq;
using FluentNHibernate;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class ProductController : Controller
    {        
        //static List<Product> products = new List<Product>();
        //
        // GET: /Product/

        public ActionResult Products()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session.Query<Product>().ToList();
                return View(products);
            }
        }

    }
}

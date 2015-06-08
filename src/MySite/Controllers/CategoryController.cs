using FluentNHibernate;
using Model;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Categories()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var categories = session.Query<Category>()
                                    .Where(p => p.Parent != null)
                                    .ToList();
                return View(categories);
            }
        }
    }
}
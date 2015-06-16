using FluentNHibernate;
using Model;
using NHibernate;
using NHibernate.Linq;
using PagedList;
using PagedList.Mvc;
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

        public ActionResult Show()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var categories = session.Query<Category>()
                                    .Where(p => p.Parent != null)
                                    .ToList();
                return View(categories);
            }
        }

        public ActionResult ProductList(int? id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session.Query<Product>()
                                .Where(p => p.Category.Id == id)
                                .ToList();
                return View(products);
            }
        }

        public ActionResult PagedList(int? page)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                //var products = session.Query<Product>()
                //                .Where(p => p.Category.Id == id)
                //                .ToList();

                var model = session.QueryOver<Product>().Where(p => p.Availability != null).List();

                int pageNumber = page ?? 1;
                int pageSize = 5;

                return View(model.ToPagedList(pageNumber, pageSize));
            }
        }
    }
}
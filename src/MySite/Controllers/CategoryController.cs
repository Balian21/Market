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

        public ActionResult PagedList(int? page, int? id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var model = session.QueryOver<Product>().Where(p => p.Availability != null).List();

                int pageNumber = page ?? 1;
                int pageSize = 5;

                return View(CurrentProducts(id).ToPagedList(pageNumber, pageSize)); // выводим постранично продукты выбранной категории
            }
        }

        public IList<Product> CurrentProducts(int? id) //возвращает продукты выбранной категории
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session.Query<Product>()
                                .Where(p => p.Category.Id == id)
                                .ToList();
                return products;
            }
        }
    }
}
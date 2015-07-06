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

        public ViewResult Edit(int Id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.Get<Product>(Id);
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                if (ModelState.IsValid)
                {
                    SaveProduct(product);
                    TempData["message"] = string.Format("Изменения в продукте \"{0}\" были сохранены", product.Name);
                    return RedirectToAction("Index");
                }
                else
                {
                    // Что-то не так со значениями данных
                    return View(product);
                }
            }
        }

        public void SaveProduct(Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (var trans = session.BeginTransaction())
            {
                if (product.Id == 0)
                {
                    session.Save(product);
                }
                else
                {
                    Product db_prod = session.Get<Product>(product.Id);
                    if (db_prod != null)
                    {
                        db_prod.Name = product.Name;
                        db_prod.Price = product.Price;
                        db_prod.Availability = product.Availability;
                    }
                }
                trans.Commit();
            }
        }
    }
}
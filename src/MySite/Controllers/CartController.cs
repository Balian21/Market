using FluentNHibernate;
using Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class CartController : Controller
    {
        [HttpPost]
        public ActionResult AddToCart(int? id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var product = session.Get<Product>(id);
                //Cart cart = new Cart();
                //cart.AddItem(product, 1);
                //cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });

                return View(product);
            }
        }
    }
}
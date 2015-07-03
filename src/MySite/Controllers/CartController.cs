using Model;
using MySite.Models;
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
        //[HttpPost]
        //public ActionResult AddToCart(int? id)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        var product = session.Get<Product>(id);
        //        //Cart cart = new Cart();
        //        //cart.AddItem(product, 1);
        //        //cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });

        //        return View(product);
        //    }
        //}

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int Id, string returnUrl)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.Get<Product>(Id);

                if (product != null)
                {
                    cart.AddItem(product, 1);
                }
                return RedirectToAction("Index", new { returnUrl });
            }
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int Id, string returnUrl)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.Get<Product>(Id);

                if (product != null)
                {
                    cart.RemoveLine(product);
                }
                return RedirectToAction("Index", new { returnUrl });
            }
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}
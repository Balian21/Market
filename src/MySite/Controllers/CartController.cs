﻿using Model;
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

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int Id, string returnUrl)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.Get<Product>(Id);

                if (product != null)
                {
                    GetCart().AddItem(product, 1);
                }
                return RedirectToAction("Index", new { returnUrl });
            }
        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.Get<Product>(productId);

                if (product != null)
                {
                    GetCart().RemoveLine(product);
                }
                return RedirectToAction("Index", new { returnUrl });
            }
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}
using Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class OrderController : Controller
    {
        [HttpPost]
        public ActionResult AddOrder(Cart cart, string Line1, string country, string city)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (var trans = session.BeginTransaction())
            {
                Order order = new Order();
                foreach (var line in cart.Lines)
                {
                    OrderItem orderitem = new OrderItem();
                    orderitem.Product = line.Product;
                    orderitem.Quantity = line.Quantity;
                    order.Items.Add(orderitem);
                }

                return View(order);
            }
        }
    }
}
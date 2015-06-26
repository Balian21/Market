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
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        [HttpPost]
        public ActionResult SearchProducts(string message)
        {
            //ViewBag.Message = message;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var result = session.QueryOver<Product>()
                                    .WhereRestrictionOn(p => p.Name).IsLike("%" + message + "%")
                                    .List<Product>();

                return View(result);
            }
        }
    }
}
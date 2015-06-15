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
    public class ProductController : Controller
    {
        public FileContentResult GetImage(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var product = session.Query<Product>()
                                .FirstOrDefault(p => p.Id == id);
                if (product != null && product.ImageMimeType != null)
                {
                    return File(product.ImageData, product.ImageMimeType);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
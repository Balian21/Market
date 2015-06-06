using System;
using FluentNHibernate;
using NHibernate;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySite.Entities.Products 
{
    public class ManageProducts
    {
        public IList<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (var session = NHibernateHelper.OpenSession())
            {
                var prs = session.QueryOver<Product>().List();

                foreach (var p in prs)
                {
                    products.Add(p);
                }                
            }            
            return products;
        }
    }
}
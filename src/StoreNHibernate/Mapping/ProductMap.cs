using FluentNHibernate;
using FluentNHibernate.Mapping;
using NHibernate;
using StoreNHibernate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNHibernate.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            Map(x => x.Availability);
            References(x => x.Category);
            References(x => x.Supplier);
        }
    }
}
using FluentNHibernate;
using FluentNHibernate.Mapping;
using Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            Map(x => x.Availability);
            Map(x => x.ImageData).Length(int.MaxValue);
            References(x => x.Category);
            References(x => x.Supplier);
        }
    }
}
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
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Id);
            Map(x => x.City);
            Map(x => x.Country);
            Map(x => x.TotalPrice);
            Map(x => x.Adress);
            HasMany(x => x.Items).KeyColumn("Order_id").Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
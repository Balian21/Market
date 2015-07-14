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
    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Id(x => x.Id);
            Map(x => x.Quantity);
            References(x => x.Product);
        }
    }
}
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
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Id(x => x.Id);
            HasMany(x => x.Lines).Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
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
    public class SupplierMap : ClassMap<Supplier>
    {
        public SupplierMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Products).Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
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
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.ImageData).Length(int.MaxValue);
            Map(x => x.ImageMimeType);
            References(x => x.Parent).Column("ParentId");
            HasMany(x => x.Products).KeyColumn("Category_id").Inverse().Cascade.AllDeleteOrphan();
            HasMany(x => x.Children).KeyColumn("ParentId").Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
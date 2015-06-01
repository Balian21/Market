using NHibernate;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNHibernateTest
{
    [Class(Name = "Products")]
    public class Product
    {
        [Id(Column = "ProductID")]
        [Generator(Class = "native")]
        public virtual int Id { get; set; }

        [Property(Column = "ProductName", Length = 50, NotNull = true)]
        public virtual string Name { get; set; }

        [Property(NotNull = true)]
        public virtual decimal UnitPrice { get; set; }

        [Property(NotNull = true)]
        public virtual int ReorderLevel { get; set; }

        [Property(NotNull = true)]
        public virtual bool Discontinued { get; set; }
    }
}
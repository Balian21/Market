using FluenNHibernateTest;
using FluentNHibernate;
using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenNHibernateTest
{
    internal class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);

            Map(x => x.PhoneNumber);

            Table("Department");
        }
    }
}
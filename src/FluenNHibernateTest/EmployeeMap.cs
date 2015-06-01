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
    internal class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.Position);
            References(x => x.EmployeeDepartment).Column("DepartmentId");
            Table("Employee");
        }
    }
}
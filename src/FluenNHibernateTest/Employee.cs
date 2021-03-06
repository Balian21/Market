﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenNHibernateTest
{
    public class Employee
    {
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string Position { get; set; }

        public virtual Department EmployeeDepartment { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public virtual int Id { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

        public virtual decimal TotalAmount { get; set; }
    }
}
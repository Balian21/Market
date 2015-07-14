using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private List<OrderItem> items = new List<OrderItem>();

        public virtual int Id { get; set; }

        public virtual decimal TotalPrice { get; set; }

        public virtual IList<OrderItem> Items { get; set; }

        public virtual string Adress { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }
    }
}
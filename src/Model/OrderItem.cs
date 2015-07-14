using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public virtual int Id { get; set; }

        public virtual Product Product { get; set; }

        public virtual int Quantity { get; set; }
    }
}
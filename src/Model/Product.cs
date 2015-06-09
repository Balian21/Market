using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual decimal Price { get; set; }

        public virtual int Availability { get; set; }

        public virtual byte[] ImageData { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Supplier
    {
        private IList<Product> products = new List<Product>();

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
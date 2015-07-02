using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cart
    {
        private IList<CartLine> cartlines = new List<CartLine>();
        public CartLine cartline;

        public virtual int Id { get; set; }

        public virtual IList<CartLine> CartLines
        {
            get { return cartlines; }
            set { cartlines = value; }
        }

        public void AddItem(Product product, int quantity)
        {
            CartLine line = cartlines
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                cartlines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
    }
}
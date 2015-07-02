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

        public virtual int Id { get; set; }

        public virtual IList<CartLine> CartLines { get; set; }

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

        public void RemoveLine(Product product)
        {
            cartlines.RemoveAt(product.Id);
        }

        public decimal ComputeTotalValue()
        {
            return cartlines.Sum(e => e.Product.Price * e.Quantity);
        }

        public void Clear()
        {
            cartlines.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return cartlines; }
        }
    }
}
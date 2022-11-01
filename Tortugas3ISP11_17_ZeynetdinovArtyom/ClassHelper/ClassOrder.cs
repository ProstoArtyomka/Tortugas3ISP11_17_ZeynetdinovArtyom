using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortugas3ISP11_17_ZeynetdinovArtyom.BD;

namespace Tortugas3ISP11_17_ZeynetdinovArtyom.ClassHelper
{
    public class ClassOrder
    {
        private List<Product> prod = new List<Product>();
        private List<Order> lineCollection = new List<Order>();

        public void AddItem(int Product, int Quantity)
        {
            prod = AppData.Context.Product.ToList();
            prod = prod.Where(i => i.ID == Product).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new Order
                {
                    Product = Product,
                    Quantity = Quantity
                });
            }
            else
            {
                line.Quantity += Quantity;
            }
        }

        public void RemoveLine(Product Product)
        {
            lineCollection.RemoveAll(l => l.Product.ID == game.GameId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.Cost * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<Order> Lines
        {
            get { return lineCollection; }
        }
    }

    public class Order
    {
        public int Product { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
}

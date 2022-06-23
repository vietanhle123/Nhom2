using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Coffee
{
    internal class Product
    {
        public int Id { get; set; }
        public string proName { get; set; }
        public string proDesc { get; set; }

        public int price { get; set; }

        public Product(int id, string proName, string proDesc, double price)
        {
            this.Id = id;
            this.proName = proName;
            this.proDesc = proDesc;
            this.price = (int)price;

        }
        public Product(string proName, string proDesc, double price)
        {
            this.proName = proName;
            this.proDesc = proDesc;
            this.price = (int)price;
        }
        public override string ToString()
        {
            return " | ProName : " + proName + " | ProDesc : " + proDesc + " | price : " + price;
        }
    }
}

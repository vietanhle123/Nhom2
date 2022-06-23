using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_asm
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal int proName;
        internal int proDesc;
        internal readonly object? price;
    }
}

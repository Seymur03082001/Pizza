using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Models
{
    internal class PizzaSize
    {
        public int MyProperty { get; set; }
        public int SizeId  { get; set; }
        public int PizzaId { get; set; }
        public decimal Price { get; set; }
    }
}

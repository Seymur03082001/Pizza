using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Models
{
    internal class BusketItem
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int PizzaId { get; set; }
        public int BusketId { get; set; }
    }
}

using Pizzas.Abstractions;
using Pizzas.Models;
using Pizzas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Contexts
{
    internal class Context
    {
        IService<Pizza> _pizzas;
        IService<Size> _sizes;
        IService<Ingredient> _ingredient;
        IService<Busket> _busket;

        public IService<Pizza> Pizza 
        {
            get
            {
                if(_pizzas == null)
                {
                    _pizzas = new PizzaService();
                }
                return _pizzas;
            }
        }
        public IService<Size> Size 
        {
            get
            {
                if(_sizes == null)
                {
                    _sizes = new SizeService();
                }
                return _sizes;
            }
        }
        public IService<Ingredient> Ingredient 
        {
            get
            {
                if(_ingredient == null)
                {
                    _ingredient= new IngredientService();
                }
                return _ingredient;
            }
        }
        public IService<Busket> Busket 
        {
            get
            {
                if(_busket == null)
                {
                    _busket = new BusketService();
                }
                return _busket;
            }
        }
    }
}

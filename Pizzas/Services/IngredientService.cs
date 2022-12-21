using Pizzas.Abstractions;
using Pizzas.Helper;
using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Services
{
    internal class IngredientService : IService<Ingredient>
    {
        public void Add(Ingredient model)
        {
            SQl.ExecCommand($"INSERT INTO Ingredients Values(N'{model.Name}')");
        }

        public void Delete(int id)
        {
            SQl.ExecCommand($"DELETE Ingredients WHERE ID = {id}");
        }

        public List<Ingredient> GetAll()
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Ingredients");
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (DataRow dr in dt.Rows)
            {
                ingredients.Add(new Ingredient { Id = Convert.ToInt32(dr["id"]), Name = dr["Name"].ToString()});
            }
            return ingredients;
        }
    }
}

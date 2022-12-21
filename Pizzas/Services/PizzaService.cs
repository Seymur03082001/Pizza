using Microsoft.VisualBasic;
using Pizzas.Abstractions;
using Pizzas.Helper;
using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pizzas.Services
{
    internal class PizzaService : IService<Pizza>
    {
        public void Add(Pizza model)
        {
            SQl.ExecCommand($"INSERT INTO Pizzas Values(N'{model.Name}','{model.Img}')");
        }

        public void Delete(int id)
        {
            SQl.ExecCommand($"DELETE Pizzas WHERE ID = {id}");
        }

        public List<Pizza> GetAll()
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Pizzas");
            List<Pizza> pizzas= new List<Pizza>();
            foreach(DataRow dr in dt.Rows)
            {
                pizzas.Add(new Pizza { Id = Convert.ToInt32(dr["id"]), Name = dr["Name"].ToString(), Img = dr["Img"].ToString() });
            }
            return pizzas;
        }

        public Pizza GetByID(int id)
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Pizzas");
            DataTable dr = dt.Rows[0];
            Pizza pizzas = new Pizza()
            {
             Id = Convert.ToInt32(dr["id"]);
             Name = dr["Name"].ToString();
             Img = dr["Img"].ToString();
            }
            return pizzas;
        }
    }
}

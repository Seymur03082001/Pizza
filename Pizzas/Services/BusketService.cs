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
    internal class BusketService : IService<Busket>
    {
        public void Add(Busket model)
        {
            SQl.ExecCommand($"INSERT INTO Buskets Values(N'{model.TotalPrice}')");
        }

        public void Delete(int id)
        {
            SQl.ExecCommand($"DELETE Buskets WHERE ID = {id}");
        }

        public List<Busket> GetAll()
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Buskets");
            List<Busket> buskets = new List<Busket>();
            foreach (DataRow dr in dt.Rows)
            {
                buskets.Add(new Busket { Id = Convert.ToInt32(dr["id"]), TotalPrice = Convert.ToDecimal(dr["TotalPrice"])});
            }
            return buskets;
        }
    }
}

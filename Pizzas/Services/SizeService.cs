using Pizzas.Abstractions;
using Pizzas.Helper;
using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzas.Services
{
    internal class SizeService : IService<Size>
    {
        public void Add(Size model)
        {
            SQl.ExecCommand($"INSERT INTO Sizes Values(N'{model.Name}')");
        }

        public void Delete(int id)
        {
            SQl.ExecCommand($"DELETE SIZES WHERE ID = {id}");
        }

        public List<Size> GetAll()
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Sizes");
            List<Size> sizes = new List<Size>();
            foreach (DataRow dr in dt.Rows)
            {
                sizes.Add(new Size { Id = Convert.ToInt32(dr["id"]), Name = dr["Name"].ToString()});
            }
            return sizes;
        }

        public Size GetByID(int id)
        {
            DataTable dt = SQl.ExecQuery("SELECT * FROM Sizes");
            DataTable dr = dt.Row[0];
            Size sizes= new Size();
            {
                Id = Convert.ToInt32(dr["id"]);
                Name = dr["Name"].ToString()
            }
            return sizes;
        }

        public void Update(Size model)
        {
            SQl.ExecCommand($"UPDATE Size SET Name {model.Name} WHERE id {model.Id}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Abstractions
{
    internal interface IService<T>
    {
        void Add(T model);
        List<T> GetAll();
        void Delete(int id);
        void Update(T model);
        T GetByID (int id);

    }
}

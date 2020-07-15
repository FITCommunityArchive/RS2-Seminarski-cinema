using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);
        Task<T> GetById(int id);
    }
}



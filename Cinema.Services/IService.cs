using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);
        T GetById(int id);
    }
}



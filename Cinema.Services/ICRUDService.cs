using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {

        //T Update(int id, TUpdate req);
        //T Insert(TInsert req);
    }
}

using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface  IRepository<T>
    {
         List<T> Listing();

         T ReturnById(int id);

         void Insert(T obejct);

         void Delete(int id);

         void Update(int id, T obejct);

         int NextId();
    }
}
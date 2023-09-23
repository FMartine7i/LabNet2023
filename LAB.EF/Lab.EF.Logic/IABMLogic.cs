using System.Collections.Generic;

namespace Lab.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        T Add(T item);
        void Delete(int ID);
        void Update(T categories);
    }
}

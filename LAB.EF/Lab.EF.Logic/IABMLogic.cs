using Lab.EF.Entities;
using System;
using System.Collections.Generic;

namespace Lab.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T item);

        void Delete(int ID);

        void Update(T categories);
    }
}

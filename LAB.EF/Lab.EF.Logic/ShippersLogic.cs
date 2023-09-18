using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {

        public void Add(Shippers item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shippers categories)
        {
            throw new NotImplementedException();
        }
    }
}

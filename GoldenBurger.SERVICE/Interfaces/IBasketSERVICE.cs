using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IBasketSERVICE
    {
        int Add(Basket entity);
        int Update(Basket entity);
        int Delete(Basket entity);
        List<Basket> GetAll();
        List<Basket> GetAllActive();
        List<Basket> GetWhere(Func<Basket, bool> expression);
        Basket GetById(int id);
    }
}

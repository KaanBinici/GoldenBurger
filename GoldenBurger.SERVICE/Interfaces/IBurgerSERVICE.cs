using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IBurgerSERVICE
    {
        int Add(Burger entity);
        int Update(Burger entity);
        int Delete(Burger entity);
        List<Burger> GetAll();
        List<Burger> GetAllActive();
        List<Burger> GetWhere(Func<Burger, bool> expression);
        Burger GetById(int id);
        Burger GetById(int? id);
    }
}

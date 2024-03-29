using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IDrinkSERVICE
    {
        int Add(Drink entity);
        int Update(Drink entity);
        int Delete(Drink entity);
        List<Drink> GetAll();
        List<Drink> GetAllActive();
        List<Drink> GetWhere(Func<Drink, bool> expression);
        Drink GetById(int id);
        Drink GetById(int? id);
    }
}

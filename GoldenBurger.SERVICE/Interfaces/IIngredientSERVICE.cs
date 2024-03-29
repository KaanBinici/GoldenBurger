using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IIngredientSERVICE
    {
        int Add(Ingredient entity);
        int Update(Ingredient entity);
        int Delete(Ingredient entity);
        List<Ingredient> GetAll();
        List<Ingredient> GetAllActive();
        List<Ingredient> GetWhere(Func<Ingredient, bool> expression);
    }
}

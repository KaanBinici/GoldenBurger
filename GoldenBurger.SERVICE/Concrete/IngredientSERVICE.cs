using GoldenBurger.Concrete;
using GoldenBurger.DAL.Concrete;
using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using GoldenBurger.Enums;
using GoldenBurger.SERVICE.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Concrete
{
    public class IngredientSERVICE : IIngredientSERVICE
    {
        private readonly IIngredientREPO _ingredientREPO;
        public IngredientSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _ingredientREPO = new IngredientREPO(options);
        }
        public int Add(Ingredient entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _ingredientREPO.Create(entity);
        }

        public int Delete(Ingredient entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _ingredientREPO.Delete(entity);
        }

        public List<Ingredient> GetAll()
        {
            return _ingredientREPO.GetAll();
        }

        public List<Ingredient> GetAllActive()
        {
            return _ingredientREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Ingredient> GetWhere(Func<Ingredient, bool> expression)
        {
            return _ingredientREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Ingredient entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _ingredientREPO.Update(entity);
        }
    }
}

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
    public class DrinkSERVICE : IDrinkSERVICE
    {
        private readonly IDrinkREPO _drinkREPO;
        public DrinkSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _drinkREPO = new DrinkREPO(options);
        }
        public int Add(Drink entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _drinkREPO.Create(entity);
        }

        public int Delete(Drink entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _drinkREPO.Delete(entity);
        }

        public List<Drink> GetAll()
        {
            return _drinkREPO.GetAll();
        }

        public List<Drink> GetAllActive()
        {
            return _drinkREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Drink> GetWhere(Func<Drink, bool> expression)
        {
            return _drinkREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Drink entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _drinkREPO.Update(entity);
        }
        public Drink GetById(int id)
        {
            return _drinkREPO.GetById(id);
        }

        public Drink GetById(int? id)
        {
            return _drinkREPO.GetById(id);
        }
    }
}

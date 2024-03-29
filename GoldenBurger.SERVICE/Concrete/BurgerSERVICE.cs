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
    public class BurgerSERVICE : IBurgerSERVICE
    {
        private readonly IBurgerREPO _burgerREPO;
        public BurgerSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _burgerREPO = new BurgerREPO(options);
        }
        public int Add(Burger entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _burgerREPO.Create(entity);
        }

        public int Delete(Burger entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _burgerREPO.Delete(entity);
        }

        public List<Burger> GetAll()
        {
            return _burgerREPO.GetAll();
        }

        public List<Burger> GetAllActive()
        {
            return _burgerREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Burger> GetWhere(Func<Burger, bool> expression)
        {
            return _burgerREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Burger entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _burgerREPO.Update(entity);
        }
        public Burger GetById(int id)
        {
            return _burgerREPO.GetById(id);
        }

        public Burger GetById(int? id)
        {
            return _burgerREPO.GetById(id);
        }
    }
}

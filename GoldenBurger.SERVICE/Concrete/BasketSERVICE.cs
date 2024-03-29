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
    public class BasketSERVICE : IBasketSERVICE
    {
        private readonly IBasketREPO _basketREPO;
        public BasketSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _basketREPO = new BasketREPO(options);
        }
        public int Add(Basket entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _basketREPO.Create(entity);
        }

        public int Delete(Basket entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _basketREPO.Delete(entity);
        }

        public List<Basket> GetAll()
        {
            return _basketREPO.GetAll();
        }

        public List<Basket> GetAllActive()
        {
            return _basketREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public Basket GetById(int id)
        {
            return _basketREPO.GetById(id);
        }

        public List<Basket> GetWhere(Func<Basket, bool> expression)
        {
            return _basketREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Basket entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _basketREPO.Update(entity);
        }
    }
}

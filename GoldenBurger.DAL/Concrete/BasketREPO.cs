using GoldenBurger.Concrete;
using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Concrete
{
    public class BasketREPO : IBasketREPO
    {
        private readonly GoldenBurgerContext db;
        public BasketREPO(DbContextOptions<GoldenBurgerContext> options)
        {
            db = new GoldenBurgerContext(options);
        }
        public int Create(Basket entity)
        {
            db.Baskets.Add(entity);
           return  db.SaveChanges();
        }

        public int Delete(Basket entity)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAll()
        {
           return db.Baskets.ToList();
        }

        public List<Basket> GetAllWhere(Expression<Func<Basket, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Basket GetById(int id)
        {
            return db.Set<Basket>().Find(id);
        }

        public int Update(Basket entity)
        {
            db.Update(entity);
            return db.SaveChanges();
        }
    }
}

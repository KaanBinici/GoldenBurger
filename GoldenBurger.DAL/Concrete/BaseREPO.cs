using GoldenBurger.Abstracts;
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
    public class BaseREPO<T> : IBaseREPO<T> where T : BaseEntity
    {
        protected readonly GoldenBurgerContext db;

        public BaseREPO(DbContextOptions<GoldenBurgerContext> options)
        {
            db = new GoldenBurgerContext(options);
        }
        public int Create(T entity)
        {
            db.Add(entity);
            return db.SaveChanges();
        }

        public int Delete(T entity)
        {
            db.Remove(entity);
            return db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetAllWhere(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public int Update(T entity)
        {
            db.Update(entity);
            return db.SaveChanges();
        }
    }
}

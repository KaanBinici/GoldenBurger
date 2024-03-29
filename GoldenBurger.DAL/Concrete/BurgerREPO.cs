using GoldenBurger.Concrete;
using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Concrete
{
    public class BurgerREPO : BaseREPO<Burger>, IBurgerREPO
    {
        private readonly GoldenBurgerContext db;
        public BurgerREPO(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
            db = new GoldenBurgerContext(options);
        }

        public Burger GetById(int? id)
        {
            return db.Set<Burger>().Find(id);
        }
    }
}

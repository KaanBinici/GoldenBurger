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
    public class DrinkREPO : BaseREPO<Drink>, IDrinkREPO
    {
        private readonly GoldenBurgerContext db;
        public DrinkREPO(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
            db = new GoldenBurgerContext(options);
        }

        public Drink GetById(int? id)
        {
            return db.Set<Drink>().Find(id);
        }
    }
}

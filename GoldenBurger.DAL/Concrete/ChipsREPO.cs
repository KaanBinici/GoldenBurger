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
    public class ChipsREPO : BaseREPO<Chips>, IChipsREPO
    {
        private readonly GoldenBurgerContext db;
        public ChipsREPO(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
           db = new GoldenBurgerContext(options);
        }

        public Chips GetById(int? id)
        {
            return db.Set<Chips>().Find(id);
        }
    }
}

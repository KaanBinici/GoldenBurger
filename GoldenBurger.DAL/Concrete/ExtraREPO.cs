using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using GoldenBurger.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Concrete
{
    public class ExtraREPO : BaseREPO<Extra>, IExtraREPO
    {
        private readonly GoldenBurgerContext db;
        public ExtraREPO(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
            db = new GoldenBurgerContext(options);
        }

        public Extra GetById(int? id)
        {
            return db.Set<Extra>().Find(id);
        }
    }
}

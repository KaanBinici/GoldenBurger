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
    public class MenuREPO : BaseREPO<Menu>, IMenuREPO
    {
        GoldenBurgerContext db;
        public MenuREPO(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
            db = new GoldenBurgerContext(options);
        }

        public Menu GetById(int? id)
        {
            return db.Set<Menu>().Find(id);
        }
    }
}

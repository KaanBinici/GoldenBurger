using GoldenBurger.Concrete;
using GoldenBurger.DAL.Concrete;
using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using GoldenBurger.Enums;
using GoldenBurger.SERVICE.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Concrete
{
    public class MenuSERVICE : IMenuSERVICE
    {
        private readonly IMenuREPO _menuREPO;
        public MenuSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _menuREPO = new MenuREPO(options);
        }
        public int Add(Menu entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _menuREPO.Create(entity);
        }


        public int Delete(Menu entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _menuREPO.Delete(entity);
        }

        public List<Menu> GetAll()
        {
            return _menuREPO.GetAll();
        }

        public List<Menu> GetAllActive()
        {
            return _menuREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Menu> GetWhere(Func<Menu, bool> expression)
        {
            return _menuREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Menu entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _menuREPO.Update(entity);
        }
        public Menu GetById(int id)
        {
            return _menuREPO.GetById(id);
        }

        public Menu GetById(int? id)
        {
            return _menuREPO.GetById(id);
        }
    }
}

using GoldenBurger.Concrete;
using GoldenBurger.DAL.Concrete;
using GoldenBurger.DAL.Contexts;
using GoldenBurger.DAL.Interfaces;
using GoldenBurger.DATA.Concrete;
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
    public class ExtraSERVICE : IExtraSERVICE
    {
        private readonly IExtraREPO _extraREPO;
        public ExtraSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _extraREPO = new ExtraREPO(options);
        }
        public int Add(Extra entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _extraREPO.Create(entity);
        }

        public int Delete(Extra entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _extraREPO.Delete(entity);
        }

        public List<Extra> GetAll()
        {
            return _extraREPO.GetAll();
        }

        public List<Extra> GetAllActive()
        {
            return _extraREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Extra> GetWhere(Func<Extra, bool> expression)
        {
            return _extraREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Extra entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _extraREPO.Update(entity);
        }
        public Extra GetById(int id)
        {
            return _extraREPO.GetById(id);
        }

        public Extra GetById(int? id)
        {
            return _extraREPO.GetById(id);
        }
    }
}

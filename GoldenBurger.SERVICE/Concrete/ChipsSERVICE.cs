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
    public class ChipsSERVICE : IChipsSERVICE
    {
        private readonly IChipsREPO _chipsREPO;
        public ChipsSERVICE(DbContextOptions<GoldenBurgerContext> options)
        {
            _chipsREPO = new ChipsREPO(options);
        }
        public int Add(Chips entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _chipsREPO.Create(entity);
        }

        public int Delete(Chips entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _chipsREPO.Delete(entity);
        }

        public List<Chips> GetAll()
        {
            return _chipsREPO.GetAll();
        }

        public List<Chips> GetAllActive()
        {
            return _chipsREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Chips> GetWhere(Func<Chips, bool> expression)
        {
            return _chipsREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Chips entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _chipsREPO.Update(entity);
        }
        public Chips GetById(int id)
        {
            return _chipsREPO.GetById(id);
        }

        public Chips GetById(int? id)
        {
            return _chipsREPO.GetById(id);
        }
    }
}

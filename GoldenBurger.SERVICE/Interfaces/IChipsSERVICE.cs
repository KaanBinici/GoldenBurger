using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IChipsSERVICE
    {
        int Add(Chips entity);
        int Update(Chips entity);
        int Delete(Chips entity);
        List<Chips> GetAll();
        List<Chips> GetAllActive();
        List<Chips> GetWhere(Func<Chips, bool> expression);
        Chips GetById(int id);
        Chips GetById(int? id);
    }
}

using GoldenBurger.Concrete;
using GoldenBurger.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IExtraSERVICE
    {
        int Add(Extra entity);
        int Update(Extra entity);
        int Delete(Extra entity);
        List<Extra> GetAll();
        List<Extra> GetAllActive();
        List<Extra> GetWhere(Func<Extra, bool> expression);
        Extra GetById(int id);
        Extra GetById(int? id);
    }
}

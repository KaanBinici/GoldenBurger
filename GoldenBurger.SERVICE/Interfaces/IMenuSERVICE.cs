using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.SERVICE.Interfaces
{
    public interface IMenuSERVICE
    {
        int Add(Menu entity);
        int Update(Menu entity);
        int Delete(Menu entity);
        List<Menu> GetAll();
        List<Menu> GetAllActive();
        List<Menu> GetWhere(Func<Menu, bool> expression);
        Menu GetById(int id);
        Menu GetById(int? id);
    }
}

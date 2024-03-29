using GoldenBurger.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Interfaces
{
    public interface IExtraREPO : IBaseREPO<Extra>
    {
        Extra GetById(int? id);
    }
}

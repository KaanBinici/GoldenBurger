﻿using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Interfaces
{
    public interface IMenuREPO : IBaseREPO<Menu>
    {
        Menu GetById(int? id);
    }
}

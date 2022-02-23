﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interface
{
    public interface ICRUDLogic<T>
    {
        List<T> ListaAll();
        T GetById(int id);
        T Create(T input);
        T Update(T input);
        int Delete(int id);
    }
}

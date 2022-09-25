﻿using Dinamo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamo.DAL.Abstract
{
    public interface ISTOK46TDAL
    {
        List<STOK46T> GetAll();
        STOK46T GetById(int id);
        void Add(STOK46T stok46t);
        void Update(STOK46T stok46t);
        void Delete(int id);
    }
}

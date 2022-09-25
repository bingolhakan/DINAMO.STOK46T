using Dinamo.Bussiness.Abstract;
using Dinamo.DAL.Concrete.EntityFramework;
using Dinamo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamo.Bussiness.Concrete
{
    public class STOK46TMANAGER : ISTOK46SERVICE
    {
        EfSTOK46TDAL _eFStok46tDal = new EfSTOK46TDAL();
        public void Add(STOK46T stok46t)
        {
            _eFStok46tDal.Add(stok46t);
        }

        public void Delete(int id)
        {
            _eFStok46tDal.Delete(id);
        }

        public List<STOK46T> GetAll()
        {
            return _eFStok46tDal.GetAll();
        }

        public STOK46T GetById(int id)
        {
            return _eFStok46tDal.GetById(id);
        }

        public void Update(STOK46T stok46t)
        {
            _eFStok46tDal.Update(stok46t);
        }
    }
}

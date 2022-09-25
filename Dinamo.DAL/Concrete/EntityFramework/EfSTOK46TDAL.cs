using Dinamo.DAL.Abstract;
using Dinamo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamo.DAL.Concrete.EntityFramework
{
    public class EfSTOK46TDAL : ISTOK46TDAL
    {
        AppDbContext _context = new AppDbContext();
        public void Add(STOK46T stok46t)
        {
            _context.Add(stok46t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public List<STOK46T> GetAll()
        {
            return _context.STOK46T.ToList();
        }

        public STOK46T GetById(int id)
        {
            return _context.STOK46T.Find(id);
        }

        public void Update(STOK46T stok46t)
        {
            _context.Update(stok46t);
            _context.SaveChanges();
        }
    }
}

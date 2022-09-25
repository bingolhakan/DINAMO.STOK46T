using Dinamo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamo.DAL.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=OZKOCHIDROLIK_2022;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<STOK46T> STOK46T { get; set; }
    }
}

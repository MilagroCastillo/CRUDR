using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R.EN;
using Microsoft.EntityFrameworkCore;

namespace R.AccesoDatos
{
    public class ComunDB : DbContext
    {
        public DbSet<UserR> UserR { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=BDR;Integrated Security=True");
        }
            

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmanagement
{
    public class productdatabase : DbContext
    {
        public DbSet<product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=VISAL\MSSQLSERVER02;Database=Productmanage;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}

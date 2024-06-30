using Kkocer.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Kkocer.Project.DataAccess.Concrete
{
    public class DemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 //connectionString: @"Server=BIMSER\kkocer;Database=Northwind;Trusted_Connection=true");
                 //connectionString: @"Server=BIMSER\kkocer;User ID=BOYSWEB;Password=BOYSWEB;Database=Northwind;");
                 //connectionString: @"Server=.;Database=Northwind;User Id=BOYSWEB;Password=BOYSWEB");
                 connectionString: @"Server=kkocer;Database=Northwind;User Id=BOYSWEB;Password=BOYSWEB;");
        }

        public DbSet<Product> Products { get; set; }

    }
}

using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProjectContext:DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server= DESKTOP-H1OH6CU; Database=ProjectDBB;User Id=sa;Password=12345aA");
            }
         }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().HasData(
                new Students { StudentId = 1, StudentName = "Julian Alvarez", StudentAge = 15, StudentCareer = "Medicina", StudentSemester = 6 },
                new Students { StudentId = 3, StudentName = "Mateo Fernandez", StudentAge = 34, StudentCareer = "Mecánica", StudentSemester = 8 },
                new Students { StudentId = 5, StudentName = "Lucas Perez", StudentAge = 7, StudentCareer = "Fisioterapia", StudentSemester = 78 }
                ); 

            modelBuilder.Entity<Products>().HasData(
                new Products { ProductId = 3, ProductName = "Celular", ProductPrice = 1000, ProductCategory = "Electrónica", ProductStock = 100},
                new Products { ProductId = 6, ProductName = "Gomitas", ProductPrice = 100, ProductCategory = "Alimentos", ProductStock = 10 },
                new Products { ProductId = 9, ProductName = "Motos", ProductPrice = 10, ProductCategory = "Juguetería", ProductStock = 1 }
                );
        }
    }
}

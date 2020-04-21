using BaseEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDAL
{
    public class MSSBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
            //optionsBuilder.UseSqlServer("");
            //optionsBuilder.UseMySql("");
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}

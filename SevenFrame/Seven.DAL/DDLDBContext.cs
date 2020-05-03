using Microsoft.EntityFrameworkCore;
using Seven.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seven.DAL
{
    public class DDLDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 组合键
            //modelBuilder.Entity<>().HasKey(p => new { });
            //一对多关系
            //modelBuilder.Entity<>().HasOne().WithMany().HasForeignKey();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(
        //    //    @"Data Source=localhost;Initial Catalog=SevenBlog;User ID=seven;password=hujing77");
        //    optionsBuilder.UseMySql(@"server=localhost;user id=root;persistsecurityinfo=True;database=sevendb;password=hujing77");
        //}

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

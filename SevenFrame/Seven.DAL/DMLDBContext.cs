using Microsoft.EntityFrameworkCore;
using Seven.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seven.DAL
{
    public class DMLDBContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

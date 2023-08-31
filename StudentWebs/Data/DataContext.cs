using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentWebs.Models;
using StudentWebs.Models.Accountadm;
using StudentWebs.Models.Fee;

namespace StudentWebs.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Faculty> Facultys { get; set; } = default!;

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Teacher> Teachers { get; set; } = default!;

        public DbSet<User> Users { get; set; }
        public DbSet<Fee> Fees { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentWeb.Models;
using DesktopApplication.Models;

namespace StudentWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Faculty> Facultys { get; set; } = default!;

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Teacher> Teachers { get; set; } = default!;

        public DbSet<Admin> Admins { get; set; } = default;
    }
}

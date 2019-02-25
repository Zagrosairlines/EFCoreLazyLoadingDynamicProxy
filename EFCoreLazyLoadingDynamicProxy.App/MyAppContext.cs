using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLazyLoadingDynamicProxy.App
{
    class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}

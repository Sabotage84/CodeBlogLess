using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace EFLess
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(): base("DbConnectionString")
        {
        }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Song> Songs { get; set; }

    }
}

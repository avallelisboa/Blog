using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataAccess.DBObjects
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext() : base()
        {
            
        }
        
        public DbSet<UserDB> Users { get; set; }
        public DbSet<PostDB> Posts { get; set; }
        public DbSet<CategoryDB> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDB>().ToTable("Users");
            modelBuilder.Entity<PostDB>().ToTable("Posts");
            modelBuilder.Entity<CategoryDB>().ToTable("Categories");
        }
    }
}

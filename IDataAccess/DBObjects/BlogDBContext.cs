using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataAccess.DBObjects
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext() { }
        public BlogDBContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<UserDB> Users { get; set; }
        public DbSet<PostDB> Posts { get; set; }
        public DbSet<CategoryDB> Categories { get; set; }
        public DbSet<PostCategoryDB> PostsCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDB>().ToTable("Users");
            modelBuilder.Entity<PostDB>().ToTable("Posts");
            modelBuilder.Entity<CategoryDB>().ToTable("Categories");
            modelBuilder.Entity<PostCategoryDB>().ToTable("PostsCategories").HasKey(k => new { k.PostId, k.CategoryId});
            modelBuilder.Entity<PostCategoryDB>()
                .HasOne(pc => pc.Post)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(pc => pc.CategoryId);
            modelBuilder.Entity<PostCategoryDB>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.PostCategories)
                .HasForeignKey(pc => pc.PostId);
        }
    }
}

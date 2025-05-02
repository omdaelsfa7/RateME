using Microsoft.EntityFrameworkCore;
using App.Domain.Models;
using MongoDB.EntityFrameworkCore.Extensions;

namespace App.Infrastructure.Contexts

{
    public class MongoDbContext(DbContextOptions<MongoDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Replies { get; set; }
        public DbSet<Like> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToCollection("Users");
            modelBuilder.Entity<Post>().ToCollection("Posts");
            modelBuilder.Entity<Like>().ToCollection("Likes");
            modelBuilder.Entity<Comment>().ToCollection("Comments");
        }
    }
}

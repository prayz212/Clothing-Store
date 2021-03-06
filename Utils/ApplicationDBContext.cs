using System;
using Clothing_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Clothing_Store.Utils
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<ProductTag> productTags{ get; set; }
        public DbSet<Promotion> promotions { get; set; }
        public DbSet<CartDetails> cartDetails { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<RequestForgotPassword> requests { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Receipt> receipts { get; set; }
        public DbSet<ReceiptDetail> receiptDetails { get; set; }
        public DbSet<Admin> admins { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ratings)
                .WithOne(r => r.product);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.images)
                .WithOne(i => i.product)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasMany(p => p.warehouses)
                .WithOne(w => w.product)
                .IsRequired();

            modelBuilder.Entity<ProductTag>()
                .HasKey(pt => new { pt.ProductID, pt.TagID });

            modelBuilder.Entity<Account>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Account>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Seed();
        }
    }
}

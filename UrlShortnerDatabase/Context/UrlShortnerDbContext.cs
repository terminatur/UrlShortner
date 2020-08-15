using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UrlShortnerDatabaseCoreAccess.Models;

namespace UrlShortnerDatabaseCoreAccess.Context
{
    public class UrlShortnerDbContext : DbContext, IUrlShortnerDbContext
    {
        public UrlShortnerDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ShortenedUrl> ShortenedUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShortenedUrl>().ToTable("ShortenedUrls");
        }
    }
}

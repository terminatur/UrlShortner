using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UrlShortnerDatabaseCoreAccess.Models;

namespace UrlShortnerDatabaseCoreAccess.Context
{
    public interface IUrlShortnerDbContext
    {
        public DbSet<ShortenedUrl> ShortenedUrls { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UrlShortnerDatabaseCoreAccess.Context;
using UrlShortnerDatabaseCoreAccess.Models;

namespace UrlShortnerDatabaseCoreAccess.Services
{
    public class ShortenedUrlsService : IShortenedUrlsService
    {
        private readonly UrlShortnerDbContext _dbContext;

        public ShortenedUrlsService(UrlShortnerDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async ValueTask<ShortenedUrl> Create(ShortenedUrl shortenedUrl, CancellationToken cancellationToken = default(CancellationToken))
        {
            var entity = _dbContext.ShortenedUrls.Add(shortenedUrl);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Entity;
        }

        public ValueTask<ShortenedUrl> GetById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _dbContext.FindAsync<ShortenedUrl>(id);
        }

        public ValueTask<string> GetLongUrlFromShortUrl(string shortUrl, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UrlShortnerDatabaseCoreAccess.Models;

namespace UrlShortnerDatabaseCoreAccess.Services
{
    public interface IShortenedUrlsService
    {
        public ValueTask<ShortenedUrl> GetById(int id, CancellationToken cancellationToken = default(CancellationToken));
        public ValueTask<string> GetLongUrlFromShortUrl(string shortUrl, CancellationToken cancellationToken = default(CancellationToken));

        public ValueTask<ShortenedUrl> Create(ShortenedUrl shortenedUrl, CancellationToken cancellationToken = default(CancellationToken));
    }
}

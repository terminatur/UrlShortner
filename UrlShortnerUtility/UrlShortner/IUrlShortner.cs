using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortnerUtility.UrlShortner
{
    public interface IUrlShortner
    {
        /// <summary>
        /// Takes a long URL and returns an encoded url based off the long URL
        /// </summary>
        /// <param name="longUrl">The url which needs to be shortened</param>
        /// <returns>The shortened URL</returns>
        public long ShortenUrl(string longUrl);

        /// <summary>
        /// Takes an 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetFullUrl(string shortUrl);
    }
}

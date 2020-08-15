using System;
using System.Collections.Generic;
using System.Text;
using UrlShortnerUtility.Encoders;

namespace UrlShortnerUtility.UrlShortner
{
    public class B62UrlShortner : IUrlShortner
    {
        private IBaseEncoder encoder = AlphabetEncoder.B62Encoder();

        public string GetFullUrl(string shortUrl)
        {
            // Decode the short url
            // Retrieve long url from DB
            // Return long url
            //return encoder.Encode(shortUrl);
            return null;
        }

        public long ShortenUrl(string longUrl)
        {
            return encoder.Decode(longUrl);
        }
    }
}

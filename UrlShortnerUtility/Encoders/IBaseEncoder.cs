using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortnerUtility.Encoders
{
    interface IBaseEncoder
    {
        public string Encode(long id);

        public long Decode(string shortUrl);
    }
}

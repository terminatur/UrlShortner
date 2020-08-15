using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UrlShortnerDatabaseCoreAccess.Models
{
    public class ShortenedUrl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string? ShortUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

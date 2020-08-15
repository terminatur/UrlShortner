using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UrlShortnerDatabaseCoreAccess.Context;
using UrlShortnerDatabaseCoreAccess.Models;
using UrlShortnerDatabaseCoreAccess.Services;
using UrlShortnerUtility.Encoders;

namespace SimpleTesting
{
    class Program
    {
        //private static string BASE_62_VALUES = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string BASE_62_VALUES = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static int BASE_NUM = BASE_62_VALUES.Length;

        static void Main(string[] args)
        {
            AlphabetEncoder encoder = AlphabetEncoder.B62Encoder();
            
            string longurl = "http://www.youtube.com/sdfiouwensdifo?start=10";
            
            string shortUrl = encoder.Encode(1);
            
            Console.WriteLine($"Long url: {longurl}");
            Console.WriteLine($"Encoded Short URL: {shortUrl}");
            
            long recalculatedId = encoder.Decode(shortUrl);
            
            Console.WriteLine($"Recalculated Id: {recalculatedId}");

            string connectionString = "Server=tcp:urlshortnersqlserver.database.windows.net,1433;Initial Catalog=UrlShortnerDb;Persist Security Info=False;User ID=nate;Password=214Mercedes!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            
            var optionsBuilder = new DbContextOptionsBuilder();// <UrlShortnerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            
            using (UrlShortnerDbContext context = new UrlShortnerDbContext(optionsBuilder.Options))
            {
                var service = new ShortenedUrlsService(context);

                Console.WriteLine(service.GetById(1).Result);

                
            }
        }
    }
}

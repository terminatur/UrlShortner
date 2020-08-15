using System;

namespace UrlShortnerUtility.Encoders
{
    public class AlphabetEncoder : IBaseEncoder
    {
        private readonly long _base_num;
        private readonly string _alphabet;

        public static AlphabetEncoder B62Encoder()
        {
            string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new AlphabetEncoder(alphabet);
        }

        public AlphabetEncoder(string alphabet)
        {
            this._alphabet = alphabet;
            this._base_num = alphabet.Length;
        }

        public long Decode(string shortUrl)
        {
            int id = 0;

            int idx = 0;
            foreach (char c in shortUrl)
            {
                int power = (shortUrl.Length - (idx + 1));
                id += _alphabet.IndexOf(c) * (int)(Math.Pow(_base_num, power));
                idx += 1;
            }

            return id;
        }

        public string Encode(long id)
        {
            if (id == 0)
            {
                return _alphabet[0].ToString();
            }

            string result = "";
            long n = id;

            while (n > 0)
            {
                int r = (int)(n % _base_num);
                result = _alphabet[r] + result;
                n /= _base_num;
            }

            return result;
        }
    }
}

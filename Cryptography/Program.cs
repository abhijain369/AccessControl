using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = CommonUsers.Get();
            Console.WriteLine("Common Password and their MD5 hashes");
            foreach (var user in users) 
            {
                Console.WriteLine(user.Username + "     "  + user.Password + "     "  + GetMd5Hash(user.Password)); 
            }
            Console.ReadLine();
            /*Check https://hashtoolkit.com/common-passwords/ for MD5 hashes */
            Console.WriteLine("Common Password and their MD5 hashes with salt");
            
            foreach (var user in users)
            {
                var hashWithSalt = GetMd5HashWithSalt(user.Password);
                Console.WriteLine(user.Username + "     " + user.Password + "     " + hashWithSalt.Item1 + "     " + hashWithSalt.Item2);
            }
            Console.ReadLine();
        }




        private static string GetMd5Hash(string input)
        {
            var hasher = MD5.Create();
            var data = hasher.ComputeHash(Encoding.Default.GetBytes(input));
            var builder = new StringBuilder();
            for (var i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }

        private static Tuple<string,string> GetMd5HashWithSalt(string input)
        {
            var rng = new RNGCryptoServiceProvider();

            var buff = new byte[8];

            rng.GetBytes(buff);

            var salt = Convert.ToBase64String(buff);

            var hasher = MD5.Create();

            var data = hasher.ComputeHash(Encoding.Default.GetBytes(input + salt));

            var builder = new StringBuilder();

            for (var i = 0; i < data.Length; i++)

            {

                builder.Append(data[i].ToString("x2"));

            }


            return new Tuple<string, string>(builder.ToString(), salt);
        }
    }
}

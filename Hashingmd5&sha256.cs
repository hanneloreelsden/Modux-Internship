using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();
            var text = (str);
            
            using (var md5 = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(text);
                var hashBytes = md5.ComputeHash(sourceBytes);
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                Console.WriteLine("The MD5 hash of " + text + " is: " + hash);

            }
            using (var sha256 = SHA256.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(text);
                var hashBytes2 = sha256.ComputeHash(sourceBytes);
                var hash2 = BitConverter.ToString(hashBytes2).Replace("-", string.Empty);
                Console.WriteLine("The SHA-256 hash of " + text + " is: " + hash2);  
            }

        }   
    }
}
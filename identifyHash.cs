using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.IO;

namespace identifyHash
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter hash to identify: ");
            string inputhash = Console.ReadLine(); 
            if(inputhash.Length == 32)
            {
                Console.WriteLine(inputhash + " is an MD5 hash");
                Console.ReadLine();
            }
            if(inputhash.Length == 64)
            {
                Console.WriteLine(inputhash + " is a SHA-256 hash");
                Console.ReadLine();
            }
            Console.ReadLine();
            // Start of new section
            string[] lines = File.ReadAllLines(@"/Users/hanneloreelsden/Desktop/PwnedPasswordsTop100k.txt");  
            foreach (string line in lines)
            {
                var password = (line);

                using (var md5 = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5.ComputeHash(sourceBytes);
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    if(hash.Equals(inputhash))
                    {
                        Console.WriteLine("The password of " + hash + " is: " + password);
                        Console.ReadLine();
                    }
                }
                
                using (var sha256 = SHA256.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes2 = sha256.ComputeHash(sourceBytes);
                    var hash2 = BitConverter.ToString(hashBytes2).Replace("-", string.Empty);
                    if(hash2.Equals(inputhash))
                    {
                        Console.WriteLine("The password of " + hash2 + " is :" + password);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}





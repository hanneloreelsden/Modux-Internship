using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;

namespace Hashing2
{
    class calcHash
    {
            
        private void calculateMD5()
        {
            using (var md5 = MD5.Create())
            {
                Console.WriteLine("Enter text: ");
                string str = Console.ReadLine();
                var text = (str);
                var sourceBytes = Encoding.UTF8.GetBytes(text);
                var hashBytes = md5.ComputeHash(sourceBytes);
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                Console.WriteLine("The MD5 hash of " + text + " is: " + hash);

            }
        }
        
        private void calculateSHA256()
        {
            Console.WriteLine("Enter text: ");
            string str1 = Console.ReadLine();
            var text1 = (str1);
            using (var sha256 = SHA256.Create())
            {
                var sourceBytes2 = Encoding.UTF8.GetBytes(text1);
                var hashBytes2 = sha256.ComputeHash(sourceBytes2);
                var hash2 = BitConverter.ToString(hashBytes2).Replace("-", string.Empty);
                Console.WriteLine("The SHA256 hash of " + text1 + " is: " + hash2);  
            }
        }

        static void Main()
        {
            //creating object of calcHash
            calcHash p = new calcHash();
            p.calculateMD5(); // Calling method
            p.calculateSHA256(); // Calling method
            Console.ReadLine(); 
        }   
    }
}




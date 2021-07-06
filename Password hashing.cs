using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.IO;

namespace Password_hashing
{
    class Program
    {
        static void Main()
        {
            // Want to read in passwords file and calculate md5 and sha256 for each:
            //string fileContent = new WebClient().DownloadString("https://www.ncsc.gov.uk/static-assets/documents/PwnedPasswordsTop100k.txt");
            string[] lines = File.ReadAllLines(@"/Users/hanneloreelsden/Desktop/PwnedPasswordsTop100k.txt");  
            foreach (string line in lines)
            {
                var password = (line);

                using (var md5 = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5.ComputeHash(sourceBytes);
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    Console.WriteLine("The MD5 hash of " + password + " is: " + hash);
                }
                
                using (var sha256 = SHA256.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes2 = sha256.ComputeHash(sourceBytes);
                    var hash2 = BitConverter.ToString(hashBytes2).Replace("-", string.Empty);
                    Console.WriteLine("The SHA-256 hash of " + password + " is: " + hash2);  
                }
            }
        }
    }
}
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
                    if(hash.Equals("C378985D629E99A4E86213DB0CD5E70D"))
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
                    Console.WriteLine("The SHA-256 hash of " + password + " is: " + hash2); 
                    if(hash2.Equals("B3D17EBBE4F2B75D27B6309CFAAE1487B667301A73951E7D523A039CD2DFE110"))
                    {
                        Console.WriteLine("The password of " + hash2 + " is :" + password);
                        Console.ReadLine();
                    }
                     
                    
                }
                //Console.ReadLine();
            }
        }
    }
}
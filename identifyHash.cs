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
            string hash = Console.ReadLine(); 
            if(hash.Length == 32)
            {
                Console.WriteLine(hash + " is an MD5 hash");
                Console.ReadLine();
            }
            if(hash.Length == 64)
            {
                Console.WriteLine(hash + " is a SHA-256 hash");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
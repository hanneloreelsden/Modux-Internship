using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.IO;

namespace identifyHash
{
    class idHash
    {
        private void identifyHash()
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
        }
       
        static void Main()
        {
            //creating object of class idHash
            idHash p = new idHash();
            p.identifyHash(); // Calling method
            Console.ReadLine();        
        
        }
    }
}





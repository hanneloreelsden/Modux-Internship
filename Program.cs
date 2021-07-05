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
            string text = Console.ReadLine();
            {
                Console.WriteLine("MD5 hash of string \'" + text + "\' : ");
            }
            Console.ReadLine();
        }
    }
}
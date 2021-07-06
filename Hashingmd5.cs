using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();
            Console.WriteLine("Text is: " + str);
            Console.ReadLine();
            MD5 md5 = MD5.Create();
            byte[] hashData = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            Console.WriteLine(hashData);
        }   
    }
}
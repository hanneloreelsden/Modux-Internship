using System;
using System.Text;

namespace StrToByte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine(); 
            byte[] barr= Encoding.UTF8.GetBytes(text);
            Console.WriteLine(barr);
            Console.ReadLine();
        }
    }
}

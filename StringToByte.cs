using System;
using System.Text;

namespace StrToByte
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine(); 
            Console.WriteLine("Text is: " + str);
            Console.ReadLine();
            byte[] barr= Encoding.UTF8.GetBytes(str);
            for(int loop =0; loop<barr.Length-1; loop++)
            {
                Console.WriteLine("Byte of char \'" + str[loop] + "\' : " + barr[loop]);
            }
            Console.ReadLine();
        }
    }
}

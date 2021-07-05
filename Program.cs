using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StrToByte
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputSring = "Hello World";
            byte[] bArray = Encoding.ASCII.GetBytes(inputSring);
            foreach (byte bElements in bArray)
            {
                Console.WriteLine("{0} = {1}",  (char)bElements,  bElements);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Text;

namespace StrToByte
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Helo World.";
            
            //reading all characters as byte and storing them to byte[]
            byte[] barr = Encoding.ASCII.GetBytes(str);

            //printing characters with byte values
            for(int loop =0; loop<barr.Length-1; loop++)
            {
                Console.WriteLine("Byte of char \'" + str[loop] + "\' : " + barr[loop]);
            }

            //hit ENTER to exit
            Console.ReadLine();
        }
        
    }
}

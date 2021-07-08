using System;
using System.Linq;
using System.Text;
using System.Net;

namespace Cisco_Python_work
{
    static class decryption
    {
        static string salt = "dsfd;kfoA,.iyewrkldJKDHSUBsgvca69834ncxv9873254k;fg87";

        static void Decrypter(string pw)
        {
            var index = Int32.Parse(pw.Substring(0,2));
            string enc_pw = pw.Substring(2).Trim();
            // Create the cleartext list
            string cleartext = string.Empty;
            for(int i=0; i<enc_pw.Length; i+=2)
            {
                var hex_pw = enc_pw.Substring(i,i+2);
                foreach (int j in Enumerable.Range(0, hex_pw.Length))
                {
                    var cur_index = (j+index) % 53;
                    var cur_salt = (salt.Substring(cur_index));
                    var cur_hex_int = Int32.Parse(hex_pw.Substring(j,16));
                    //var cleartext_char = cur_salt ^ cur_hex_int;  
                }
            }
            Console.WriteLine(cleartext);
        }
        
        
        static void Main()
        {
            //input password here
            Decrypter("02000D490E110E2D40000A01");
        }
    }
}

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
            var enc_pw = pw.Substring(2).Trim();
            for(int i=0; i<enc_pw.Length; i+=2)
            {
                var hex_pw = enc_pw.Substring(i,i+2);
            }
            // Create the cleartext list
            string cleartext = string.Empty;
            foreach (int i in Enumerable.Range(0, hex_pw.Length))
            {
                var cur_index = (i+index) % 53;
                var cur_salt = Encoding.UTF8.GetBytes(salt[cur_index]);
                //
                var cur_hex_int =;
                var cleartext_char = cur_salt ^ cur_hex_int;  

            }
        }
        
        
        static void Main()
        {
            //input password here
            //Decrypter();
        }
    }
}

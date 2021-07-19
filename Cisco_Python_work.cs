using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace Cisco_Python_work
{
    public class decryption
    {
        public static string salt = "dsfd;kfoA,.iyewrkldJKDHSUBsgvca69834ncxv9873254k;fg87";

        public static string Decrypter(string pw)
        {
            int index = Int32.Parse(pw.Substring(0,2));
            string enc_pw = pw.Substring(2).Trim();
            string[] hex_pw = new string[pw.Length/2];
            for (int i=0; i<pw.Length/2-1; i++)
            {
                hex_pw[i] = enc_pw.Substring(2*i,2);
            }
            string[] cleartext = new string[hex_pw.Length];
            for (int i=0; i<hex_pw.Length-1; i++)
            {
                int cur_index = (i+index) % 53;
                int cur_salt = salt[cur_index];
                int cur_hex_int = Convert.ToInt32(hex_pw[i], 16); 
                int cleartext_int = cur_salt ^ cur_hex_int;
                char cleartext_char = Convert.ToChar(cleartext_int);
                string cleartext_str = Convert.ToString(cleartext_char);
                cleartext[i] = cleartext_str;
            }
            string result = "";
            foreach (string str in cleartext)
            {
                result = result + str;
            }
            Console.WriteLine(result);
            return result;
        }
        
        
        static void Main()
        {
            //input password here
            Decrypter("3830135554587b535b5a0e5709155d");
        }
    }
}

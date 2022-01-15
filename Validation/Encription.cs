using System;

namespace RodinaTurkey.Validation
{
    public class Encription
    {
        public static string Encryption(string text)
        {
            char[] x = text.ToCharArray();
            string sifrelenecekmetin = null;
            foreach (char item in x)
            {
                sifrelenecekmetin += Convert.ToChar(item +30);
            }
            return sifrelenecekmetin;
        }
        public static string Descryption(string text)
        {
            char[] x = text.ToCharArray();
            string cozulecekmetin = null;
            foreach (char item in x)
            {
                cozulecekmetin += Convert.ToChar(item -30);
            }
            return cozulecekmetin;
        }
    }
}
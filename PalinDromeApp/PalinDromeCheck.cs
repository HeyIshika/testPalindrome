using System;

namespace PalinDromeApp
{
    public class Palindrom
    {
        public bool IsPalindrom(string s)
        {
           string rev ="";
            
            for (int i = s.Length-1; i >=0; i--) //String Reverse
            {
                rev += s[i].ToString();
            }
            if (rev == s) // Checking whether string is palindrome or not
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}
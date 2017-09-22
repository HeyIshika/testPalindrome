using System;

namespace PalinDromeApp
{
    class Program
    {
        static void Main()
        {   

            Palindrom p1=new Palindrom();
            bool store=p1.IsPalindrom("ishika");
            if(store==true){
                Console.WriteLine("Palindrome");
            }
            else
            {
                 Console.WriteLine("Not Palindrome");
            }
        }   
    }
}

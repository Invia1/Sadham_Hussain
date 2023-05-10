using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PalinDromeStr
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String = ");
            string name=Console.ReadLine();
            string reverse = "";


            for (int i = name.Length- 1; i>= 0; i--) 
            { 
            reverse = reverse+name[i];
            }

            if(name == reverse) 
            {
                Console.WriteLine("String is Palindrome.");
            }
            else {
                Console.WriteLine("String is Not A PalinDrome");
            }
            Console.ReadKey();

        }
    }
}

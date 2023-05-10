using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringPalindome
    {

        public static void notMain(String[] args)
        {
            Console.WriteLine("Enter Your Number = ");
            int number = int.Parse(Console.ReadLine());

            int rem, reverse = 0;
            int temp = number;
            while (number > 0)
            {
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;

            }
            if (temp == reverse)
            {
                Console.WriteLine("This is PalinDrome Number .");
            }
            else
            {
                Console.WriteLine("not A PalinDrome .");
            }
            Console.ReadKey();


        }
    }
}
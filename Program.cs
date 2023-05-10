using System;
namespace Palindrome
{
    class MyPalindome
    {
        public static void notMain(string[] args)
        {
            Console.WriteLine("Enter Your No. = ");
            int no = int.Parse(Console.ReadLine());
            int rem, rev = 0;
            int temp = no;
            while (no > 0)
            {
                rem = no % 10;
                rev = (rev * 10) + rem;
                no = no / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("This is a PlinDrome No.");
            }
            else
            {
                Console.WriteLine("This is not PlinDrome No.");
            }
            Console.ReadKey();
        }

    }
}
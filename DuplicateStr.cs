using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DuplicateStr
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String = ");
            String str = Console.ReadLine();
            int count;

            char[] dup = str.ToCharArray();
            Console.WriteLine("Duplicate Characters in a Given String : ");


            for (int i =0; i < dup.Length; i++)
            {
                count = 1;
                for(int j=i;j < dup.Length; j++)
                {
                    if (dup[i] == dup[j]&&dup[i]!=" ")
                    {
                        count++;
                        dup[j] = "0";
                    }
                }
                if (count > 1 && dup[i] != "0") ;
                Console.WriteLine("{0} -{ 1 }", dup[i], count);
            }
        }
    }
}

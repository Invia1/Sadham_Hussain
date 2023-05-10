using System;
namespace CombineProgramme
{

    class Combine
    {
        public static void Main()
        {

            Console.WriteLine("Press 1  to Enter the Factorial Case :");
            Console.WriteLine("Press 2  to Enter the Prime  No. Case :");
            Console.WriteLine("Press 3  to Enter the fabonacci Case :");



            int state = int.Parse(Console.ReadLine());
            switch (state)
            {
                case 1:
                    Console.WriteLine("Factorial Programme is Running ... ");
                    factorial();
                    break;

                case 2:
                    Console.WriteLine("Prime No.  Programme is Running ... ");
                    PrimeNo();
                    break;

                case 3:
                    Console.WriteLine("fabonnaci Programme is Running ... ");
                    fabonaaci();
                    break;


                default:
                    Console.WriteLine("Invalid : erorr");
                    break;


            }


            static void factorial()
            {
                int i, fact = 1, number;
                Console.WriteLine("Enter Your Number for Factorial = ");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("factorail of " + number + " is " + fact);
            }

            static void PrimeNo()
            {
                int num, m = 0;
                Console.WriteLine("Enter the   number to Check  the Prime Number : ");

                num = int.Parse(Console.ReadLine());
                m = num / 2;

                if (num % m == 0)
                {

                    Console.WriteLine("The Number is not Prime Number .");

                }
                else
                {
                    Console.WriteLine("The Number is  Prime Number .");
                }

            }

            static void fabonaaci()
            {
                int no = 0, no1 = 1, no2, i, number;
                Console.WriteLine("Enter  a Number of elements u want ... ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine(no + " " + no1 + " ");

                for (i = 2; i <= number; i++)
                {
                    no2 = no + no1;
                    Console.WriteLine(no2);
                    no = no1;
                    no1 = no2;

                }

            }

        }

    }

}
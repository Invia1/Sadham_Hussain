using System;
namespace Usershopping
{
    class UserShopping
    {
        string Name;
        int amount;

        public string NAME
        {
            get { return Name; }
            set { Name = value; }   
        }
        public int AMOUNT
        {
            get
            { return amount;}
            set
            { 
                amount = value; 

                if(amount < 1000)
                {
                    Console.WriteLine("You  Not Eligible  for Shopping .");
                }
                else
                {

                    Console.WriteLine(Name + "You  are Eligible  for Shopping .");

                }
            
            
            }
        }

    }
    class UserShop
    {
        public void display()
        {
            var obj = new UserShopping();
            Console.WriteLine("Please Enter your Name : ");
            obj.NAME = Console.ReadLine();
           

            Console.WriteLine("Please Enter your Money : ");
            obj.AMOUNT= int.Parse(Console.ReadLine());

        }

    }

    class MainFunction{
        public static void Main()
        {

            var userShop = new UserShop();

            userShop.display();
        }
}

}
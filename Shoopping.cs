using System;
namespace Shopping
{
    class Shopping
    {

        int cartMoney;
        string Name;

        public int CARTMoney
        {
            get
            {
                return cartMoney;
            }
            set
            {
                cartMoney = value;
                if (cartMoney < 10000)
                {
                    Console.WriteLine("You are eligble Not for the  Shopping ");
                }
                else
                {
                    Console.WriteLine("You are eligble Not for the  Shopping .");
                }
            }
        }

        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
 
                Name = value;   
            }
        }

    }

    class ShopNow
    {
        public void ShopCart()
        {
            var shopped = new Shopping();
            shopped.NAME = "ARMAAN HUSSAIN";
            shopped.CARTMoney = 9000;


        }

    }

    class Programme
    {
      
        public static void Main() { 
            var shopp = new ShopNow();
            shopp.ShopCart();
        
        }
    }
}
 
using System;
using System.Collections.Generic;

namespace GenericClass
{
 public class Player
    {

        public void Records<M,N>(M Matches , N Name )
        {
            Console.WriteLine("No. Of Matches : " + Matches + "\n Name of Players : "+ Name   );
        }

       class PlayersList
        {

            public  static void Main()
            {

                Player obj1 = new Player();
                obj1.Records<int ,string>(70777,"Ms Dhoni ");

                Player obj2 = new Player();
                obj2.Records<int, string>(7777, "Virat Kohi");
                Player obj3 = new Player();
                obj2.Records<int, string>(77, "Sachin Tandulker ");
            }
        }

    }
}
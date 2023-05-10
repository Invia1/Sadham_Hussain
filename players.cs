using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenthMay
{
     class players
    {

        object[] Myplayers = new object[5];

        public object  this[int i]
        {
            get
            {
                return Myplayers[i];

            }
            set{
                Myplayers[i] = value;   

            }
        }

    }


    class AllPlayers
    {


        public static  void Main()
        {

            players obj =  new players();
            obj[0] = "MS Dhoni";
            obj[1] = "Virat Kohli";
            obj[2] = "brandon mAccullam";
            obj[3] = "Sachin Tendulkar";
            obj[4] = "Ramesh Tendulkar";
            //obj[5] = "Sachin Kumar";


            Console.WriteLine(obj[0] + " " + obj[1] + " " + obj[2] + " " + obj[3] + " " + obj[4]);
                 
        }
    }
}

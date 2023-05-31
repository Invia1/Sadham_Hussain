using System;
//using System.Collections.Generic;


namespace predifinedDeligates
{
     class lambda
    {

        public string StdName(string name)
        {
            return name;
        }



        public int  addNo(int a , int b, int c)
        {
            int d = a+ b + c;
            return d;
        }

        public void  modlulous(string name , int age)
        {
            Console.WriteLine("Ur name is = "+ name + " and age is : "+ age );
        }
        public bool chkLength(string str)
        {
            if (str.Length >= 5)
                return true;
            return false;
        }
    }


    class Programme
    {
        public static void Main()
        {
            lambda obj = new lambda();
            Func<string, string> objfunc = obj.StdName;
            string result = objfunc.Invoke("sadham Hussain");
            Console.WriteLine(result);

            Func<int, int, int, int> objFunc1 = obj.addNo;
            int result1 = objFunc1.Invoke(31,11,15);
            Console.WriteLine("Addition of total no  is :" + result1);


         

            Action<string , int> objModules = obj.modlulous;
            objModules.Invoke("Mahiii", 45);

            Predicate<string> chklen = obj.chkLength;
            bool status = chklen.Invoke("Dear Commrade");
            Console.WriteLine(status);
            
        }
    }
}

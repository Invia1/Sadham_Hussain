//using System;
//namespace predefinedDelegates
//{
//    class predefined
//    {
//        public int addNum(int x, int y, int z)
//        {
//            int a = x + y + z;
//            return a;
//        }


//        public void subNum(int x, int y, int z)
//        {

//            Console.WriteLine(x + y + z);
//        }

//        public bool chkLength(string str)
//        {
//            if (str.Length >= 5)
//                return true;
//            return false;
//        }
//    }

//    class Programme
//    {
//        public static void Main()
//        {
//            predefined obj = new predefined();
//            Func<int, int, int, int> objfunc = obj.addNum;

//            int result = objfunc.Invoke(12, 12, 12);
//            Console.WriteLine(result);

//            Action<int, int, int> objAction = obj.subNum;
//            objAction.Invoke(3, 5, 7);

//            Predicate<string> objPredicate = obj.chkLength;

//            bool status = objPredicate.Invoke("Hello Status");
//            Console.WriteLine(status);
//            Console.ReadKey();

//        }

//    }

//}
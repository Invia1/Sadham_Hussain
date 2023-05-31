//using System;
//using System.Threading;


//namespace Threading
//{
//     class MultipleThreads
//    {
//        public void school() {

//            Console.WriteLine("School days starts from 2015 .\n");
//            Thread.Sleep(2000);
//            Console.WriteLine("School days are ending at 2020 .\n");
//                }


//        public void collage()
//        {

//            Console.WriteLine("Collages days are start from the 2017 .\n");
//            Thread.Sleep(3500);
//            Console.WriteLine("Collages days are end at the 2023 .\n");
//        }

//        public void traniee()
//        {
//            Console.WriteLine("training starts from may 2023 .\n");

//            Console.WriteLine("----------------------_______________");
//            Thread.Sleep(5000);
//            Console.WriteLine("training days are end at the  august 2023 .\n");
//        }

//    }

//    class Days
//    {

//        public static void Main(string[] args)
//        {

//            MultipleThreads obj= new MultipleThreads();

//            Thread th1 = new Thread(new ThreadStart(obj.school));
//            th1.Start();
//            Thread th2 = new Thread(new ThreadStart(obj.collage));
//            th2.Start();
//            Thread th3 =  new Thread(new ThreadStart(obj.traniee));
//            th3.Start();
//        }
//    }
//}

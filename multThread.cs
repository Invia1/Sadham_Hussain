//using System;
//using System.Threading;

//namespace multiThreading
//{

//    class MultiThreads
//    {
//        public void Function1()
//        {
//            Console.WriteLine("Thread Function 1 is started");
          
//            for (int i = 0; i <= 7; i++)
//            {
//                Console.WriteLine("func1 : "+ i);
//                if (i == 3)
//                {
//                    Console.WriteLine("Function1  is in sleep state  for 3 sec");
//                    Thread.Sleep(3000);
//                    Console.WriteLine("Function1 resume");

//                }
               
//            }
//        }
//        public void Function2()
//        {
//            Console.WriteLine("Thread Function 2 is started");
            
//            for (int j = 0; j < 10; j++)
//            {
//                Console.WriteLine("func2 : "+ j);
//                if (j == 7)
//                {
//                    Console.WriteLine("Function2  is in sleep state for 5 sec ");
//                    Thread.Sleep(5000);

//                    Console.WriteLine("Function2 resume");

//                }
               
//            }


//        }
//        public void Function3()
//        {
//            Console.WriteLine("Thread Function 3 is started");
//            int k = 0;
//            for (k = 0; k < 15; k++)
//            {
//                Console.WriteLine("func3 : "+ k);
//                if (k == 11)
//                {
//                    Console.WriteLine("Function3  is in sleep state for 7 sec ");
//                    Thread.Sleep(7000);
//                    Console.WriteLine("Function3 resume");
//                }
               
//            }

//        }
//    }
//    class MainThread
//        {
//            public static void Main()
//            {
//                MultiThreads obj = new MultiThreads();

//                Thread th1 = new Thread(new ThreadStart(obj.Function1));
//                th1.Start();


//                Thread th2 = new Thread(new ThreadStart(obj.Function2));
//                th2.Start();


//            Thread th3 = new Thread(new ThreadStart(obj.Function3));
//            th3.Start();

//        }
//        }
    
//}

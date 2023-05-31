using System;
using System.Threading;

namespace multThread
{
    class ThreadProgram
    {
        public static void CallChild()
        {
            Console.WriteLine("Child thread starts from here");
        }
        static void Main(string[] args)
        {
            ThreadStart obj1 = new ThreadStart(CallChild);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(obj1);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
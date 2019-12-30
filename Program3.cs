using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3012T
{

    class Program
    {

        static void Count123()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"............... Count {i} .....................");
                Thread.Sleep(1000);
            }
            Console.WriteLine("************************* Boom ******************");
        }
        private static int correct = 18*4;
        static void GetNumber()
        {
        }
        static void Main(string[] args)
        {
            Console.WriteLine("18 X 4 = ");
            Thread counterThread = new Thread(Count123);
            counterThread.Start();

            counterThread.Join();

            Console.WriteLine("Main has ended...");
            Console.WriteLine(counterThread.ThreadState);
        }
    }
}

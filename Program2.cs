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
            for (int i = 2; i >= 1; i--)
            {
                Console.WriteLine($"............... Count {i} .....................");
                Thread.Sleep(1000);
            }
            Console.WriteLine("************************* Boom ******************");
        }
        private static int correct = 18*4;
        static void GetNumber()
        {
            Console.ReadLine();
            /*
            int number = 0;
            while (int.TryParse(Console.ReadLine(), out number) == false) ;
            while (number != correct)
            {
                Console.WriteLine("Wrong!!");
                while (int.TryParse(Console.ReadLine(), out number) == false);
            }
            */
        }
        static void Main(string[] args)
        {
            Console.WriteLine("18 X 4 = ");
            Thread counterThread = new Thread(Count123);
            counterThread.Start();

            Thread answerThread = new Thread(GetNumber);
            answerThread.Start();

            while (counterThread.ThreadState != ThreadState.Stopped && answerThread.ThreadState != ThreadState.Stopped)
            {
                Thread.Yield();
            }

            if (counterThread.ThreadState == ThreadState.Stopped)
            {
                answerThread.Abort();
                Console.WriteLine("You Lost!!!!");
            }
            else
            {
                counterThread.Abort();
                Console.WriteLine("You won!!!!");
            }

            Console.WriteLine("Main has ended...");
            Console.WriteLine(counterThread.ThreadState);
            Console.WriteLine(answerThread.ThreadState);
        }
    }
}

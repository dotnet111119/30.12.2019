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

        static void Run1()
        {
            Console.WriteLine($"Hello from Run1 method! {Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
        }

        static void Run1_10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Thread [{Thread.CurrentThread.ManagedThreadId}] : {i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            //Thread t = new Thread(Run1);
            //t.Name = "Ti1";
            //t.Start();
            //Thread.Sleep(1000);

            for (int i = 0; i < 3; i++)
            {
                Thread t = new Thread(Run1_10);
                t.Name = "Ti1";
                t.Start();
            }

            Console.WriteLine("Main has ended");
        }
    }
}

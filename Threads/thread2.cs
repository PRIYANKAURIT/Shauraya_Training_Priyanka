using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Threads
{
    public class thread2
    {
        public static void Threadwork()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i+Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;

           thread2 ob = new thread2();
            Console.WriteLine("Hello World");
            Console.WriteLine("Good Afternoon.....Welcome");
           /* Thread t1 = new Thread(m1);
            t1.Name = "priya";
            t1.Start();
            Thread.Sleep(1000);*/
            for(int i = 11; i <= 20; i++)
            {
                Console.WriteLine("main" +i);
                Thread.Sleep(1000);
            }
            
        }
    }

    public class thread3
    {
        public static void Threadwork()
        {
            for (int i = 1; i < 10; i++)
            {

            }
 
        }

    }
}

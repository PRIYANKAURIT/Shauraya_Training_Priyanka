using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Threads
{
    public class thread1
    {
        
            public static void intge()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        class MM
        {
            static void Main(string[] args)
            {
                Console.WriteLine("hii");
                Console.WriteLine("suraj");
                Thread t1 = new Thread(thread1.intge);
                t1.Start();
                for (int i = 11; i < 21; i++)
                {
                    Console.WriteLine(i + "");
                }

            }
        }
    }


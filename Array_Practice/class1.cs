using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Array_Practice
{
    //WAP to find input and output
    public class class1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];            //array create
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());    //give input from user

            }
            Console.WriteLine("ans=" + a[3]);   //display arraay
        }
    }

    public class class2
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("Even number :" + a[i]);        //even number : 2,4   odd:1,3,5
                    even++;
                }



                else
                {
                    Console.WriteLine("Odd number :" + a[i]);
                    odd++;
                }

            }
            Console.WriteLine("number of even numbers:" + even);
            Console.WriteLine("number of odd numbers:" + odd);
        }
    }

    public class class3
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int even = 0;
            int odd = 0;
            

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even number :");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i]+" ");
                    even++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Odd number :");
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] % 2 != 0)
                {
                    Console.Write(a[j]+" ");
                    odd++;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("number of even numbers:" + even);
            Console.WriteLine("number of odd numbers:" + odd);
        }

    }
}



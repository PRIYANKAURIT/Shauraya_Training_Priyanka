using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training
{
    public class shauryafinal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Convert.ToString(Console.ReadLine());
            string[] s1 = s.Split(" ");
            for (int i = 0; i < s1.Length; i++)
            {
                string word = s1[i];
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    Console.Write(word[j]);
                }
                Console.Write(" ");
            }

        }
    }
    class prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    c++;
                }

            }
                if (c == 2)
                {
                    Console.WriteLine("number is prime" );
                }
                else
                {
                    Console.WriteLine("number is not prime" );
                }                               
        }
    }
    public class primenumbers
    {
        static void Main()
        {

            bool isPrime = true;
            Console.WriteLine("Prime Numbers are : ");
            for (int i = 2; i <= 50; i++)
            {
                for (int j = 2; j <= 50; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
        }
    }
    public class mult
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int mult = 0;
            for (int i = 1; i <= b; i++)
            {
                mult =mult + a;
            }
            Console.WriteLine(mult);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.xobin
{
    public class Coprime
    {


        static int gcd(int a, int b)
        {

            if (a == 0 || b == 0)
                return 0;


            if (a == b)
                return a;


            if (a > b)
                return gcd(a - b, b);

            return gcd(a, b - a);
        }

        static void coprime(int a, int b)
        {

            if (gcd(a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }


        public static void Main(string[] args)
        {
            int a = 5, b = 6;
            coprime(a, b);
            a = 8;
            b = 16;
            coprime(a, b);
        }
    }

    class toggle
    {
     

        static void toggleChars(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    str[i] = (char)(str[i] ^ (1 << 5));
                }
            }
        }

        // Driver code
        public static void Main(String[] args)
        {
            char[] str = "GeKf@rGeek$".ToCharArray();
            Console.WriteLine("String before toggle ");
            Console.WriteLine(String.Join("", str));
            toggleChars(str);
            Console.WriteLine("String after toggle ");
            Console.WriteLine(String.Join("", str));
        }
    }

    // This code is contributed by @kaustubhvats08

}

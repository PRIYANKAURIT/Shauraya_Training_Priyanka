using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.pattern_task
{
    public class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }

    /*
    ******
    ****
    ***
    **
    *
    */
    public class Class2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
    }
/*
    *****
     ****
      ***
       **
        *
        *
      
*/

    public class Class3
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for(int c=5-i;c>=1;c--)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine("");
            }

        }
    }
}
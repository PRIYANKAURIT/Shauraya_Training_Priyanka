using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.sortsearch_task
{
    //sort and then search
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int temp;

            Console.WriteLine("Enter numbers");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            for(int i = 0; i < a.Length; i++)
            {
                
                for(int j=0; j < a.Length; j++)
                {
                    if(a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                   
                }
                
            }
            for(int i=a.Length-1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Enter number for search");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i<=a.Length-1;i++)
            {
                if (a[i]==n)
                {
                    Console.WriteLine("found");
                }
                else
                {
                    Console.WriteLine("not found");
                }
                
            }
            
        }


    }
    /*10. Write a C# Sharp program to sort a list of elements using the Radix sort algorithm.
       Go to the editor Radix sort is a non-comparative integer sorting algorithm that sorts 
        data with integer keys by grouping keys 
        by the individual digits which share the same significant position and value.*/
    public class Class2
    {


    }
/*
    14. Write a program in C# Sharp to get the reverse of a string using recursion. Go to the editor
Test Data :
Input the string : w3resource
Expected Output :
The reverse of the string is : ecruoser3w*/

    public class Class3
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

   /* 15. Write a program in C# Sharp to calculate the power of any number using recursion. Go to the editor
Test Data :
Input the base value : 5
Input the exponent : 3
Expected Output :
The value of 5 to the power of 3 is : 125*/

    public class Class4
    {
        static void Main(string[] args)
        {
            int b1 = 5;
            int e1 = 3;

        }
    }
}

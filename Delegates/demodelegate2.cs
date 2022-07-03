using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Delegates
{
    public delegate void del1(int a, int b);
    public class demodelegate2
    {
        static void add(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }

        static void subtract(int a, int b)
        {
            Console.WriteLine("subtract =" + (a - b));
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine("multiply =" + (a * b));
        }

        static void Main(string[] args)
        {
            del1 d1 = add;        //multicasting +=
            d1 += subtract;
            d1 += multiply;
        }
    }

    //annonymous method
    public delegate void del2(int a, int b);
    public class demodelegate3
    {
        static void add(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }

        static void subtract(int a, int b)
        {
            Console.WriteLine("subtract =" + (a - b));
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine("multiply =" + (a * b));
        }

        static void Main(string[] args)
        {
            del2 d2 = delegate (int a, int b)
            {
                Console.WriteLine("anonymous method for add" + (a + b));
            };
            d2(8, 2);

            d2 += delegate (int a, int b)
             {
                 Console.WriteLine("anonymous method for sub" + (a - b));
             };
            d2(8, 2);

            d2 += delegate (int a, int b)
            {
                Console.WriteLine("anonymous method for mult" + (a * b));
            };
            d2(8, 2);
        }
    }


    //lambda expression

    public delegate void del3(int a, int b);
    public class demodelegate4
    {
        static void add(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }

        static void subtract(int a, int b)
        {
            Console.WriteLine("subtract =" + (a - b));
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine("multiply =" + (a * b));
        }

        static void Main(string[] args)
        {
            del3 d3 = (a,b) => Console.WriteLine("lambda exprssion for add" + (a + b));
            d3(8, 2);

            d3+= (a, b) => Console.WriteLine("lambda exprssion for sub" + (a - b));
            d3(8, 2);

            d3 += (a, b) => Console.WriteLine("lambda exprssion for mult" + (a * b));
            d3(8, 2);

        }
    }


    public delegate int del4(int a, int b);
    public class demodelegate5
    {
        static void add(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }

        static void subtract(int a, int b)
        {
            Console.WriteLine("subtract =" + (a - b));
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine("multiply =" + (a * b));
        }

        static void Main(string[] args)
        {
            del4 d4 = (a, b) =>
            {
                return a + b;
            };
           
            del4 d4_1= (a, b) => a + b;
            Console.WriteLine("ans=" +d4_1(8,9));

            /*del4 d4+= (a, b) =>
            {
                return a - b;
            };
            del4 d4+= (a, b) =>
            {
                return a * b;
            };*/

        }
    }

    public delegate int del5(int a, float b, long m);
    public class demodelegate6
    {
        static int add(int a,float b,long m)
        {
            Console.WriteLine("ADD:"+(a+b));
            return (int)(a + b);
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good Afternoon" + nm );
        }
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, long, int> f1 = add;
            int ans = f1(10, 3.4f, 90l);
            Action<string> f2 = greet;
            f2("priya");
            Predicate<int> f3 = isEven;
            Console.WriteLine(f3(67));
        }
    }


    //public delegate int del6(List<int> 1st Predicate<int> p1);
    public class demodelegate7
    {
        /*static void Filter(List<int> 1st Predicate<int> p1)
        {
            foreach(int element in 1st)
            {
                bool b = p1(element);
                if(b==true)
                    Console.WriteLine(element);
            }
        }*/
    }
}//delegate genric
//func
//Action
//Predicate
//func ----if ur method takes n input and return value back
//Action ----when ur method takes n input and return type is void
//


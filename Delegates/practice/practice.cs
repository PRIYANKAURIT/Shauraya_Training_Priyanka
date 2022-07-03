using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Delegates.practice
{
    public delegate void myde(string nm, string addr);
    public delegate int mydel(int n);
    internal class Demodel
    {
        public static void info(string nm, string addre)
        {
            Console.WriteLine("name=" + nm + " address=" + addre);
        }
        public static int facto(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Mainnnnnnnnnnnnnnn");
            //Console.ReadLine();
            myde md = Demodel.info;
            mydel m = Demodel.facto;
            // Console.WriteLine("hii");
            int res = m(5);
            Console.WriteLine(res);
            md("suraj", "pune");
        }
    }


    //here no need to write function seprate you can directly assign.
    class Mathh1
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("sum=" + (a + b));
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("sub=" + (a - b));
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("mul=" + (a * b));
        }
    }
    public delegate void del1(int a, int b);
    public delegate int del2(int a, int b);
    class Anonomus
    {
        static int add1(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            del1 d1 = delegate (int a, int b)//here you mak
            {
                Console.WriteLine("annonomus method" + (a + b));
            };
            d1(10, 2);
            Console.WriteLine("---------------------------");
            //lamda expr
            //


            del1 d2 = (a, b) =>//here no need to specify data type beacause when already declare when creating delegate
            {
                Console.WriteLine("lamda=" + (a + b));
            };
            d2(5, 5);
            // del1 d2 = (a, b) => Console.WriteLine("lamda another way="+(a+b));   you declare lamda like this also.
            Console.WriteLine("------------------------");

            del2 d3 = (a, b) => a + b;
            Console.WriteLine("answer=" + d3(10, 20));
        }
    }


    class GenDel
    {
        static int add(int a, float b)
        {
            Console.WriteLine("add=" + (a + b));
            return (int)(a + b);
        }
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void greet(String s)
        {
            Console.WriteLine("Good Afternoon " + s);
        }
        static void Main(string[] args)
        {
            //Func=if yours method takes n input and return value back.
            //Acion=when method takes n imput and return type void.means nothig return return.
            //predicate=its return bool type;

            Func<int, float, int> f1 = add;
            int ans = f1(10, 5.2f);


            Predicate<int> p1 = isEven;
            Console.WriteLine(p1(45));


            Action<string> a1 = greet;
            a1("suraj yadav.");
        }
    }


    //if one delegate point more than one funtin then it called multicasting delegate;
    //you can declare delegate anywhere in programe in class also.

    class Mathh
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("sum=" + (a + b));
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("sub=" + (a - b));
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("mul=" + (a * b));
        }
    }
    public delegate void myd(int a, int b);
    class Multicastdel
    {
        static void Main(string[] args)
        {


            myd d = Mathh.add;
            d = d + Mathh.sub;
            d += Mathh.mul;//here you give 3 function referece to del d.
            d(5, 4);//this value pass all three function.
            d -= Mathh.sub;//also remove any function.
            Console.WriteLine("-------------------");
            d(5, 2);
        }

        class Class1
        {
            static bool iseven(int a)
            {
                return a % 2 == 0;
            }
            static void Main(string[] args)
            {
                List<int> l1 = new List<int>() { 23, 22, 14, 7, 45, 74, 12 };
                List<int> l2 = l1.FindAll((a) => a % 2 == 0);
            }
        }
    }
}

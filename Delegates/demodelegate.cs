using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//delegate is variable which hold reference of function
//delegate is a pointer function
//declare
//set target function to delegate


namespace shaurya_training.Delegates
{
    public delegate void mydel(string msg, string nm);   //declare delegate top of the class 
    public class demodelegate
    {
        static void greet(string msg,string nm)
        {
            Console.WriteLine("Welcome" +nm+ "," +msg);
        }
        static void Main(string[] args)
        {
            mydel d1 = demodelegate.greet;     
            d1("Good Evening", "priya");
        }
    }

    public delegate int mydel1(int n);
    public class demodelegate1
    {
        static int factorial(int n)
        {
            int fact = 1;
            for(int i=1; i <= n; i++)
               fact = fact * i;
            return fact;
        }
        static void Main(string[] args)
        {
            mydel1 d2 = demodelegate1.factorial;
            int ans = d2(5);
            Console.WriteLine(ans);
        }
    }
}

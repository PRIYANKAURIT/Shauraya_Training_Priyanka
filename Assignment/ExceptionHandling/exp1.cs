using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Assignment.ExceptionHandling
{
    /*10.	What is Exception Handling in C#?
		 => Exception is an abnormal termination which is occured at run time.Exception handling is to handle exception by using
		try,catch,finally,throw block.

		11.	What is the difference between System exceptions and Application exceptions?
	    => System level Exceptions :- 
                                      System exceptions are derive directly from a base class System.SystemException.
            A System level Exception is normally thrown when a nonrecoverable error has occurred, such as a database crash.
            These are common exceptions that are thrown by the .NET Common Language Runtime and used in almost all .Net
            applications.
          
           Application level Exceptions :-               
                                          Application exceptions can be user defined exceptions thrown by the applications.
           If you are designing an application that needs to create its own exceptions class, you are advised to derive
           custom exceptions from the System.ApplicationException class. It is typically thrown when a recoverable error 
           has occurred, such as an invalid input argument values to a business method. It will alert the client of 
           application specific or business logic issues; they do not report system level exceptions In most cases,
           clients can be return to normal processing after solving application exceptions.

		12.	What is the main use of a finally block in exception handling?
        =>  clean up any resources that are allocated in a try block, and you can run code even 
            if an exception occurs in the try block.*/

    /*13.	 WAP which throws IndexOutOfRangeException.In the console, observe the stack trace and the line number from 
			where the Exception is thrown*/

    internal class exp1
    {
        static void Main(string[] args)
        {

            int[] n = new int[5] { 66, 33, 56, 23, 81 };
            int i, j;
            // error: IndexOutOfRangeException
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();



        }

    }

    /*14.	WAP to use catch / handle the IndexOutOfRangeException exception*/

    public class Class2
    {
        public void calculatedifference()
        {
            int difference = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for (int init = 1; init <= 5; init++)
                {
                    difference = difference - number[init];
                }
                Console.WriteLine("The difference of the array is:" + difference);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class classmain
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.calculatedifference();
            Console.ReadLine();
        }
    }

    /*15.	WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
	and DivideByZeroException.*/

    public class Class15
    {
        static void Main()
        {


            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };


            for (int j = 0; j < number.Length; j++)

                try
                {

                    Console.WriteLine("Number: " + number[j]);
                    Console.WriteLine("Divisor: " + divisor[j]);
                    Console.WriteLine("Quotient: " + number[j] / divisor[j]);
                }
                catch (DivideByZeroException)
                {

                    Console.WriteLine("Not possible to Divide by zero");
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is Out of Range");
                }
                

        }
        /*16.	WAP to show checked exception and use multiple catch block with universal Exception handler.*/

        internal class Class16
        {
            static void Main(string[] args)
            {
                int a, b, c;
                Console.WriteLine("ENTER ANY TWO NUBERS");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("C VALUE = " + c);
                }
                catch (DivideByZeroException dbze)
                {
                    Console.WriteLine("second number should not be zero");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("enter only integer numbers");
                }
                Console.ReadKey();
            }
        }
   
        /*17.	WAP to check Exception handling with method overriding. Means, If super class method don’t
        declare exception then subclass overridden method can declare exception or not.*/

        internal class Class17
        {
            public virtual void add()
            {

            }
        }
        class child : Overiddenexception
        {
            public override void add()
            {
                try
                {
                    Console.WriteLine("enter number");
                    int num = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }
        }
        /*18.	WAP to create custom Exception and show use of throw keyword*/

        public class Class18
        {
            public static void Main()
            {
                Student std = null;

                try
                {
                    PrintStudentName(std);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }

            public static void PrintStudentName(Student std)
            {
                if (std == null)
                    throw new NullReferenceException("Student object is null. ");

                Console.WriteLine(std.StudentName);
            }
        }

        public class Student
        {
            public string StudentName { get; set; }
        }
   
        /*19.	WAP to create user defined Exception raise and catch the exception.*/

        internal class Class19
        {
            static void Main(string[] args)
            {
                Fitness f = new Fitness();
                try
                {
                    f.showResult();
                }
                catch (FitnessTestFailedException e)
                {
                    Console.WriteLine("User defined exception: {0}", e.Message);
                }
                Console.ReadKey();
            }
        }
    }

    public class FitnessTestFailedException : Exception
    {
        public FitnessTestFailedException(string message) : base(message)
        {
        }
    }

    public class Fitness
    {
        int points = 0;

        public void showResult()
        {

            if (points < 110)
            {
                throw (new FitnessTestFailedException("Player failed the fitness test!"));
            }
            else
            {
                Console.WriteLine("Player passed the fitness test!");
            }
        }
    }


    //practice
    class Overiddenexception
    {
        public virtual void add()
        {

        }
    }
    class child : Overiddenexception
    {
        public override void add()
        {
            try
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }

    class MultipleException
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                try
                {
                    Console.WriteLine("enter any number");
                    int a = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                string s = null;
                Console.WriteLine(s.ToLower());
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }

            catch (NullReferenceException nr)
            {
                Console.WriteLine(nr.Message);
            }
        }
    }

    class IndexOutofbound1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
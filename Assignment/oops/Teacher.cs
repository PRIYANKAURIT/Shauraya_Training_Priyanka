using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create class Teacher with following
	Tid, Tname, MobileNo
	Parameterized constructor
	abstract void salary()
•	Create class Hourlybased which is derived class from teacher with fields
	 rate_per_hr,
	int hrs;
Parameterized constructor
	void salary()
•	Create class SalaryBased which is derived class from teacher
	with fields
	 int salary;
Parameterized constructor
	void salary()
Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective salary
method and also show runtime polymorphism
*/


namespace shaurya_training.Assignment.oops
{
	//internal class Teacher
	/* {
		 public int Tid, MobileNo;
		 public string Tname;

		 public Teacher(int tid, int mobileNo, string tname)
		 {
			 Tid = tid;
			 MobileNo = mobileNo;
			 Tname = tname;
		 }

		 abstract void Salary();

	 }
	 internal class Hourlybased : Teacher
	 {
		 public int hrs, rate_per_hr;

		 public Hourlybased(int hrs, int rate_per_hr)
		 {
			 this.hrs = hrs;
			 this.rate_per_hr = rate_per_hr;
		 }
		 void salary(int salary)
	 }*/
	/*public abstract class Teacher
	{
		public int tid;
		public string tname;
		public long mobileno;

		

		public Teacher(int tid, string tname, long mobileno)
		{
			this.Tid = tid;
			this.Tname = tname;
			this.Mobileno = mobileno;
		}

		public int Tid { get => tid; set => tid = value; }
		public string Tname { get => tname; set => tname = value; }
		public long Mobileno { get => mobileno; set => mobileno = value; }

		public abstract void salary();
	}
	class Hourlybased : Teacher
	{

		int rate_per_hr, hrs;

		public Hourlybased(int rate_per_hr, int hrs)
		{
			this.rate_per_hr = rate_per_hr;
			this.hrs = hrs;
		}

		public override void salary()
		{
			Console.WriteLine("This is hourly based method");
		}
	}
	class SalaryBased : Teacher
	{

		int sal;

		public SalaryBased(int sal)
		{
			this.sal = sal;
		}

		public override void salary()
		{
			Console.WriteLine("This is salary based method");
		}
	}
	class Question1
	{
		static void Main(string[] args)
		{
			Hourlybased myhourlybased = new Hourlybased(4, 1);
			SalaryBased mysalaryBased = new SalaryBased(4500);
			myhourlybased.salary();
			mysalaryBased.salary();
		}
	}
	*/
	/*2.	A Pen contains variables Refill r, int capLength and String brand.
		Refill has variables inkColor, length and Nib(tip).
	 Nib has variables materialType and width.
	Create a Java class structure for above.
Write a main method which sets values in all the variables
using setter methods and prints all the variables using getter methods.
*/
	/*
	internal class pen
	{
		public string refill, brand;
		public int capLength;

		public void setrefill(string r)
		{
			refill = r;
		}

		public string getrefill()
		{
			return refill;
		}

		public void setbrand(string b)
		{
			brand = b;
		}

		public string getbrand()
		{
			return brand;
		}

		public void setcapLength(int c)
		{
			capLength = c;
		}

		public int getcapLength()
		{
			return capLength;
		}

		class Refill : pen
		{
			public string inkColor, Nib;
			public int length;

			public void setinkColor(string i)
			{
				inkColor = i;
			}

			public string getinkColor()
			{
				return inkColor;
			}

			public void setNib(string n)
			{
				Nib = n;
			}

			public string getNib()
			{
				return Nib;
			}

			public void setlength(int l)
			{
				length = l;
			}

			public int getlength()
			{
				return length;
			}
		}
		class Nib : Refill
		{
			public string Materialtype;
			public int width;

			public void setMaterialtype(string m)
			{
				Materialtype = m;
			}

			public string getMaterialtype()
			{
				return Materialtype;
			}

			public void setwidth(int w)
			{
				width = w;
			}

			public int getwidth()
			{
				return width;
			}
		}

		class Test
		{
			static void Main(string[] args)
			{
				Nib p = new Nib();
				p.setrefill(Console.ReadLine());
				p.setbrand(Console.ReadLine());
				p.setcapLength(Convert.ToInt32(Console.ReadLine()));
				p.setinkColor(Console.ReadLine());
				p.setNib(Console.ReadLine());
				p.setlength(Convert.ToInt32(Console.ReadLine()));
				p.setMaterialtype(Console.ReadLine());
				p.setwidth(Convert.ToInt32(Console.ReadLine()));

				Console.WriteLine("Refill" + p + "Brand" + p + "CapLength" + p + "Inkcolor" + p + "Nib" + p + "Length" + p + "MaterialType" + p + "Width" + p);
				Console.WriteLine(p.getrefill());
				Console.WriteLine(p.getbrand());
				Console.WriteLine(p.getcapLength());
				Console.WriteLine(p.getinkColor());
				Console.WriteLine(p.getNib());
				Console.WriteLine(p.getlength());
				Console.WriteLine(p.getMaterialtype());
				Console.WriteLine(p.getwidth());


			}
		}

	*/

		/*3.	Write a java program to create 2 person objects.Take input or hardcode  for all two person from console.
		  Person class is as follows
         Person(int id, String name, Vehicle v)
         Vehicle(int vid, String vname)*/

		internal class person
		{
			public int id { get; set; }
			public string name { get; set; }
			public string Vehicle { get; set; }
		
		}
		class Vehicle : person
		{
			public int vid { get; set; }
			public string vname { get; set; }
		}
		class Test2
		{ 
			static void Main(string[] args)
			{
				Vehicle v = new Vehicle();
				v.vid = 101;
				v.vname = "scooty";
				
				v.id = 101;
				v.name = "priya";
			    v.Vehicle = "TwoWheeler";
				Console.WriteLine(v.id);
				Console.WriteLine(v.name);
				Console.WriteLine(v.Vehicle);
				
				Console.WriteLine(v.vid);
				Console.WriteLine(v.vname);
				
			}
		}

		/*4.	Create interface Cake with a method declared as bake.Create 2 classes
		Strawberry, BlackForest both implementing Cake interface.
		*/

		internal class Class4
		{

		}
		/*5.	 Create interface IceCream with method eat and Juice with method drink,
		Create class Mastani which implements both interfaces.
		*/

		internal class Class5
		{

		}
		/*6.	Design a class to overload a function volume() as follows:  [2M]
			(i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
		v = 4 / 3 × 22 / 7 × r3
		(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the volume of a cylinder using the formula:
		v = 22 / 7 × r2 × h
		(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
		v = l × b × h*/
/*
		public class sphere
		{
			public static double volume(double r)
            {
				return 4 / 3 * 22 / 7 * r * r * r;
            }

			public static double volume(double h, double r)
			{
				return 22 / 7 * r * r * h;
			}

			public static double volume(double l, double b, double h)
			{
				return l * b * h;
			}

            static void Main(string[] args)
            {
				Console.WriteLine(sphere.volume(13));
				Console.WriteLine(sphere.volume(13,14));
				Console.WriteLine(sphere.volume(13,14,15));

			}

		}*/

		/*7.	Design class Order (int ordered, String Orderdate, Customer cust, Item item)
		Customer(int custid, String custname, Address address)
		Address(String addr1, city, int pincode)
		Item(int itemid, String itemname, int price)
		Write constructors, properties  in respective classes.*/

		internal class Class7
		{

		}

		/*8.	Create a class Account with member Variable: 
		long account No, String customer Name ,balance
		Make them public.
		Create default constructor assign new value to all variables and print I am in default constructor.
		Create constructor which takes all arguments and assigns those values to the member variables and print
		I am in parameterized constructor.
		Create properties

		Methods –

		void deposit amount
		withdraw () to withdraw amount
		 check_balance() to check balance*/

		internal class Class8
		{

		}

		/*9.	WAP to find Area of Square, Rectangle, and Circle using Method Overloading*/

	/*	internal class Class9
		{
			public static double Area(double s)
            {
				return s * s;
            }
			public static double Area(double w,double l)
			{
				return w * l;
			}
			public static double Area(double r)
			{
				return 22 / 7 * r * r;
			}

		}*/
		/*10.	What is Exception Handling in C#?
		 Exception is an abnormal termination which is occured at run time.Exception handling is to handle exception by using
		try,catch,finally,throw block.

		11.	What is the difference between System exceptions and Application exceptions?
		12.	What is the main use of a finally block in exception handling?*/

		/*13.	 WAP which throws IndexOutOfRangeException.In the console, observe the stack trace and the line number from 
				where the Exception is thrown*/

		internal class Class13
		{

		}

		/*14.	WAP to use catch / handle the IndexOutOfRangeException exception*/

		internal class Class14
		{

		}
		/*15.	WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
		and DivideByZeroException.*/

		internal class Class15
		{

		}
		/*16.	WAP to show checked exception and use multiple catch block with universal Exception handler.*/

		internal class Class16
		{

		}
		/*17.	WAP to check Exception handling with method overriding. Means, If super class method don’t
		declare exception then subclass overridden method can declare exception or not.*/

		internal class Class17
		{

		}
		/*18.	WAP to create custom Exception and show use of throw keyword*/

		internal class Class18
		{

		}
		/*19.	WAP to create user defined Exception raise and catch the exception.*/

		internal class Class19
		{

		}

	}


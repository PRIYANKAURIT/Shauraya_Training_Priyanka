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

	public abstract class Teacher
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

		public Hourlybased(int tid, string nm, long mb, int rate_per_hr, int hrs) : base(tid, nm, mb)
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

		public SalaryBased(int tid, string nm, long mb, int sal) : base(tid, nm, mb)
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
			Hourlybased myhourlybased = new Hourlybased(1, "Priyanka", 98247343435, 4, 1);
			SalaryBased mysalaryBased = new SalaryBased(1, "priyanka", 9851684121, 4500);
			myhourlybased.salary();
			mysalaryBased.salary();
		}
	}

	/*2.	A Pen contains variables Refill r, int capLength and String brand.
		Refill has variables inkColor, length and Nib(tip).
	 Nib has variables materialType and width.
	Create a Java class structure for above.
Write a main method which sets values in all the variables
using setter methods and prints all the variables using getter methods.
*/

	public class pen
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



		/*3.	Write a java program to create 2 person objects.Take input or hardcode  for all two person from console.
		  Person class is as follows
         Person(int id, String name, Vehicle v)
         Vehicle(int vid, String vname)*/

		public class person
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

		public interface cake
		{
			public void bake();
		}
		class Strawberry : cake
		{
			public void bake()
			{
				Console.WriteLine("strawberry flavour");
			}
		}
		class BlackForest : cake
		{
			public void bake()
			{
				Console.WriteLine("BlackForest flavour");
			}
		}
		static void Main(string[] args)
		{
			Strawberry s = new Strawberry();
			s.bake();
			BlackForest b = new BlackForest();
			b.bake();
		}
		/*5.	 Create interface IceCream with method eat and Juice with method drink,
		Create class Mastani which implements both interfaces.
		*/

		public interface Icecream
		{
			public void eat();
		}
		public interface Juice
		{
			public void drink();
		}
		public class Mastani : Icecream, Juice
		{
			public void eat()
			{
				Console.WriteLine(eat);
			}
			public void drink()
			{
				Console.WriteLine(drink);
			}
		}
		class cold
		{
			static void Main(string[] args)
			{
				Mastani m = new Mastani();
				m.eat();
				m.drink();
			}
		}


		/*6.	Design a class to overload a function volume() as follows:  [2M]
			(i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
		v = 4 / 3 × 22 / 7 × r3
		(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the volume of a cylinder using the formula:
		v = 22 / 7 × r2 × h
		(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
		v = l × b × h*/

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
				Console.WriteLine(sphere.volume(13, 14));
				Console.WriteLine(sphere.volume(13, 14, 15));

			}

		}

		/*7.	Design class Order (int ordered, String Orderdate, Customer cust, Item item)
		Customer(int custid, String custname, Address address)
		Address(String addr1, city, int pincode)
		Item(int itemid, String itemname, int price)
		Write constructors, properties  in respective classes.*/

		public class order
		{
			int ordered;
			string orderdate;

			public order(int ordered, string orderdate)
			{
				this.Ordered = ordered;
				this.Orderdate = orderdate;
			}

			public int Ordered { get => ordered; set => ordered = value; }
			public string Orderdate { get => orderdate; set => orderdate = value; }

			public void cutomer()
			{

			}
			public void Item()
			{

			}

		}
		public class Customer
		{
			int custid;
			String custname;

			public Customer(int custid, string custname)
			{
				this.Custid = custid;
				this.Custname = custname;
			}

			public int Custid { get => custid; set => custid = value; }
			public string Custname { get => custname; set => custname = value; }

			public void Address()
			{

			}


		}
		public class Address
		{
			String addr1;
			string city;
			int pincode;

			public Address(string addr1, string city, int pincode)
			{
				this.Addr1 = addr1;
				this.City = city;
				this.Pincode = pincode;
			}

			public string Addr1 { get => addr1; set => addr1 = value; }
			public string City { get => city; set => city = value; }
			public int Pincode { get => pincode; set => pincode = value; }
		}
		public class Item
		{
			int itemid;
			String itemname;
			int price;

			public Item(int itemid, string itemname, int price)
			{
				this.Itemid = itemid;
				this.Itemname = itemname;
				this.Price = price;
			}

			public int Itemid { get => itemid; set => itemid = value; }
			public string Itemname { get => itemname; set => itemname = value; }
			public int Price { get => price; set => price = value; }
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

		public class Class9
		{
			public static float Area(float s)
			{
				return s * s;
			}
			public static double Area(double w, double l)
			{
				return w * l;
			}
			public static double Area(double r)
			{
				return 22 / 7 * r * r;
			}

		}
	}
}


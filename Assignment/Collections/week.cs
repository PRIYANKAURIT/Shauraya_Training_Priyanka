using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Assignment.Collections
{
   /* 1.	Assume you have Arraylist  al = new ArrayList();
    al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
         Write a code to remove duplicate elements from above list.
         Final Arraylist should contain (Sun, Mon, Sat); */

    class week
    {
        private static void Main(string[] args)
       
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            for(int i=0;i < al.Count; i++)
            {
                
                for(int j=0;j<al.Count;j++)
                {
                    if (al[i] == al[j])
                    {
                        al.RemoveAt(j);
                        
                    }
                }
                Console.WriteLine(al[i]);
            }
            
        }
    }

/*2.	Sort Arraylist of String in reverse order of its natural sorting.*/

    class Reverse
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Anu");
            al.Add("Seema");
            al.Add("Priya");
            al.Add("Maya");
            al.Add("Pihu");

            al.Sort();
            al.Reverse();
            foreach(string e in al)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
        
    }

/*3.	 The encryption of alphabets are to be done as follows:	[2]

A=1, B= 2, C= 3, Z= 26

The potential of a word is found by adding the encrypted value of the alphabets.

Example: KITE

Potential = 11 + 9 + 20 + 5 = 45

Accept a sentence Decode the words according to their potential and arrange them in ascending order.

Output the result in format given below:
 Input:THE SKY IS THE LIMIT.
 POTENTIAL:THE= 33, SKY= 55, IS= 28, THE= 33, LIMIT= 63
Output :IS THE THE SKY LIMIT*/

    class Encryption
    {
        static int potential(string ss)
        {
            int sum = 0, a;
            for(int j=0;j<ss.Length;j++)
            {
                if (ss[j]>='A' && ss[j]<='Z')
                {
                    a = ss[j] - 64;
                    sum=sum+a;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            ss = ss.ToUpper();

            string[] arr = ss.Split();
            for(int i=0;i<arr.Length;i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (potential(arr[j]) > potential(arr[j-1]))
                    {
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            foreach(string word in arr)
                Console.WriteLine(word+" ");
            Console.ReadLine();
        }
    }

    /*4.	Create ArrayList of T20 Players.

    Create a class Player (playerid, Name, Country, team)
    e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)
    Then find out which team has maximum Australian players.*/

    class Player
    {
        int playerid;
        string name;
        String country;
        String team;

        public Player(int playerid, string name, string country, string team)
        {
            this.playerid = playerid;
            this.name = name;
            this.country = country;
            this.team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        

    }
    class IPL
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(new Player(1, "MS Dhoni", "India", "CSK"));
            a1.Add(new Player(2, "Mathew Hayden", "Australia", "csk"));
            a1.Add(new Player(3, "Mike Hussey", "Australia", "csk"));
            a1.Add(new Player(4, "Joginder", "India", "CSK"));
            a1.Add(new Player(5, "Jacob", "New Zealand", "CSK"));
            a1.Add(new Player(6, "Adam", "Australia", "DC"));
            a1.Add(new Player(7, "Andrew", "Australia", "DC"));
            a1.Add(new Player(8, "Rushabh Pant", "India", "DC"));
            a1.Add(new Player(9, "Ravi Teja", "India", "DC"));
            a1.Add(new Player(10, "V.S.Laxman", "India", "DC"));
            a1.Add(new Player(11, "Brett", "Australia", "DD"));
            a1.Add(new Player(12, "Glenn", "Australia", "MI"));
            a1.Add(new Player(13, "James", "Australia", "DC"));
            a1.Add(new Player(14, "Jadhav", "India", "MI"));
            a1.Add(new Player(10, "Yogesh", "India", "DD"));

            string max_teamname = "";
            int maxcount = 0;
            foreach (Player p in a1)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player ppp in a1)
                {
                    if (ppp.Team == t && ppp.Country == "Australian")
                    {
                        c++;
                    }
                }
                if (maxcount < c)
                {
                    max_teamname = p.Team;
                    maxcount = c;
                }
            }
            Console.WriteLine($"Maximum Australian player in {max_teamname}={maxcount} ");
        }
    }
    /*5.	Write a program to get the value of a specified key in a HashTable
     and also update the value for given key.*/

    class update
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");

            object key = Console.ReadLine();
            object val = Console.ReadLine();
            ht[key]=val;

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+"  "+d.Value);
            }
            Console.ReadLine();
        }
    }


     /*6.	Write a program to get a set of keys contained in HashTable and print whole HashTable
       using for each loop.*/

    class Htable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");

            
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "  " + d.Value);
            }
            Console.ReadLine();
        }
    }


    /*7.	Create a HashTable where key is integers 1 to 10 and string is number in Words.Remove 
     entry for which number is divisible by 3.*/

    class Htremove
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");
            ht.Add(10, "Ten");

            ArrayList arr = new ArrayList();

            foreach (var item in ht.Keys)
            {
                int n = Convert.ToInt32(item);
                if (n % 3 == 0)
                {
                    arr.Add(item);
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                ht.Remove(arr[i]);
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "  " + d.Value);
            }
        }
    }

            /*8.	ArrayList Contains
                al.Add("pune");
                al.Add("Mumbai");
                al.Add("pune");
                al.Add("Mumbai");
                al.Add("Nasik");
                al.Add("pune");
            Create a HashTable which contain String as key and Integer as value key is name of city and value is frequency of that city.
            ("pune",3);
                ("Mumbai",2);
            Print hashtable using Foreach loop.*/

    class frequency
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable ht = new Hashtable();

            foreach (dynamic str in al)
            {
                if (ht.ContainsKey(str))
                {
                    int oldvalue = ht[str];
                    ht[str] = oldvalue + 1;
                }
                else
                    ht.Add(str, 1);
            }
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key + "  " + e.Value);
            }
            Console.ReadLine();
        }
    }
        }

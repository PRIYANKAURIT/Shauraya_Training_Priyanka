using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Assignment.oops.Test.collection
{
    internal class studd
    {
        int sid;
        string name;
        int percent;

        
        public studd(int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }

        public override string ToString()
        {
            return $" Sid:{sid} Name:{name} Percent:{percent}";
        }

        public override bool Equals(object obj)
        {
            return obj is studd Studd &&
                sid == Studd.sid &&
                name == Studd.name &&
                percent == Studd.percent;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sid, name, percent);
        }
        public int Sid { get => sid; set => sid = value; }  
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }

    }
    class Demolist
    {
        static void Main(string[] args)
        {
            List<studd> lst = new List<studd>();
            lst.Add(new studd(101, "arti", 98));
            lst.Add(new studd(101, "aru", 65));
            lst.Add(new studd(101, "bharti", 88));
            lst.Add(new studd(101, "priya", 68));
            lst.Add(new studd(101, "nita", 98));

            foreach(studd ob in lst)
            {
                if(ob.Percent > 80)
                    Console.WriteLine(ob);
            }
        }
    }

    class DemoDict
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "kavita");
            d1.Add(101, "kavita");
            d1.Add(101, "om");
            Console.WriteLine(d1[101]);

            d1[103] = "Ajinkya";

            d1.Remove(102);

            foreach(KeyValuePair<int, string> kvp in d1)
            {
                Console.WriteLine(kvp.Key+"=>"+kvp.Value);
            }
            
        }
    }

    class mydict
    {
        static void Main(string[] args)
        {
            Dictionary<studd, string> d1 = new Dictionary<studd, string>();
            d1.Add(new studd(1, "amol", 90),"shaurya");
            d1.Add(new studd(1, "amol", 90), "shaurya");
            foreach(KeyValuePair<studd,string> kvp in d1)
                Console.WriteLine(kvp.Key+" "+kvp.Value);
        }
    }
   
}

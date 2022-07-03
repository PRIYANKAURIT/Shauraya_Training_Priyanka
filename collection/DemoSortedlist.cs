using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.collection
{
    class student1 : IComparable<student1>
    {
        int id;
        string name;

        public student1(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int CompareTo(student1 o)
        {
            return (this.name.CompareTo(o.name));
        }
        public override string ToString()
        {
            return $"id={id} name={name}";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    class DemoSortedlist
    {
        static void Main(string[] args)
        {
            SortedList<student1, string> st = new SortedList<student1, string>();
            st.Add(new student1(1, "suraj"), "pune");
            st.Add(new student1(2, "amit"), "pune");
            st.Add(new student1(3, "gargi"), "pune");
            st.Add(new student1(4, "priya"), "pune");

            foreach (KeyValuePair<student1, string> kv in st)
            {
                Console.WriteLine(kv.Key + " =" + kv.Value);
            }
        }
    }
    class mysorted:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1, StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }

    class DemoSortedlist1
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder,int> ss = new SortedList<StringBuilder,int>(new mysorted { });
            ss.Add(new StringBuilder("Siya"), 90);
            ss.Add(new StringBuilder("Riya"), 90);

            foreach (KeyValuePair<StringBuilder, int> kv in ss)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
        }
    }
}

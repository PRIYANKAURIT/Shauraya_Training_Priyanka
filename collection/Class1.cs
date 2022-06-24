using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.Assignment.oops.Test.collection
{
    //collection
    //Array        both are containers in which store data.
    //collectin only store object..not store value at is.value get conveted in objejt using autoboxing
    class emp
    {
        string name;
        int num;
        public emp(string name, int num)
        {
            this.name = name;
            this.num = num;
        }
        public override string ToString()
        {
            return name + " " + num;
        }
        static void Main(string[] args)
        {
            //autoboxing auto unboxing
            int a = 90;//valued type.
            Object ob = a;//refernce type. this is autoboxing.in this case var a is on heap and addres of that a is stored in ob .ob in stack
            int d = (int)ob;// out unboxing.

            ArrayList al = new ArrayList();//growable array.default size is 4.duplicate allowed here.its preseve insertion order.use array to store date in backgroung
            al.Add(90);//to add elements use Add method is here.
            al.Add(100);
            al.Add("priya");   //araylist allowed duplicate elements
            al.Add("priya");
            al.Add("priya");
            al.Add(new emp("om", 123));
            al[0] = 3250;    // to replce value
            al.Remove(al.Add("priya"));  //remove by data
            al.RemoveAt(0);              //remove by index
            al.Insert(3, "anu");         //insert data                       
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            /*foreach(var ob in al)
             {
               Console.WriteLine(ob);
             }
            */
        }
    }
}

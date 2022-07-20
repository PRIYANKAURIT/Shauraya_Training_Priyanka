using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.LINQ
{
    public class Cource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }



        static void Main(string[] args)
        {
            List<Cource> coures = new List<Cource>()       //collection
            {
                  new Cource{Id=101,Name="C#",Fees=2000 },
                  new Cource{Id=102,Name="MVC", Fees=4000 },
                  new Cource{Id=103,Name="SQL",Fees=6000 },
                  new Cource{Id=104,Name="Core Java",Fees=8000 },
                  new Cource{Id=105,Name="Ad Java",Fees=10000 },
            };

            //var result1=from c in coures
            //            select c;

            //LINQ query
            var result2 = from c in coures                // c is local variable we can use anything
                          where c.Fees < 8000             //condition
                          orderby c.Name descending        // orderby is used to sorting  //.Name = field name
                          select c;

            //using lambda expression 
            // arrow operator (=>) is also known as lambda expression 

            //to find multiple data using lambda expression
            // var = object_name.where(local_variable=>local_variable.condition).function(local_variable.condition).ToList();
            //when we want data in list or multiple data is occured in output then use ToList()
             var result22 =coures.Where(c => c.Fees<8000).OrderByDescending(c => c.Name).ToList();

            //to find single data using lambda expression 
            var result222 = coures.Where(x => x.Id == 101).FirstOrDefault();


            foreach (Cource c in result2)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }

            Console.WriteLine("   ");

            var result3 = from c in coures
                          where c.Name.StartsWith('C')       //startwith is a function to find name from starting 1st letter or word
                          select c;
            foreach (Cource c in result3)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }

            Console.WriteLine("   ");

            var result4 = from c in coures
                          where c.Name.EndsWith('C')       //endswith is a function to find name from ending last letter or word
                          select c;

            foreach (Cource c in result4)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }

            Console.WriteLine("   ");

            var result5 = from c in coures
                          where c.Name.Contains("C")       //cotains is a function is used to check that letter or word is present or not
                          select c;
            foreach (Cource c in result5)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }
        }

    }
}
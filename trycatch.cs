using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training
{
    internal class trycatch
    {
        public void table()
        {
            try //put that code in try where chance to come error.
            {
                Console.WriteLine("enter the number");
                int s = int.Parse(Console.ReadLine());
            }
            catch (SystemException se) // in systemexception conatin all type of exception i.e nullreference,formatexception,argumentexception.
            {
                Console.WriteLine(se.Message);
            }
            //catch(NullReferenceException ne) for one try you can write mutiple catches

            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            trycatch e = new trycatch();
            e.table();
        }
    }
    
}


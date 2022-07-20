using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.xobin
{
    class duplicate
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            
           
            for (int i= 0; i < arr.Length; i++)
            {
                int c = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        c++;
                        
                    }
                }
                if (c > 1)
                    Console.WriteLine(arr[i]);

            }
            
        }
    }

    
}

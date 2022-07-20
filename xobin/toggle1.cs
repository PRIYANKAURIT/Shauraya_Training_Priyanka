using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training.xobin
{
    class toggle1
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string Output = " ";
            for(int i=0; i< Input.Length; i++)
            {
                char ch =Input[i];
                if(ch>='A' && ch <='Z')
                {
                    ch = (char)(ch + 32);      //ASCII VALUE A to Z ==65 to 90  a to z =97 to 122
                }
                else
                {
                    ch = (char)(ch - 32);
                }
                Output = Output + ch;
            }
            Console.WriteLine(Output);
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaurya_training
{
     class InvalidPassword : Exception
{
    public InvalidPassword(string msg) : base(msg)
    {

    }
    public InvalidPassword()
    {

    }
    public void ano()
    {
        Console.WriteLine("enter password");
        string pass = Console.ReadLine();
        try
        {
            if (pass.Length < 5)
            {
                throw new InvalidPassword("length of password less");
            }
        }
        catch (InvalidPassword ip)
        {
            Console.WriteLine("hi");
            Console.WriteLine(ip.Message);
        }
    }

    static void Main(string[] args)
    {
        InvalidPassword i = new InvalidPassword();
        i.ano();
    }

}
}

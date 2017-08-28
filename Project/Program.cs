using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard("user");
            card.WriteName();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}

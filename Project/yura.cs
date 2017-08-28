using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CreditCard
    {
       public CreditCard(string n)
        {
            Name = n;
        }
        public string Name { get; set; }
        public void WriteName()
        {
            if (Name != null)
                Console.WriteLine(Name);
        }
    }
}

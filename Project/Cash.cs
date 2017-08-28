using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Cash
    {
        private string Name { get; set; }
        public Cash() {
            Name = "Vova";
            Console.WriteLine(Name + " has too much money");
        }
    }
}

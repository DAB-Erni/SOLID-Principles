using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Employee : IEmployee
    {
        //implement interface
        public void Timein()
        {
            Console.WriteLine("Employee Time In");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}

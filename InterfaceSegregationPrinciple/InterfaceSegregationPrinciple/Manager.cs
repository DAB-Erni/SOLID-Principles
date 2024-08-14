using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Manager : IEmployee, IManage
    {
        //implement interface
        public void Timein()
        {
            Console.WriteLine("Manager Time In");
        }

        public void Manage()
        {
            Console.WriteLine("Manage Work");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Employee : User
    {
        public Employee(string name) : base(name)
        {
        }

        public override void Access()
        {
            Console.WriteLine("Employee Accessed");
        }
    }

}

using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Admin : IEmployee, IAdminTask
    {
        //implement interface
        public void Timein()
        {
            Console.WriteLine("Admin Time In");
        }

        public void DeleteUser()
        {
            Console.WriteLine("Delete User");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Admin : User
    {
        public Admin(string name) : base(name)
        {
        }

        public override void Access()
        {
            Console.WriteLine("Admin Accessed");
        }

    }
}

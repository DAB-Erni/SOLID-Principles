using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class User
    {
        private static string _name = "";
        public User(string name)
        {
            _name = name;
        }
        public void LogIn()
        {
            Console.WriteLine("Logged In");
        }
        public virtual void Access()
        {
            Console.WriteLine("User Accessed");
        }

        public void LogOut()
        {
            Console.WriteLine("Logged Out");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    //Abstraction in a low-level module
    public class EmailService : ISendEmail
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("New Email Received: " + email);
        }
    }
}

using System;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Timein();
            manager.Manage();
            manager.Work();

            Employee employee = new Employee();
            employee.Timein();
            employee.Work();

            Admin admin = new Admin();
            admin.Timein();
            admin.Work();
            admin.DeleteUser();
        }
    }

}

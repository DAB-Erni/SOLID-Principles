using System;
using LiskovSubstitutionPrinciple;
class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin("admin");
        Employee Employee = new Employee("member");
        DoSomething(admin);
        DoSomething(Employee);
    }

    public static void DoSomething(User user)
    {
        user.LogIn();
        user.Access();
        user.LogOut();
    }
}
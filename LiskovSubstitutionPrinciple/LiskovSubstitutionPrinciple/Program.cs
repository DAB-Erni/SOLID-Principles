using System;

public  class User
{
    private static string _name = "";
    public User(string name)
    {
        _name = name;
    }
    public  void LogIn()
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
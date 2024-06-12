using System;
using System.Collections.Generic;

// Component
abstract class Employee
{
    protected string name;
    protected string position;

    public Employee(string name, string position)
    {
        this.name = name;
        this.position = position;
    }

    public abstract void Display(int depth);
}

// Leaf
class IndividualEmployee : Employee
{
    public IndividualEmployee(string name, string position) : base(name, position)
    {
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name + " (" + position + ")");
    }
}

// Composite
class Manager : Employee
{
    private List<Employee> subordinates = new List<Employee>();

    public Manager(string name, string position) : base(name, position)
    {
    }

    public void Add(Employee employee)
    {
        subordinates.Add(employee);
    }

    public void Remove(Employee employee)
    {
        subordinates.Remove(employee);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name + " (" + position + ")");
        foreach (Employee employee in subordinates)
        {
            employee.Display(depth + 2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a tree structure
        Manager CEO = new Manager("John", "CEO");

        Manager headSales = new Manager("Robert", "Head Sales");
        Manager headMarketing = new Manager("Michel", "Head Marketing");

        IndividualEmployee clerk1 = new IndividualEmployee("Laura", "Marketing");
        IndividualEmployee clerk2 = new IndividualEmployee("Bob", "Marketing");

        IndividualEmployee salesExecutive1 = new IndividualEmployee("Richard", "Sales");
        IndividualEmployee salesExecutive2 = new IndividualEmployee("Rob", "Sales");

        CEO.Add(headSales);
        CEO.Add(headMarketing);

        headSales.Add(salesExecutive1);
        headSales.Add(salesExecutive2);

        headMarketing.Add(clerk1);
        headMarketing.Add(clerk2);

        // Print the tree structure
        CEO.Display(1);

        Console.ReadLine();
    }
}
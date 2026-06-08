using System;

// Interface that defines a Quit method
interface IQuittable
{
    void Quit();
}

// Employee class implements the IQuittable interface
class Employee : IQuittable
{
    // Employee properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementation of the Quit method
    public void Quit()
    {
        Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee();
        employee.FirstName = "John";
        employee.LastName = "Smith";

        // Use polymorphism:
        // Create an object of interface type IQuittable
        IQuittable quittable = employee;

        // Call the Quit method through the interface
        quittable.Quit();

        // Keep console window open
        Console.ReadLine();
    }
}
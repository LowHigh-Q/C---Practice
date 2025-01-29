using System;
using System.Data;

public abstract class Animal
{
    public string Name {  get; set; }
    public void SetName(string name)
    {
        this.Name = name;
    }
    public string getName()
    {
        return this.Name;
    }
    public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Dog dogobj = new Dog();
        Console.WriteLine("Enter the dog name: ");
        string? dname = Console.ReadLine();
        dogobj.SetName(dname);
        Console.WriteLine($"Dog name is {dogobj.getName()}");
        dogobj.Eat();



    }
}
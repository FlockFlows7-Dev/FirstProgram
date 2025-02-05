using System;

class Program
{
    public static void Main(string[] args)
    {
        string name = "";
        String favorite = "";
        int age = 0;

        Console.Write("whats your name: ");
        name = (Console.ReadLine());
        Console.Clear();

        Console.WriteLine("whats your age: ");
        age = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("whats your favorite thing: ");
        favorite = (Console.ReadLine());
        Console.Clear();

        Console.WriteLine("your name is " + name + " your age is " + age + "\n" + "and your favorite thing is " + favorite + "...");
    }
}
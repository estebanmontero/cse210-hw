using System;

class Program
{
    static void Main(string[] args)

    {
        //Question student's name store in a variable call firstName
        Console.Write("What is your first name?:  ");
        string firstName = Console.ReadLine();


        //Question student's last name in a variable call lastName
        Console.Write("What is your last name?:  ");
        string lastName = Console.ReadLine();

        //add a space
        Console.WriteLine("");


        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}
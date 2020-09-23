using System;
namespace HelloWorld
{
    public class Hello
    {
        static void Main(string[] args)
        {
            var p = new Person();

            Console.WriteLine("Hello Welcome!");

            Console.WriteLine("What is your name");
            p.Name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            p.Age = Convert.ToInt32(Console.ReadLine());
            // Converts the string into an int

            Console.WriteLine("What is your email?");
            p.Email = Console.ReadLine();

            Console.WriteLine("What is the first line of your address?");
            p.AddressLineOne = Console.ReadLine();

            Console.WriteLine("What is the second line of your address?");
            p.AddressLineTwo = Console.ReadLine();

            Console.WriteLine("What is your postcode?");
            p.Postcode = Console.ReadLine();

            Console.Write(p.printDetails());
        }
    }
}

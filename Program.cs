// Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.

namespace Assignment_1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Billy Windows";
            uint age = 70;
            string address = "1 Microsoft Way, Redmond, WA 98052";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }
}
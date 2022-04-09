using SEDC.OOP.Class3.App.Enteties;
using SEDC.OOP.Class3.App.Utils;
using System;
namespace SEDC.OOP.Class3.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Class1.Counter);
            Class1.Counter++;
            Console.WriteLine(Class1.Counter);
            Console.WriteLine(Class1.AddTwoNumbers(2, 3));

            Console.WriteLine($"Number of crated users: {User.UserCount}");
            User user1 = new User(1, "Timotej", "Bojarovski");
            user1.PrintInfo();
            User.PrintUserCount();
            User user2 = new User(1, "Ivan", "Djikovski");
            Console.WriteLine($"Number of crated users: {User.UserCount}");
            User user3 = new User(1, "Kaja", "Milcin");
            Console.WriteLine($"Number of crated users: {User.UserCount}");
            
            Console.WriteLine(StringUtils.CapitaliseFirstLetter("the sun is shining"));
            Console.WriteLine(StringUtils.CapitaliseFirstLetter("The sun is shining"));
            Console.WriteLine(StringUtils.CapitaliseFirstLetter("078506963"));

        }
    }
}

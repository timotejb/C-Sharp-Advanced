using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.App.Enteties
{
    public class User
    {
        public static int UserCount { get; set; } = 0;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserCount++;
        }
        public void PrintInfo()
        {
            Console.WriteLine( $"{FirstName}, {LastName}");
        }
        public static void PrintUserCount()
        {
            Console.WriteLine($"Number of users created is: {UserCount}");
        }
    }
}

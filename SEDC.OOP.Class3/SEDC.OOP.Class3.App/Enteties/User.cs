using System;
using System.Collections.Generic;

namespace SEDC.OOP.Class3.App.Enteties
{
    public class User
    {
        public static int UserCount { get; set; } = 0;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }
        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserCount++;
            Orders = new List<Order>();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}");
        }
        public static void PrintUserCount()
        {
            Console.WriteLine($"Number of users created is: {UserCount}");
        }
        public void PrintOrders()
        {
            foreach(Order order in Orders)
            {
                order.Print();
            }
        }
    }
}

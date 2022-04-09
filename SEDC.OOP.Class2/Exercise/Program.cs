using System;
using Exercise.Interfaces;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User teacher1 = new Teacher(1, "Timotej", "tT", "tt" , "mkd");

            User teacher2 = new Teacher(2, "Jetomit", "tT", "tt", "MTM");

            User student1 = new Student(2, "timotej", "password", "timotej", new List<int>(1, 2, 3));
        }
    }
}

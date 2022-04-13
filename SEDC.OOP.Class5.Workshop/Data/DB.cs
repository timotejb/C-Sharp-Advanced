using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DB
    {
        public List<User> Users = new List<User>();
        public List<Car> Cars = new List<Car>();
        public List<Driver> Drivers = new List<Driver>();
        public DB()
        {
            Drivers.Add(new Driver() {
                Id = 1,
                FirstName = "Timotej",
                LastName = "Bojarovski",
                License = "321AAA",
                Shift = Shift.Afternoon,
                LicenseExpiryDate = new DateTime(23 - 06 - 2030),
                Car = null });
            Drivers.Add(new Driver() { 
                Id = 2, 
                FirstName = "Bob", 
                LastName = "Bobsky", 
                License = "123AAA", 
                Shift = Shift.Morning, 
                LicenseExpiryDate = new DateTime(22-09-2032),
                Car = null});                
            Cars.Add(new Car() { 
                Id = 1, 
                Model = "Audi-A4", 
                AssignedDrivers = new List<Driver>(), 
                LiscenceExpieryDate = new DateTime(23-02-2033),
                LiscencePlate = "sk-135-ig" });
            Cars.Add(new Car()
            {
                Id = 2,
                Model = "Peugeot-307",
                AssignedDrivers = new List<Driver>(),
                LiscenceExpieryDate = new DateTime(23-06-2033),
                LiscencePlate = "sk-136-ig"
            });
        }
    }
}
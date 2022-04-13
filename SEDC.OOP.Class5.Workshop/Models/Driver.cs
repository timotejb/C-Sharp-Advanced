using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public Car? Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpiryDate { get; set; }

    }
    public enum Shift
    {
        Morning,
        Afternoon,
        Evening
    }
}

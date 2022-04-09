using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        
    }
}

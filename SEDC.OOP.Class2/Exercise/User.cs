using System;
using System.Collections.Generic;
using System.Text;
using Exercise.Interfaces;
namespace Exercise
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }    
        public string Password { get; set; }
        public abstract void PrintUser();
        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }
    }
}

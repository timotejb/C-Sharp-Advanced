using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties.Interfaces;

namespace Enteties
{
    public class User : IUser
    {
        public User(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        
        public string getID()
        {
            return Id.ToString();
        }

        public string GetID()
        {
            throw new NotImplementedException();
        }
    }
}

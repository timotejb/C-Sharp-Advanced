using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Interfaces
{
    public interface IStudent: IUser
    {
        List<int> Grades { get; set; }
    }
}

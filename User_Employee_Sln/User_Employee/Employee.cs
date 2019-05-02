using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Employee
{
    class Employee: User
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public int CountId()
        {
            Id++;
            return Id;
        }
    }
}

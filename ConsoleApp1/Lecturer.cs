using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lecturer : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string UniversityName { get; set; }

        public Lecturer(string lastName, string firstName, DateTime dateOfBirth, string position, string department, string universityName) : base(lastName, firstName, dateOfBirth)
        {
            Position = position;
            Department = department;
            UniversityName = universityName;
        }
    }
}

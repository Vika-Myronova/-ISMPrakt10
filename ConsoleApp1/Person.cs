using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string lastName, string firstName, DateTime dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
        }
        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            return (int)age.TotalDays / 365;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        public string CourseOfStudy { get; set; }
        public string GroupName { get; set; }
        public string Faculty { get; set; }
        public string UniversityName { get; set; }
        public Student(string lastName, string firstName, DateTime dateOfBirth, string courseOfStudy, string groupName, string faculty, string universityName) : base(lastName, firstName, dateOfBirth)
        {
            CourseOfStudy = courseOfStudy;
            GroupName = groupName;
            Faculty = faculty;
            UniversityName = universityName;
        }
        public string GetStudentsGroupNameAndCourse()
        {
            string groupAndCourse = "Група " + GroupName + " " + CourseOfStudy;
            return groupAndCourse;
        }
    }
}

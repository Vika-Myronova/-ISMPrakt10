using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Applicant applicants = new Applicant("Сергій", "Миколенко", new DateTime(2004, 05, 14), 177.33, 10.8, "Житомирська гуманітарна гімназія №23");
            double[] array = new double[] { 167, 190, 175 };
            double point = applicants.AverageOfPointsOfEEP(array);
            int applicantAge = applicants.GetAge();
            Console.WriteLine($"Абітурієнт: {applicants.LastName} {applicants.FirstName}");
            Console.WriteLine($"Вік: {applicantAge}");
            Console.WriteLine($"Середній бал за ЗНО: {point:F2}");
            Console.WriteLine();

            Student students = new Student("Олександр", "Желізко", new DateTime(2003, 06, 27), "1-й курс", "ІПЗ-20-1", "Факультет Інформаційно-компютерних Технологій", "");
            string groupNameAndCourse = students.GetStudentsGroupNameAndCourse();
            int studentAge = students.GetAge();
            Console.WriteLine($"Студент: {students.LastName} {students.FirstName}");
            Console.WriteLine($"Вік: {studentAge}");
            Console.WriteLine(groupNameAndCourse);
            Console.WriteLine();

            Lecturer lecturer = new Lecturer("Іван", "Іванов", new DateTime(1974, 02, 11), "Доцент", "Кафедра механічної інженерії", "Житомирська політехніка");
            string str = lecturer.GetPositionAndUniversityName(lecturer.Position, lecturer.UniversityName);
            int lecturerAge =  lecturer.GetAge();
            Console.WriteLine($"Викладач: {lecturer.LastName} {lecturer.FirstName}");
            Console.WriteLine($"Вік: {lecturerAge}");
            Console.WriteLine(str);
            Console.WriteLine();

            LibraryUser libraryUser = new LibraryUser("Іван", "Харченко", new DateTime(1980, 02, 15), 120604457, new DateTime(1990, 05, 04), 70);
            int years = libraryUser.GetNumberOfDaysAfterIssue();
            int libraryUserAge =  libraryUser.GetAge();
            Console.WriteLine($"Коритувач бібліотеки: {libraryUser.LastName} {libraryUser.FirstName}");
            Console.WriteLine($"Вік: {libraryUserAge}");
            Console.WriteLine($"Скільки років зареєстрований у бібліотеці: {years} р.");
        }
    }
}

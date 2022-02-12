using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LibraryUser : Person
    {
        public long ReadersTicketNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthlyReaderShipFee { get; set; }
        public LibraryUser(string lastName, string firstName, DateTime dateOfBirth, long readersTicketNumber, DateTime dateOfIssue, double monthlyReaderShipFee) : base(lastName, firstName, dateOfBirth)
        {
            ReadersTicketNumber = readersTicketNumber;
            DateOfIssue = dateOfIssue;
            MonthlyReaderShipFee = monthlyReaderShipFee;
        }
        public int GetNumberOfDaysAfterIssue()
        {
            TimeSpan days = DateTime.Now - DateOfIssue;
            return (int)days.TotalDays / 365;
        }
    }
}

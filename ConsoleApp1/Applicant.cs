using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Applicant : Person
    {
        public double NumberOfPointOfEEPCertificates { get; set; }
        public double NumberOfPointsForEducationDocument { get; set; }
        public string SecondarySchoolName { get; set; }

        public Applicant(string lastName, string firstName, DateTime dateOfBirth, double numberOfPointOfEEPCertificates, double numberOfPointsForDocumentOnEducation, string secondarySchoolName) : base(lastName, firstName, dateOfBirth)
        {
            NumberOfPointOfEEPCertificates = numberOfPointOfEEPCertificates;
            NumberOfPointsForEducationDocument = numberOfPointsForDocumentOnEducation;
            SecondarySchoolName = secondarySchoolName;
        }
        public double AverageOfPointsOfEEP(double[] numOfPoints)
        {
            double average = 0, sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += numOfPoints[i];
            }
            average = sum / 3;
            return average;
        }
    }
}

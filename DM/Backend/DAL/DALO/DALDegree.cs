using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    class DALDegree:DALObj
    {
        private string name;
        private int credit;
        private double average;
        private double expectedAverage;
        private double difference;
        private double donePrecent;
        private int totalCredit;
        private int studentId;
        internal DegreeDALController cont = new DegreeDALController();
        public const string DegreeNameColumn = "Number";
        public const string DegreeCreditColumn = "Credit";
        public const string DegreeAverageColumn = "Average";
        public const string DegreeStudentIdColumn = "Student";
        public const string DegreeExpectedAverageColumn = "ExpectedAverage";
        public const string DegreeDifferenceColumn = "Difference";
        public const string DegreeDonePrecentsColumn = "DonePrecent";
        public const string DegreeTotalCreditColumn = "TotalCredit";

        public DALDegree(string name) : base(new StudentDALController())
        {
            this.name = name;
        }
        public DALDegree(string name, int credit, double average, double expectedAverage,double donePrecent,int totalCredit,double difference, int studentId) : base(new StudentDALController())
        {

            this.name = name;
            this.credit = credit;
            this.average = average;
            this.expectedAverage = expectedAverage;
            this.difference = difference;
            this.donePrecent = donePrecent;
            this.totalCredit = totalCredit;
            this.studentId = studentId;

        }
        public string Name
        {
            get => name;
            set
            {
                cont.Update(studentId, number, degree, DegreeNameColumn, value.ToString());
                name = value;
            }
        }
        public int Credit
        {
            get => credit;
            set
            {
                cont.Update(studentId, number, degree, DegreeCreditColumn, value.ToString());
                credit = value;
            }
        }
        public double Average
        {
            get => this.average;
            set
            {
                cont.Update(studentId, number, degree, DegreeAverageColumn, value.ToString());
                average = value;
            }
        }
        public double ExpectedAverage
        {
            get => expectedAverage;
            set
            {
                cont.Update(studentId, number, degree, DegreeExpectedAverageColumn, value);
                expectedAverage = value;
            }
        }
        public double DonePrecent
        {
            get => donePrecent;
            set
            {
                cont.Update(studentId, number, degree, DegreeDonePrecentsColumn, value);
                donePrecent = value;
            }
        }
        public double Difference
        {
            get => difference;
            set
            {
                cont.Update(studentId, number, degree, DegreeDifferenceColumn, value);
                difference = value;
            }
        }
        public int StudentId
        {
            get => this.studentId;
            set
            {
                cont.Update(studentId, number, degree, DegreeStudentIdColumn, value.ToString());
                studentId = value;
            }
        }
    }
}

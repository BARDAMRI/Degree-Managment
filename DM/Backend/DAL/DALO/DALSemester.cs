using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    public class DALSemester:DALObj
    {
        private int number;
        private int credit;
        private double average;
        private int year;
        private string degree;
        private int studentId;
        internal SemesterDALController cont = new SemesterDALController();
        public const string SemesterNumberColumn = "Number";
        public const string SemesterCreditColumn = "Credit";
        public const string SemesterAverageColumn = "Average";
        public const string SemesterYearColumn = "Year";
        public const string SemesterDegreeColumn = "Degree";
        public const string SemesterStudentIdColumn = "Student";

        public DALSemester(int number) : base(new StudentDALController())
        {
            this.number = number;
        }
        public DALSemester(int number, int credit, double average, int year,string degree,int studentId) : base(new StudentDALController())
        {

            this.number = number;
            this.credit = credit;
            this.average = average;
            this.year = year;
            this.degree = degree;
            this.studentId = studentId;

        }
        public int Number
        {
            get => number;
            set
            {
                cont.Update(studentId, number, degree, SemesterNumberColumn, value.ToString());
                number = value;
            }
        }
        public int Credit
        {
            get => credit;
            set
            {
                cont.Update(studentId, number, degree, SemesterCreditColumn, value.ToString());
                credit = value;
            }
        }
        public double Average
        {
            get => this.average;
            set
            {
                cont.Update(studentId, number, degree, SemesterAverageColumn, value.ToString());
                average = value;
            }
        }
        public int Year
        {
            get => this.year;
            set
            {
                cont.Update(studentId, number, degree, SemesterYearColumn, value.ToString());
                year = value;
            }
        }
        public string Degree
        {
            get => degree;
            set
            {
                cont.Update(studentId, number, degree, SemesterDegreeColumn, value);
                degree = value;
            }
        }
        public int StudentId
        {
            get => this.studentId;
            set
            {
                cont.Update(studentId,number,degree, SemesterStudentIdColumn, value.ToString());
                studentId = value;
            }
        }
    }
}

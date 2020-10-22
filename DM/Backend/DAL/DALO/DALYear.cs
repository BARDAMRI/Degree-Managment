using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    class DALYear:DALObj
    {
        private int number;
        private int credit;
        private double average;
        private string degree;
        private int studentId;
        internal YearDALController cont = new YearDALController();
        public const string yearNumberColumn = "Number";
        public const string yearCreditColumn = "Credit";
        public const string yearAverageColumn = "Average";
        public const string yearDegreeColumn = "Degree";
        public const string yearStudentIdColumn = "Student";

        public DALYear(int number) : base(new StudentDALController())
        {
            this.number = number;
        }
        public DALYear(int number, int credit, double average, string degree, int studentId) : base(new StudentDALController())
        {

            this.number = number;
            this.credit = credit;
            this.average = average;
            this.degree = degree;
            this.studentId = studentId;

        }
        public int Number
        {
            get => number;
            set
            {
                cont.Update(studentId, number, degree, yearNumberColumn, value.ToString());
                number = value;
            }
        }
        public int Credit
        {
            get => credit;
            set
            {
                cont.Update(studentId, number, degree, yearCreditColumn, value.ToString());
                credit = value;
            }
        }
        public double Average
        {
            get => this.average;
            set
            {
                cont.Update(studentId, number, degree, yearAverageColumn, value.ToString());
                average = value;
            }
        }
        public string Degree
        {
            get => degree;
            set
            {
                cont.Update(studentId, number, degree, yearDegreeColumn, value);
                degree = value;
            }
        }
        public int StudentId
        {
            get => this.studentId;
            set
            {
                cont.Update(studentId, number, degree, yearStudentIdColumn, value.ToString());
                studentId = value;
            }
        }
    }
}

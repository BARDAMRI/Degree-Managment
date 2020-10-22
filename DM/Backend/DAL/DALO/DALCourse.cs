using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    class DALCourse:DALObj
    {

        private string name;
        private int credit;
        private int grade;
        private string degree;
        private int studentId;
        private int year;
        private int semester;
        internal CourseDALController cont = new CourseDALController();
        public const string CourseNameColumn = "Name";
        public const string CourseCreditColumn = "Credit";
        public const string CourseGradeColumn = "Grade";
        public const string CourseSemesterColumn = "Semester";
        public const string CourseYearColumn = "Year";
        public const string CourseDegreeColumn = "Degree";
        public const string CourseStudentIdColumn = "Student";

        public DALCourse(string name) : base(new StudentDALController())
        {
            this.name = name;
        }
        public DALCourse(string name, int credit, int grade, string degree,int studentId, int year, int semester) : base(new StudentDALController())
        {

            this.name = name;
            this.credit = credit;
            this.grade = grade;
            this.degree = degree;
            this.studentId = studentId;
            this.semester = semester;
            this.year = year;
        }
        public string Name
        {
            get => name; 
            set
            {
                cont.Update(studentId,name,degree, CourseNameColumn, value);
                name = value;
            }
        }
        public int Credit
        {
            get => credit; 
            set
            {
                cont.Update(studentId, name, degree, CourseCreditColumn, value.ToString());
                credit = value;
            }
        }
        public int Grade
        {
            get => this.grade; 
            set
            {
                cont.Update(studentId, name, degree, CourseGradeColumn, value.ToString());
                grade = value;
            }
        }
        public int Year
        {
            get => this.year;
            set
            {
                cont.Update(studentId, name, degree, CourseGradeColumn, value.ToString());
                year = value;
            }
        }
        public int StudentId
        {
            get=>this.studentId; 
            set
            {
                cont.Update(studentId, name, degree, CourseGradeColumn, value.ToString());
                studentId = value;
            }
        }
        public int Semester
        {
            get => this.semester;
            set
            {
                cont.Update(studentId, name, degree, CourseGradeColumn, value.ToString());
                semester = value;
            }
        }
        public string Degree
        {
            get => degree;
            set
            {
                cont.Update(studentId, name, degree, CourseNameColumn, value);
                degree = value;
            }
        }
    }
}

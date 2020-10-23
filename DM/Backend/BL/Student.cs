using DM.Backend.DAL;
using DM.Backend.DAL.DALO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DM.Backend.BL
{
    public class Student
    {

        private string name;
        private string password;
        private int id;
        private Degree degree;
        private StudentDALController stu = new StudentDALController();

        public Student(string name, int id, string pass)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = null;
        }
        public Student(Student stu)
        {
            this.password = stu.Password;
            this.name = stu.Name;
            this.id = stu.Id;
            degree = stu.Degree;
        }

        public string Password
        {
            get => this.password;
        }

        public Student(string name, int id, int years, string degName,string pass,int credit)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = new Degree(degName, years,credit,id);
        }
        public Student(string name, int id, int years, string degName, int expectedAvg, string pass, int credit)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = new Degree(degName, years, expectedAvg,credit);
        }
        public void startDegree(int years, string name,int credits)
        {
            degree = new Degree(name, years,credits,id);
        }
        public void startDegree(int years, string name, int expectedAvg, int credits)
        {
            degree = new Degree(name, years, expectedAvg,credits);
        }
        public void addCourse(int sem, Course course)
        {

            degree.addCourse(sem, course);
        }
        public void addCourse(int sem, string name, int credit)
        {
            int year = sem / 2;
            int semester = sem - (2 - (year - 1));
            degree.addCourse(sem, name, credit);
        }
        public void addCourse(int year, int sem, string name, int credit)
        {
           
            degree.addCourse(year,sem, name, credit);
        }
        public void addCourse(int year, int sem, Course course)
        {
            degree.addCourse(year, sem,course);
        }
        public void addSemester(Semester sem)
        {
            degree.addSemester(sem);
        }
        public void addSemester(int sem)
        {
            degree.addSemester(sem);
        }
        public double getDifference() => degree.getDifference();

        public void deleteSemester(int sem)
        {
            degree.deleteSemester(sem);
        }
        public void deleteSemester(Semester sem)
        {
            degree.deleteSemester(sem);
        }
        public void deleteCourse(string name)
        {
            degree.deleteCourse(name);
        }
        public void deleteCourse(Course cour)
        {
            degree.deleteCourse(cour);
        }
        public void setGrade(string course, int grade)
        {
            degree.setGrade(course,grade);
        }

        public double getAverage() => degree.Average;
        public Semester getSemester(int sem)
        {
           return degree.getSemester(sem);
        }
        public Course getCourse(Course cour)
        {
            return degree.getCourse(cour);
        }
        public Course getCourse(string cour)
        {
            return degree.getCourse(cour);
        }
        public string Name
        {
            get => this.name;
            set
            {
                stu.Update(id,DALStudent.StudentNameColumn,value.ToString());
                name = value;
            }
        }
        public int Id
        {
            get => this.id;
            set
            {
                stu.Update(id, DALStudent.StudentIdColumn, value.ToString());
                id = value;
            }
        }
        public Degree Degree
        {
            get { return this.degree; }
            set
            {
                this.degree = value;
            }
        }
        public void passCheck(string pass)
        {
            if (pass.Length < 4) throw new DException("password must be in 4 digits length");
        }

        internal void setName(string name)
        {
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DM.Backend.BL
{
    class Student
    {

        private string name;
        private string password;
        private int id;
        private Degree degree;

        public Student(string name, int id, string pass)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = null;
        }
        public Student(Student stu)
        {
            this.password = stu.Password();
            this.name = stu.Name();
            this.id = stu.Id();
            degree = stu.Degree();
        }

        private string Password() => this.password;

        public Student(string name, int id, int years, string degName,string pass)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = new Degree(degName, years);
        }
        public Student(string name, int id, int years, string degName, int expectedAvg, string pass)
        {
            this.password = pass;
            this.name = name;
            this.id = id;
            degree = new Degree(degName, years, expectedAvg);
        }
        public void startDegree(int years, string name,int credits)
        {
            degree = new Degree(name, years,credits);
        }
        public void startDegree(int years, string name, int expectedAvg, int credits)
        {
            degree = new Degree(name, years, expectedAvg,credits);
        }
        public string Name() => this.name;
        public int Id() => this.id;
        public Degree Degree() => this.degree;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
    }
}

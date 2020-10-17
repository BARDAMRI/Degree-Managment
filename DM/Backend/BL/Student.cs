using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Backend.BL
{
    class Student
    {

        private string name;
        private int id;
        private Degree degree;

        public Student(string name, int id,int years,string degName)
        {
            this.name = name;
            this.id = id;
            degree = new Degree(degName,years);
        }
        public Student(string name, int id, int years, string degName, int expectedAvg)
        {
            this.name = name;
            this.id = id;
            degree = new Degree(degName, years,expectedAvg);
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

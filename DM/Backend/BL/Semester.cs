using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DM.Backend.BL;

namespace DM.Backend.BL
{
    class Semester
    {
        private int number;
        private Dictionary <string,Course> courses;
        private int credit;
        private double average;

        public Semester(int name)
        {
            this.number = name;
            this.average = 0;
            this.credit = 0;
            this.courses = new Dictionary<string, Course>();

        }
         public void setNumber(int num)
        {
            this.number = num;
        }
        public int Number() => this.number;
        public void addCourse(Course course)
        {
            courses.Add(course.Name(),course);
        }
         public bool addCourse(String name, int credits)
        {
            courses.Add(name,new Course(name, credits));
            setAverage(courses[name].Grade(),credits);
            this.credit += credits;
            return true;

        }
        public bool deleteCourse(Course course)
        {
         if(courses.ContainsKey(course.Name()))
                {
                courses.Remove(course.Name());
                return true;
                }
            return false;
        }
        public bool containsCourse(Course course)
        {
            return courses.ContainsKey(course.Name());
        }
        public bool containsCourse(string course)
        {
            return courses.ContainsKey(course);
        }
        public bool deleteCourse(String name) 
        {
            if (courses.ContainsKey(name))
            {
                courses.Remove(name);
                return true;
            }
            return false;
        }
        public void addBlocker(Course course, Course blocker)
        {
            this.courses[course.Name()].addBlocker(blocker);
        }
        public void addBlocker(string course, Course blocker)
        {
            this.courses[course].addBlocker(blocker);
        }
        public void removeBlocker(Course course, Course blocker)
        {
            this.courses[course.Name()].removeBlocker(blocker);
        }
        public void removeBlocker(Course course, string blocker)
        {
            this.courses[course.Name()].removeBlocker(blocker);
        }
        public void removeBlocker(string course, string blocker)
        {
            this.courses[course].removeBlocker(blocker);
        }
        public Course getCourse(String name) => courses[name];
        public double Average() => this.average;
        public int Credit() => this.credit;
        protected void setAverage(int grade, int credit)
        {
            if (grade >= 0)
            {
                double sum = Average() * Credit();
                sum += (credit * grade);
                sum /= (Credit() + credit);
                this.average = sum;
            }
        }

        internal void setGrade(string course, int grade)
        {
            courses[course].setGrade(grade);
            setAverage(grade,courses[course].Credit());
            
        }

        public override bool Equals(object obj)
        {
            if (obj is Semester)
            {
                bool equal = true;
                Semester sem = (Semester)obj;
                if (Number() != sem.Number() || Credit() != sem.Credit()||Average()!=sem.Average())
                    equal = false;
                foreach (KeyValuePair<string, Course> course in courses)
                {
                    if (!sem.hasCourse(course))
                    {
                        equal = false;
                    }
                }
                foreach (KeyValuePair<string, Course> course in sem.Courses())
                {
                    if (!this.hasCourse(course))
                    {
                        equal = false;
                    }
                }
                return equal;
            }
            return false;
        }
        public Dictionary<string, Course> Courses() => this.courses;
        private bool hasCourse(KeyValuePair<string, Course> course)
        {
            return courses.ContainsKey(course.Key);
        }
    }
}

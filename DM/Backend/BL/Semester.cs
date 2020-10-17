using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DM.Backend.BL;

namespace DM.Backend.BL
{
    public class Semester
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
        public Semester(Semester sem)
        {
            this.number = sem.Number();
            this.average = sem.Average() ;
            this.credit = sem.Credit();
            this.courses = new Dictionary<string, Course>();
            foreach (KeyValuePair<string, Course> co in sem.Courses())
            {
                addCourse(new Course(co.Value));
            }
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
            return true;

        }
        public void deleteCourse(Course course)
        {
         if(courses.ContainsKey(course.Name()))
                {
                courses.Remove(course.Name());
                
                }
            throw new DException("the course "+ course.Name()+ " is not exists");

        }
        public bool containsCourse(Course course)
        {
            return courses.ContainsKey(course.Name());
        }
        public bool containsCourse(string course)
        {
            return courses.ContainsKey(course);
        }
        public void deleteCourse(String name) 
        {
            if (courses.ContainsKey(name))
            {
                courses.Remove(name);
            }
            throw new DException("the course " + name + " is not exists");
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
        public Course getCourse(String name)
        {
            if (courses.ContainsKey(name))
            {
                return courses[name];
            }
            throw new DException("the course " + name + " is not exists");
        }
        public double Average() => this.average;
        public int Credit() => this.credit;
        protected void setAverage(int grade, int credit)
        {
            if (grade >= 0 && credit > 0)
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
                    if (!sem.hasCourse(course.Key))
                    {
                        equal = false;
                    }
                }
                foreach (KeyValuePair<string, Course> course in sem.Courses())
                {
                    if (!this.hasCourse(course.Key))
                    {
                        equal = false;
                    }
                }
                return equal;
            }
            return false;
        }

        internal bool hasCourse(string name)
        {
            foreach (KeyValuePair<string, Course> cour in courses)
            {
                if (cour.Key==name)
                {
                    return true;
                }
            }
            return false;
        }

        public Dictionary<string, Course> Courses() => this.courses;

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

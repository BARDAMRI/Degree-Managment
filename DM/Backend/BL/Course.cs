using DM.Backend.DAL.DALO;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DMTest")]

namespace DM.Backend.BL
{
    public class Course
    {

        private string name;
        private int credit;
        private int grade;
        private string degree;
        private int studentId;
        private int year;
        private int semester;
        private  CourseDALController cur = new CourseDALController();

        public Course(string name, int credit,int id,string degree,int year,int semester)
        {
            this.name = name;
            this.credit = credit;
            this.grade = -1;
            this.studentId = id;
            this.year = year;
            this.semester = semester;
            this.degree = degree;
      //      blockers = new Dictionary<string, Course>();

        }
        public Course(string name,int grade, int credit, int id, string degree, int year, int semester)
        {
            this.name = name;
            this.credit = credit;
            this.grade = -1;
            this.studentId = id;
            this.year = year;
            this.semester = semester;
            this.degree = degree;
            this.grade = grade;
        }
        public Course(Course cou)
        {
            this.name = cou.Name();
            this.credit = cou.Credit();
            this.grade = cou.Grade();
            //foreach (KeyValuePair<string, Course> co in cou.Blockers())
            //{
            //    addBlocker(new Course(co.Value));
            //}
        }
    //    public Dictionary<string, Course> Blockers() => this.blockers;

        public void setName(string name) 
        {
            cur.Update(studentId,name,degree,DALCourse.CourseNameColumn,name);
            this.name = name; 
        }
        //public void addBlocker(Course course)
        //{
        //    if (!blockers.ContainsKey(name))
        //    {
        //        this.blockers.Add(course.Name(), course);
        //    }
        //    else
        //        throw new DException("blocker already exists");
        //}
        //public void removeBlocker(Course course)
        //{
        //    if (isBlocker(course.Name()))
        //    {
        //        blockers.Remove(course.Name());
        //    }
        //    else
        //    {
        //        throw new DException("the course is not blocker for " + this.Name());
        //    }
        //}
        //public void removeBlocker(string name)
        //{
        //    if (isBlocker(name))
        //    {
        //        blockers.Remove(name);
        //    }
        //    else
        //    {
        //        throw new DException("the course is not blocker for " + this.Name());
        //    }
        //}
        //public bool isBlocker(string name)
        //{
        //    if(blockers.ContainsKey(name))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public void setCredit(int newCredit)
        {
            cur.Update(studentId, name, degree, DALCourse.CourseCreditColumn, newCredit.ToString());
            this.credit = newCredit;
        }
        public void setGrade(int newGrade)
        {
            cur.Update(studentId, name, degree, DALCourse.CourseGradeColumn, newGrade.ToString());
            this.grade = newGrade;
        }
        public string Name() { return this.name; }
        public int Credit() => this.credit;
        public int Grade() => this.grade;

        public override bool Equals(object obj)
        {
            if(obj is Course)
            {
                bool equal = true;
                Course course = (Course)obj;
                if (this.name != course.Name() || this.credit != course.Credit()|this.grade!=course.grade|this.semester!=course.semester|this.year!=course.year|this.degree!=course.degree|this.studentId!=course.studentId)
                    equal = false;
                //foreach (KeyValuePair<string, Course> block in blockers)
                //{
                //    if(!course.hasBlocker(block))
                //    {
                //        equal = false;
                //    }
                //}
                return equal;
            }
            return false;
        }

        //public bool hasBlocker(KeyValuePair<string, Course> block)
        //{
        //    return blockers.ContainsKey(block.Key);
        //}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

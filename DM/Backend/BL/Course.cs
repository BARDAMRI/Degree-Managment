using System;
using System.Collections.Generic;

namespace DM.Backend.BL
{
    public class Course
    {

        private string name;
        private int credit;
        private int grade;
        private Dictionary<string,Course> blockers;

        public Course(string name, int credit)
        {
            this.name = name;
            this.credit = credit;
            this.grade = -1;
            blockers = new Dictionary<string, Course>();

        }
        public Course(Course cou)
        {
            this.name = cou.Name();
            this.credit = cou.Credit();
            this.grade = cou.Grade();
            foreach (KeyValuePair<string, Course> co in cou.Blockers())
            {
                addBlocker(new Course(co.Value));
            }
        }
        public Dictionary<string, Course> Blockers() => this.blockers;

        public void setName(string name) 
        { 
            this.name = name; 
        }
        public void addBlocker(Course course)
        {
            if (!blockers.ContainsKey(name))
            {
                this.blockers.Add(course.Name(), course);
            }
            else
                throw new DException("blocker already exists");
        }
        public void removeBlocker(Course course)
        {
            if (isBlocker(name))
            {
                blockers.Remove(course.Name());
            }
            else
            {
                throw new DException("the course is not blocker for " + this.Name());
            }
        }
        public void removeBlocker(string name)
        {
            if (isBlocker(name))
            {
                blockers.Remove(name);
            }
            else
            {
                throw new DException("the course is not blocker for " + this.Name());
            }
        }
        public bool isBlocker(string name)
        {
            if(blockers.ContainsKey(name))
            {
                return true;
            }
            return false;
        }
        public void setCredit(int newCredit)
        {
            this.credit = newCredit;
        }
        public void setGrade(int newGrade)
        {
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
                if (this.name != course.Name() || this.credit != course.Credit())
                    equal = false;
                foreach (KeyValuePair<string, Course> block in blockers)
                {
                    if(!course.hasBlocker(block))
                    {
                        equal = false;
                    }
                }
                return equal;
            }
            return false;
        }

        public bool hasBlocker(KeyValuePair<string, Course> block)
        {
            return blockers.ContainsKey(block.Key);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

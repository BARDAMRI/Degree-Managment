﻿using System;
using System.Collections.Generic;
using System.Text;
using DM.Backend.BL;

namespace DM.Backend.BL
{
    class Year
    {
        private int number;
        private Semester [] semesters;
        private int credit;
        private double average;

        public Year(int num)
        {
            this.number = num;
            this.average = 0;
            this.credit = 0;
            semesters = new Semester[2];
        }
        public void setNumber(int num)
        {
            this.number = num;
        }
        public int Number() => this.number;
        public void addCourse(int semester ,Course course)
        {
            semesters[semester-1].addCourse(course);
        }
        public void addCourse(int semester, string name,int credit)
        {
            semesters[semester - 1].addCourse(name,credit);
        }
        public void addSemester(Semester sem)
        {
            if(semesters[sem.Number()]==null)
            {
                semesters[sem.Number()] = sem;
            }
        }
        public Semester getSemester(int sem) => this.semesters[sem];
        public Semester deleteSemester(Semester sem)
        {
            if(semesters[sem.Number()].Equals(sem))
            {
                Semester sem1 = semesters[sem.Number()];
                semesters[sem.Number()] = null;
                return sem1;
            }
            return null;
        }
        public bool deleteCourse(Course course)
        {
            for(int i=0;i<=semesters.Length;i++)
            {
                if(semesters[i].containsCourse(course))
                {
                    semesters[i].deleteCourse(course);
                    return true;
                }
            }
            return false;

        }

        public bool deleteCourse(String name)
        {
            for (int i = 0; i <= semesters.Length; i++)
            {
                if (semesters[i].containsCourse(name))
                {
                    semesters[i].deleteCourse(name);
                    return true;
                }
            }
            return false;
        }
        public Course getCourse(String name)
        {
            for (int i = 0; i <= semesters.Length; i++)
            {
                if (semesters[i].containsCourse(name))
                {
                    return semesters[i].getCourse(name);
                }
            }
            return null;
        }
        public bool setGrade(string course, int grade)
        {
            for (int i = 0; i <= semesters.Length; i++)
            {
                if (semesters[i].containsCourse(course))
                {
                    semesters[i].setGrade(course,grade);
                    setAverage();
                    return true;
                }
            }
            return false;
        }
        public double Average() => this.average;
        public int Credit() => this.credit;
        protected void setAverage()
        {
            double sum=0;
           for(int i=0; i<=semesters.Length;i++)
            {
                sum += (semesters[i].Average() * semesters[i].Credit());
                sum /= Credit();
                this.average = sum;
            }
        }

    }
}

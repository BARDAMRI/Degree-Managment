using System;
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
            semesters = new Semester[2];
            this.number = num;
            this.average = 0;
            this.credit = 0;
            semesters = new Semester[2];
            for(int i=1;i<=semesters.Length;i++)
            {
                semesters[i-1] = new Semester(2*(number-1)+i);
            }
        }
        public Year(Year ye)
        {
            semesters = new Semester[ye.Semesters().Length];
            this.number = ye.Number();
            this.average = ye.Average() ;
            this.credit = ye.Credit();
            foreach(Semester sem in ye.Semesters())
            {
                semesters[(sem.Number() - 1)] = new Semester(sem);

            }
        }

        public Semester [] Semesters() => this.semesters;

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
        public void addSemester(int sem)
        {
            int semester = sem % 2;
            if (semester == 1) semester--;
            else semester++;
            
                if (semesters[semester] == null)
                {
                    semesters[semester] = new Semester(sem);
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

       public Semester deleteSemester(int sem)
        {
            if (semesters[sem]!=null)
            {
                Semester sem1 = semesters[sem];
                semesters[sem] = null;
                return sem1;
            }
            return null;
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

        internal bool hasCourse(string name)
        {
            foreach(Semester  sem in semesters )
            {
                if(sem.hasCourse(name))
                {
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
            int cred = 0;
            foreach(Semester sem in semesters)
            {
                cred += sem.Credit();
                sum += sem.Average();
            }
                sum /= cred;
                this.average = sum;
        }

    }
}

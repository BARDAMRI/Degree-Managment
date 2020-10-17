using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DM.Backend.BL;

namespace DM.Backend.BL
{
    class Degree
    {
        private string name;
        private Year[] years;
        private int credit;
        private double average;
        private double expectAverage;
        private double difference;
        private double donePrecents;
        private int totalCredit;
        
        public Degree(string name, int years,int credit)
        {
            this.totalCredit = credit;
            this.name = name;
            this.years = new Year[years];
            for(int i=0;i<=years;i++)
            {
                this.years[i] = new Year(i);
            }
            this.credit = 0;
            this.average = 0;
            this.difference = 0;
            this.expectAverage = 0;
            this.difference = 0;
        }
        public Degree(string name,int years,int exp,int credit)
        {
            this.totalCredit = credit;
            this.name = name;
            this.years = new Year[years];
            for (int i = 0; i <= years; i++)
            {
                this.years[i] = new Year(i);
            }
            this.credit = 0;
            this.average = 0;
            this.difference = 0;
            this.expectAverage = exp;
            this.difference = 0;
        }
        public Degree(Degree deg)
        {
            this.name = deg.Name();
            this.years = new Year[deg.Years().Length];
            for (int i = 0; i <= deg.Years().Length; i++)
            {
                this.years[i] = new Year(deg.Years()[i]);
            }
            this.credit = deg.Credit();
            this.average = deg.Average();
            this.difference = deg.Difference();
            this.expectAverage = deg.ExpectAverage();
            this.difference = deg.Difference();
        }
        private void addCourse(int sem,Course course)
        {
            int year = sem / 2;
            int semester = sem - (2 - (year - 1));
            years[year].addCourse(semester,course);
        }
        private void addCourse(int sem, string name,int credit)
        {
            int year = sem / 2;
            int semester = sem - (2 - (year - 1));
            years[year].addCourse(semester,  name,  credit);
        }
        private void addCourse(int year, int sem, string name, int credit)
        {
            int semester = sem - (2 - (year - 1));
            years[year].addCourse(semester, name,  credit);
        }
        private void addCourse(int year,int sem, Course course)
        {
            int semester = sem - (2 - (year - 1));
            years[year].addCourse(semester, course);
        }
        public void addSemester(Semester sem)
        {
            int year = sem.Number() / 2;
            years[year].addSemester(sem);
        }
        public void addSemester(int sem)
        {
            int year = sem / 2;
            years[year].addSemester(sem);
        }
        public double getDifference() => this.difference;

        public void deleteSemester(int sem)
        {
            int year = sem / 2;
            years[year].deleteSemester(sem);
        }
        public void deleteSemester(Semester sem)
        {
            int year = sem.Number() / 2;
            years[year].deleteSemester(sem);
        }
        public bool deleteCourse(string name)
        {
            for (int i = 0; i <= years.Length; i++)
            {
                if (years[i].hasCourse(name))
                {
                    years[i].deleteCourse(name);
                    return true;
                }
            }
            return false;
        }
        public bool deleteCourse(Course cour)
        {
            string name = cour.Name();
            for (int i = 0; i <= years.Length; i++)
            {
                if (years[i].hasCourse(name))
                {
                    years[i].deleteCourse(name);
                    return true;
                }
            }
            return false;
        }
        public bool setGrade(string course, int grade)
        {
            for (int i = 0; i <= years.Length; i++)
            {
                if (years[i].hasCourse(course))
                {
                    years[i].setGrade(course,grade);
                    setAverage();
                    return true;
                }
            }
            return false;
        }

        private void setAverage()
        {
            double sum = 0;
            int cred = 0;
            foreach (Year year in years)
            {
                cred += year.Credit();
                sum += year.Average();
            }
            sum /= cred;
            this.average = sum;

        }

        public Semester getSemester(int sem)
        {
            int year= sem / 2;
            int semester= (sem-1)% 2;
            return years[year].getSemester(semester);
        }
        public Course getCourse(Course cour)
        {
            string name = cour.Name();
            for (int i = 0; i <= years.Length; i++)
            {
                if (years[i].hasCourse(name))
                {
                   return years[i].getCourse(name);
                }
            }
            return null;
        }
        public Course getCourse(string cour)
        {
            for (int i = 0; i <= years.Length; i++)
            {
                if (years[i].hasCourse(cour))
                {
                    return years[i].getCourse(cour);
                }
            }
            return null;
        }
        public int TotalCredit() => this.totalCredit;
        public double DonePrecent() => this.donePrecents;
        private string Name() => this.name;

        private double ExpectAverage() => this.expectAverage;

        private double Difference() => this.difference;

        private double Average() => this.average;
        private int Credit() => this.credit;

        public Year [] Years() => this.years;
    }
}

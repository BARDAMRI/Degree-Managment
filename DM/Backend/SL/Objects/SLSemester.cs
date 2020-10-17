using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.BL;

namespace DM.Backend.SL.Objects
{
    public struct SLSemester
    {
        private readonly int number;
        private IReadOnlyCollection<Course> courses;
        private readonly int credit;
        private readonly double average;

        internal SLSemester(int number, int credit, double average, IReadOnlyCollection<Course> courses)

        {
            this.number = number;
            this.credit = credit;
            this.average = average;
            this.courses = courses;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLSemester))
                return false;
            else
            {
                SLSemester sem = (SLSemester)obj;
                if (sem.number == this.number & sem.credit == this.credit & sem.average == this.average)
                {
                    if (this.courses == null & sem.courses == null)
                        return true;
                    IEnumerable<Course> cour1 = this.courses.Except<Course>(sem.courses);
                    IEnumerable<Course> cour2 = sem.courses.Except(this.courses);
                    if (cour1.Count<Course>() == 0 & cour2.Count<Course>() == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.BL;


namespace DM.Backend.SL.Objects
{
    public struct SLYear
    {
        private readonly int number;
        private SLSemester[] semesters;
        private readonly int credit;
        private readonly double average;

        internal SLYear(int number, int credit, double average, SLSemester[] semesters)

        {
            this.number = number;
            this.credit = credit;
            this.average = average;
            this.semesters = semesters;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLYear))
                return false;
            else
            {
                SLYear year = (SLYear)obj;
                if (year.number == this.number & year.credit == this.credit & year.average == this.average)
                {
                    if (this.semesters == null & year.semesters == null)
                        return true;
                   for(int i=0;i<semesters.Length;i++)
                    {
                        if (!semesters[i].Equals(year.semesters[i]))
                        {
                            return false;
                        }
                    }
                    return true;
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

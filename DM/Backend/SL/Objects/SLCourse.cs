using DM.Backend.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.SL.Objects
{
    public struct SLCourse
    {
        private readonly string name;
        private readonly int credit;
        private readonly int grade;
    //   private readonly IReadOnlyCollection<Course> blockers;

        internal SLCourse( string name, int credit, int grade)//, IReadOnlyCollection<Course> blockers)

        {
            this.name = name;
            this.credit = credit;
            this.grade = grade;
        //    this.blockers = blockers;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLCourse))
                return false;
            else
            {
                SLCourse cour = (SLCourse)obj;
                if (cour.name == this.name & cour.credit == this.credit & cour.grade == this.grade)
                {
                    //if (this.blockers == null & cour.blockers == null)
                    //    return true;
                    //IEnumerable<Course> block1 = this.blockers.Except<Course>(cour.blockers);
                    //IEnumerable<Course> block2 = cour.blockers.Except(this.blockers);
                    //if (block1.Count<Course>() == 0 & block2.Count<Course>() == 0)
                        return true;
                    //else
                    //    return false;
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

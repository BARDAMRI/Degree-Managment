using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.BL;

namespace DM.Backend.SL.Objects
{
    public class SLStudent
    {
        private readonly string name;
        private readonly string password;
        private readonly int id;
        private Degree degree;

        internal SLStudent(string name, string password, int id, Degree degree)

        {
            this.name = name;
            this.password = password;
            this.id = id;
            this.degree = degree;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLStudent))
                return false;
            else
            {
                SLStudent stu = (SLStudent)obj;
                if (stu.name == this.name & stu.password == this.password & stu.id == this.id & stu.degree == this.degree)
                {
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

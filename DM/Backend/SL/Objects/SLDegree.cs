using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.BL;


namespace DM.Backend.SL.Objects
{
    public class SLDegree
    {
        public readonly string name;
        public Year[] years;
        public readonly int credit;
        public readonly double average;
        public readonly double expectAverage;
        public readonly double difference;
        public readonly double donePrecents;
        public readonly int totalCredit;

        internal SLDegree(string name, int credit, double average, double expectAverage, double difference, double donePrecents,int totalCredit, Year[] years)

        {
            this.name = name;
            this.credit = credit;
            this.average = average;
            this.expectAverage = expectAverage;
            this.difference = difference;
            this.donePrecents = donePrecents;
            this.totalCredit = totalCredit;
            this.years = years;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLDegree))
                return false;
            else
            {
                SLDegree degree = (SLDegree)obj;
                if (degree.name == this.name & degree.credit == this.credit & degree.average == this.average & degree.expectAverage == this.expectAverage & degree.difference == this.difference & degree.donePrecents == this.donePrecents & degree.totalCredit == this.totalCredit)
                {
                    if ((this.years == null & degree.years == null)||(this.years.Length == 0 & degree.years.Length == 0))
                        return true;
                    if (this.years.Length != degree.years.Length)
                        return false;
                    foreach (Year year in years)
                    {
                        bool contains = false;
                        foreach (Year yea in degree.years)
                        {
                            if (year.Equals(yea))
                                contains = true;
                        }
                        if (!contains)
                            return false;
                    }
                    foreach (Year year in degree.years)
                    {
                        bool contains = false;
                        foreach (Year yea in years)
                        {
                            if (year.Equals(yea))
                                contains = true;
                        }
                        if (!contains)
                            return false;
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

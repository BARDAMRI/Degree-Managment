﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.BL;


namespace DM.Backend.SL.Objects
{
    class SLDegree
    {
        private readonly string name;
        private Year[] years;
        private readonly int credit;
        private readonly double average;
        private readonly double expectAverage;
        private readonly double difference;
        private readonly double donePrecents;
        private readonly int totalCredit;

        internal SLDegree(string name, int credit, double average, double expectAverage, double difference, double donePrecents,int totalCredit, Year[] years)

        {
            this.name = name;
            this.credit = credit;
            this.average = average;
            this.expectAverage = expectAverage;
            this.difference = difference;
            this.donePrecents = donePrecents;
            this.donePrecents = totalCredit;
            this.years = years;

        }
        public override bool Equals(object obj)
        {
            if (!(obj is SLDegree))
                return false;
            else
            {
                SLDegree degree = (SLDegree)obj;
                if (degree.name == this.name & degree.credit == this.credit & degree.average == this.average & degree.expectAverage == this.expectAverage & degree.difference == this.difference & degree.donePrecents == this.donePrecents & degree.donePrecents == this.donePrecents)
                {
                    if (this.years == null & degree.years == null||(this.years.Length == 0 & degree.years.Length == 0))
                        return true;
                    if (this.years.Length != degree.years.Length)
                        return false;
                        for (int i = 0; i < years.Length; i++)
                    {
                        if (!years[i].Equals(degree.years[i]))
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

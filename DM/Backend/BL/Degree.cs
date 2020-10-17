using System;
using System.Collections.Generic;
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
        
        public Degree(string name, int years)
        {
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
        public Degree(string name,int years,int exp)
        {
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

        private string Name() => this.name;

        private double ExpectAverage() => this.expectAverage;

        private double Difference() => this.difference;

        private double Average() => this.average;
        private int Credit() => this.credit;

        public Year [] Years() => this.years;
    }
}

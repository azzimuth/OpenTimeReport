using System;

namespace opentimereport.Models
{
    public class TimeReport
    {
        public Guid Id { get; set; }
        public Guid ActivityId
        {
            get;
            set;

        }
        public Guid ProjectId
        {
            get;
            set;
        }

        public int WeekNumber
        {
            get;
            set;
        }
        public float Day1Hours
        {
            get;
            set;
        }
        public float Day2Hours
        {
            get;
            set;
        }
        public float Day3Hours
        {
            get;
            set;
        }
        public float Day4Hours
        {
            get;
            set;
        }
        public float Day5Hours
        {
            get;
            set;
        }
        public float Day6Hours
        {
            get;
            set;
        }
        public float Day7Hours
        {
            get;
            set;
        }
    }
}
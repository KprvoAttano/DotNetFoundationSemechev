using System;
using System.Collections.Generic;
using System.Text;

namespace Task2StudentsSemechev
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> TestResults { get; set; }
        public double Average { get { return GetAverage(); } }

        public override string ToString()
        {
            return FirstName + " " + LastName + ": " + Average + " - " + GetLetter(Average);
        }

        public double GetAverage()
        {
            int all = 0;
            for (int i = 0; i < TestResults.Count; i++)
            {
                all += TestResults[i];
            }
            return all / TestResults.Count;
        }

        public string GetLetter(double avg)
        {
            if (avg >= 90)
                return "A";
            if (avg >= 80)
                return "B";
            if (avg >= 70)
                return "C";
            if (avg >= 60)
                return "D";
            return "F";
        }
    }
}

using System;
namespace StuctBirthday16._02._2023LB
{
    public struct Birthday
    {
        public string Day { set; get; }
        public string Month { set; get; }
        public string Year { set; get; }

        public Birthday(string D, string M, string Y)
        {
            Day = D;
            Month = M;
            Year = Y;
        }
    }
    
}

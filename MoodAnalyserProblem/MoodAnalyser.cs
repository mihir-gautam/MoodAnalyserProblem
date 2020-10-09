using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string pattern = "^.*Sad.*$";
        string msg;
        public string analyseMood()
        {
            if (msg == "I am in Sad Mood")
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        public string analyseMood(string message)
        {
            bool match = Regex.IsMatch(message, pattern);
            if (match)
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}

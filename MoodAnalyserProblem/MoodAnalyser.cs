using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string pattern = "(^.*Sad.*$)|(^.*sad.*$)|(^.*SAD.*$)";
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

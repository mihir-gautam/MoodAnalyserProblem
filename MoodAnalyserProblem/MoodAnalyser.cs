using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser : Exception
    {
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

        string pattern = "(^.*Sad.*$)|(^.*sad.*$)|(^.*SAD.*$)";

        public string AnalyseMood(string message)
        {
            if (message != null)
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
            else
            {
                return "Value cannot be null";
            }
        }
    }
}
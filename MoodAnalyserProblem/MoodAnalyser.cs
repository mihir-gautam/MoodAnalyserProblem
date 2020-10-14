using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        private string msg;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public MoodAnalyser()
        { }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad")|| this.message.Contains("SAD")|| this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}

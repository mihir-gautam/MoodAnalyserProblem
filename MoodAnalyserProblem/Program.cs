using System;
using System.ComponentModel.DataAnnotations;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
            MoodAnalyser analyser = new MoodAnalyser();
            Console.WriteLine("your current mood : ");
            string message = Console.ReadLine();
            string mood = analyser.analyseMood(message);
            Console.WriteLine(mood);
        }
    }
}

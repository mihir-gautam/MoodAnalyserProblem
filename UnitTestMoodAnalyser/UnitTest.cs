using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;

namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void when_pass_I_am_Sad_should_return_Sad()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser("I am in Sad Mood");
            //Act
            string result1 = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("SAD", result1);
        }
        [TestMethod]
        public void when_pass_I_am_Happy_should_return_happy()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser("I am in Any Mood");
            //Act
            string result2 = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", result2);
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = string.Empty;
                MoodAnalyser mood = new MoodAnalyser(message);
                string moodStr = mood.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyse_ClassName_Should_Return_MoodAnalyse_Object()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser","MoodAnalyser");
            expected.Equals(obj);
        }
    }
}


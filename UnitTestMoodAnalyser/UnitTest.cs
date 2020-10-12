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
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result1 = analyser.AnalyseMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result1);
        }
        [TestMethod]
        public void when_pass_I_am_Happy_should_return_happy()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result2 = analyser.AnalyseMood("I am in Any Mood");
            //Assert
            Assert.AreEqual("HAPPY", result2);
        }
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_NullException()
        {
            try
            {
                string msg = null;
                MoodAnalyser analyser = new MoodAnalyser();
                string mood = analyser.AnalyseMood(msg);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Value cannot be null", e.Message);
            }
        }
    }
}


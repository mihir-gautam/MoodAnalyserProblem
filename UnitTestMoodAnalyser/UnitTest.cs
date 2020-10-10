using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when_pass_I_am_Sad_should_return_Sad()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result1 = analyser.analyseMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result1);
        }
        [TestMethod]
        public void when_pass_I_am_Happy_should_return_happy()
        {
            //Arrage
            MoodAnalyser analyser = new MoodAnalyser();
            //Act
            string result2 = analyser.analyseMood("I am in Any Mood");
            //Assert
            Assert.AreEqual("HAPPY", result2);
        }
    }
}


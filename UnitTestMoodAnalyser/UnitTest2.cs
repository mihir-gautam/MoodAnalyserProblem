using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace UnitTestMoodAnalyser
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test1Case2()
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


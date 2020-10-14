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
            object obj = MoodAnalyseReflector.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [TestMethod]
        public void Given_Improper_MoodAnalyse_ClassName_Should_throw_MoodAnalysisException_Indicating_NoSuchClass()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyseReflector.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyyser", "MoodAnalyyser");
                expected.Equals(obj);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Improper_MoodAnalyse_Constructor_Should_throw_MoodAnalysisException_Indicating_NoSuchMethod()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyseReflector.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyyserr");
                expected.Equals(obj);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Proper_Message_To_MoodAnalyse_Should_Return_MoodAnalyse_Object()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyseReflector.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "I am in Happy Mood");
            expected.Equals(obj);
        }
        [TestMethod]
        public void Given_Proper_Message_But_Improper_MoodAnalyse_ClassName_Should_throw_MoodAnalysisException_Indicating_NoSuchClass()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyseReflector.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyyser", "MoodAnalyyser", "I am in Happy Mood");
                expected.Equals(obj);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Proper_Message_But_Improper_MoodAnalyse_Constructor_Should_throw_MoodAnalysisException_Indicating_NoSuchMethod()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyseReflector.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyyser", "I am in Happy Mood");
                expected.Equals(obj);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Happy_Mood_Using_Reflection_When_Proper_Should_Return_Happy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyseReflector.InvokeAnalyseMood("Happy","AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
        public void Given_Happy_Message_But_Improper_Method_Should_throw_MoodAnalysisException_Indicating_NoSuchMethod()
        {
            try
            {
                string expected = "HAPPY";
                string mood = MoodAnalyseReflector.InvokeAnalyseMood("Happy", "AnalyyseMood");
                expected.Equals(mood);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Happy_Message_With_Reflector_Should_Return_Happy()
        {
            string expected = "HAPPY";
            string result = MoodAnalyseReflector.SetField("HAPPY", "message");
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Happy_Message_Improper_Field_Should_Throw_MoodAnalyserCustomException()
        {
            try
            {
                string result = MoodAnalyseReflector.SetField("HAPPY", "any");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Field not found", e.Message);
            }
        }
        [TestMethod]
        public void Given_Null_Message_With_Reflection_Should_Throw_MoodAnalyserCustomException()
        {
            try
            {
                string message = null;
                string result = MoodAnalyseReflector.SetField(message, "message");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }
    }
}


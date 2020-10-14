using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
    public class MoodAnalyseFactory
    { 

        public string Message { get; set; }

        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string message = null;
            return CreateMoodAnalyseUsingParameterizedConstructor(className,constructorName, message);
        }

        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                    object instance = info.Invoke(new object[] { (message) });
                    return instance;
                }
                else
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
            else
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
        }
    }
}

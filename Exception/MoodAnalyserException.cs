using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
       public enum ExceptionType
        {
            Empty_Exception,
            Null_Exception,
            Class_Not_Found,
            No_SuchMethod,
            Error_In_Object_Creation,
            Constructor_Not_Found

        }

       public ExceptionType exceptionTypeObject;
       public string message;

        public MoodAnalyserException(ExceptionType exceptionTypeObject, string message) : base(message)
        {
            this.exceptionTypeObject = exceptionTypeObject;
            this.message = message;

        }

        //public MoodAnalyserException(string message) : base(message)
        //{
       // }
    }
}

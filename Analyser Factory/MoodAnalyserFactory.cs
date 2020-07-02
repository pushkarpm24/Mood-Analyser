using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoodAnalyser.Analyser_Factory
{
    public class MoodAnalyserFactory <GenericType>
    {
        public ConstructorInfo GetConstructor()
        {
            try
            {
                Type type = typeof(GenericType);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, "No such class found");
            }
        }

        public ConstructorInfo FindConstructor(string classname)
        {
            try
            {
                 
                Type type = Type.GetType(classname);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, "No such class found");
            }
        }



        public object GetInstance(string className, ConstructorInfo constructor)
        {
            try
            {
                Type type = typeof(GenericType);
                if (className != type.Name)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, "No such class found");
                }
                if (constructor != type.GetConstructors()[0])
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Constructor_Not_Found, "No such constructor found");
                }
                GenericType reflectionCreatedObject = Activator.CreateInstance<GenericType>();
                return reflectionCreatedObject;
            }
            catch (MoodAnalyserException e)
            {

                return e.Message;
            }

            

        }
    }
}

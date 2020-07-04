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
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, e.message);
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
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, e.message);
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

        public ConstructorInfo ParametrisedConstructor(int numberOfParameters)
        {
            try
            {
                Type type = typeof(GenericType);

                ConstructorInfo[] constructor = type.GetConstructors();
                foreach (ConstructorInfo i in constructor)
                {
                    int numberOfParam = i.GetParameters().Length;
                    if (numberOfParam == numberOfParameters)
                    {
                        return i;
                    }
                }
                return constructor[0];
            }
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, e.message);
            }
        }

        public object  InstanceMaker(string className, ConstructorInfo constructor, string message)
        {
            try
            {
                Type type = typeof(GenericType);
                if (className != type.Name)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Class_Not_Found, "No such class found");
                }
                if (constructor != type.GetConstructors()[1])
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Constructor_Not_Found, "No such method found");
                }
                object returnObject = Activator.CreateInstance(type, message);
                return returnObject;
            }
            catch (MoodAnalyserException e)
            {

                return e.Message;
            }

        }
    }
}

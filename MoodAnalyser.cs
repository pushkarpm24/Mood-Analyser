using System;

namespace MoodAnalyser
{
    public class MoodAnalysis

    {
        static void Main(string[] args)
        {

        }

        public MoodAnalysis()
        {
            
        }

        public string AnalyseMood(string message)
        {
            try
            {
                if(message.Length == 0)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Empty_Exception,"Message Can Not Be Empty");
                }

                else if (message.Contains("Sad"))
                {
                    return "SAD";
                }

                else if (message.Contains("Any"))
                {
                    return "HAPPY";
                }

                else
                {
                    return "It Can Be Any Thing";
                }
            }

            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Null_Exception, "Null Pointer");
            }


        }

    }
}

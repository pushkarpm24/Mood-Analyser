using System;

namespace MoodAnalyser
{
    public class MoodAnalysis

    {
        static void Main(string[] args)
        {
            
        }

        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";               
            }

            else
            {
                return "Happy";
            }
        }

    }
}

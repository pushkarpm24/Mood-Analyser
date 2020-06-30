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
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";               
            }

            else if (message.ToLower().Contains("any"))
            {
                return "HAPPY";
            }

            else
            {
                return "Not Sure About Mood";
            }
        }

    }
}

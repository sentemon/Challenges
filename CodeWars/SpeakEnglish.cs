namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
          sentence = sentence.ToLower();
          return sentence.Contains("english");
        }
    }
}
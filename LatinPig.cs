namespace PigLatin
{
    internal class PigLatin
    {
        // Function to translate every word given
        public static string TranslateWord(string word)
        {
            char[] vovel = new char[]
            {
                'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
            };

            string result = "";

            if (vovel.Contains(word[0]))
            {
                result = word + "yay";
            }
            else
            {
                string move = "";
                int i = 0;
                for (i = 0; i < word.Length; i++)
                {
                    if (!vovel.Contains(word[i]))
                    {
                        move += word[i];
                    }
                    else
                    {
                        result = word.Substring(i, word.Length - i) + move + "ay";
                        break;
                    }
                }
            }

            return result;
        }

        public static string TranslateSentence(string sentence)
        {
            string[] sentence_words = sentence.Split(' ');
            string result = "";

            foreach (string i in sentence_words)
            {
                result += TranslateWord(i) + " ";
            }

            return result;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(TranslateWord("shrimp"));
            Console.WriteLine(TranslateSentence("I am a gooood boy"));
        }
    }
}
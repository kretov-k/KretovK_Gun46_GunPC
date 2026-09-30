using System.Text;

namespace KretovK_Gun42_GunPC
{
    internal class Program
    {
        public static string ConcatenateStrings(string firstString, string secondString)
        {
            return firstString + " " + secondString;
        }
        
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        public static string StringInfo(string input)
        {
            return $"Numner of characters: {input.Length}\n" + $"Upper case: {input.ToUpper()}\n" + $"Lower case: {input.ToLower()}";
        }

        public static string FirstFiveCharacters(string input)
        {
            return input.Substring(0, 5);
        }

        public static StringBuilder BuildSentence(string[] words)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                result.Append(words[i]);

                if (i < words.Length - 1)
                {
                    result.Append(" ");
                }
            }
            return result;
        }

        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
        static void Main(string[] args)
        {
            string concatResult = ConcatenateStrings("Hello", "there");
            Console.WriteLine(concatResult);

            string greetResult = GreetUser("Yoda", 900);
            Console.WriteLine(greetResult);

            string infoResult = StringInfo("Never tell me the odds.");
            Console.WriteLine(infoResult);

            string firstFiveResult = FirstFiveCharacters("Skywalker");
            Console.WriteLine(firstFiveResult);

            string[] words = { "This", "is", "the", "way" };
            StringBuilder sentence = BuildSentence(words);
            Console.WriteLine(sentence.ToString());

            string replaceResult = ReplaceWords("Luke! I am your father!", "Luke", "No");
            Console.WriteLine(replaceResult);
        }
    }
}

using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.PlayGround
{
    public static class StringManipulations
    {
        public static string ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            return reverseSentence.ToString();
        }
        public static string ReverseWords(string str)
        {
            StringBuilder reverseWords = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        reverseWords.Append(charlist[j]);

                    reverseWords.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            return reverseWords.ToString();
        }
        public static Dictionary<char, int> CountOccurrenceOfEachCharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }            
            return characterCount;
        }
    }
}

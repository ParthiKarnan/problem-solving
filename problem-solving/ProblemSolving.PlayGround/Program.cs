using System;

namespace ProblemSolving.PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region String Manipulations

            string str = "Welcome to Problem Solving";
            var reverseWordOrder = StringManipulations.ReverseWordOrder(str);
            Console.WriteLine(reverseWordOrder);
            var reverseWords = StringManipulations.ReverseWords(str);
            Console.WriteLine(reverseWords);
            var characterCount = StringManipulations.CountOccurrenceOfEachCharacter(str);
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }

            #endregion String anipulations

            #region Array Manipulations

            int[] input = { 0, 8, 1, 4, 6, 2 };
            int findSecondLargeInArray = ArrayManipulations.FindSecondLargeInArray(input);
            Console.WriteLine($"Second largest value from the input : {findSecondLargeInArray}");

            #endregion Array Manipulations

            Console.ReadLine();
        }
    }
}

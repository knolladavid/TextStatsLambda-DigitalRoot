using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

        }

        public static int DigitalRoot(string rootThisNumber)
        {
            {

                List<int> digits = new List<int>();

                string currentNumber = rootThisNumber;

                while (currentNumber.Length > 1)
                {

                    int counter = 0;


                    for (int i = 0; i < currentNumber.Length; i++)
                    {

                        digits.Add(Convert.ToInt32(currentNumber[i].ToString()));
                    }

                    foreach (var item in digits)
                    {

                        counter += item;
                    }

                    currentNumber = counter.ToString();

                    digits.Clear();
                }

                int digitalRoot = Convert.ToInt32(currentNumber);

                Console.WriteLine("Input: " + rootThisNumber);
                Console.WriteLine("Output: " + digitalRoot);

                return digitalRoot;
            }
        }
        public static int NumberOfWords(string inputString)
        {
            return inputString.Split(' ').ToList().Count;

        }

        public static int NumberOfVowels(string inputString)
        {
            return inputString.ToLower().Count(x => ("aeiou").Contains(x));
        }

        public static int NumberOfConsonants(string inputString)
        {
            return inputString.ToLower().Count(x => ("bcdfghjklmnpqrstvwxyz").Contains(x));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => (" .,?;'!@#$%^&*()").Contains(x));
        }

        public static string LongestWord(string inputString)
        {
            return string.Empty;
        }

        public static string ShortestWord(string inputString)
        {
            return string.Empty;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAssessment
{
    public class MyWordClass
    {
        // To do: Write codes for the two functions below then run all tests to verify they work as expected.
        /*
         * 1. Function GetWordFromText
         * Summary:
            The first method to implement is GetWordFromText.It should return a specific word of an input text.
            Words are separated by one or more spaces( ' ' ).
            Examples: 
              GetWordFromText("one two three", 2) should return "two"
              GetWordFromText("one;two three", 2) should return "three"
              GetWordFromText("one", 1) should return "one"
            
              Be aware of
              When input parameter wordNumberToFind is less than 1, the method should throw ArgumentOutOfRangeException
              When input text does not have enough words (GetWordFromText("one", 2), method should throw ArgumentException
              When input is null method should throw ArgumentNullException.
              The method should ignore all spaces at the beginning and at the end of the input text.

        // Sample of a solution (to be removed before the candidate take the test)
        public static string GetWordFromText(string? input, int wordNumberToFind)
        {
            // Todo: write code to implement the function as described above
            if (wordNumberToFind < 1)
                throw new ArgumentOutOfRangeException("number < than 1");
            if (input == null)
                throw new ArgumentNullException("input string is null");
            input = input.Trim(); //removing spaces at beginning and end

            var words = input.Split(' '); //won't work with multiple spaces
            if (words.Length < wordNumberToFind)
                throw new ArgumentOutOfRangeException("not enough words");
            return words[wordNumberToFind - 1];
        }

        */
        /*
         * 2. Reverse 
         * Summary:
           The second method to implement in this task is Reverse. 
           It should only return a reversed string of a passed input value.
           When input is null method should throw ArgumentNullException .
           
           Examples
           Reverse("one") should return eno
           Reserve("abcd dcba") should return abcd dcba

           Be aware of
           Method should throw ArgumentNullException if input is null
           Method should return empty string, if empty string is passed as an input parameter
        
        // Sample of a solution (to be removed before the candidate take the test)
        public static string Reverse(string input)
        {
            // Todo: write code to implement the function as described above
            string result = String.Empty;
            if (input == null)
            {
                throw new ArgumentNullException("string was null");
            }
            var inputChar = input.ToCharArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += inputChar[i];
            }
            return result;
        }
        */

        public static string GetWordFromText(string? input, int wordNumberToFind)
        {
            return "???";
        }

        public static string Reverse(string? input)
        {
            return "???";
        }

    }

}
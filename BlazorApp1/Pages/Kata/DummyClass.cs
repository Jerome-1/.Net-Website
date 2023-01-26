using System.Text.RegularExpressions;

namespace BlazorApp1.Pages.Kata
{
    public class DummyCLass
    {
        public string? Name { get; set; }
        public int[] Counter(string input)
        {
            var amountOfVowel = 0;
            var amountOfCons = 0;
            var arrayForInput = new int[2];
            var vowels = new List<char> { 'a', 'e','i','o','u'};
            input = input.ToLower();
            input = input.Replace(" ", "");

            foreach( char letter in input)
            {
                if (vowels.Contains(letter))
                    amountOfVowel++;
                else
                    amountOfCons++;
            }

            arrayForInput[0] = amountOfVowel;
            arrayForInput[1] = amountOfCons;
            return arrayForInput.ToArray();
        }

        public int[] Reversi(int input)
        {
            var reverseString = string.Empty;
            var reverseInt = 0;
            var inputString = string.Empty;

            if (input != 0)
            {
                inputString = input.ToString();
            }
            foreach( char letter in inputString)
            {
                reverseString = letter + reverseString;
            }

            reverseInt = int.Parse(reverseString);
            return reverseInt.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
        }

        public string CaughtIt(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "fizzbuzz";
            else if (num % 3 == 0)
                return "fizz";
            else if (num % 5 == 0)
                return "buzz";
            else 
                return "Not valid";
        } 

        public int Characters(string input)
        {
            return input.Length;
        }
        public bool Spaces(string input)
        {
            if (input.Any(Char.IsWhiteSpace))
                return false;
            else 
                return true;
        }

        public bool Digit(string input)
        {
           if(input.Any(Char.IsDigit))
                return false;
           else
                return true;
        }

        public bool Capitals(string input)
        {
            if (input.Any(char.IsUpper))
                return true;
            else
                return false;
        }

        public int Calculate(string number)
        {
            char[] characerts = number.ToCharArray();
            var total = Int32.Parse(characerts[0].ToString()) + Int32.Parse(characerts[1].ToString());
            return total;
        }

    }
}

using System.Text.RegularExpressions;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string pattern = @"\d|one|two|three|four|five|six|seven|eight|nine|ten|zero";
            string[] lines = File.ReadAllLines("input.txt");
            foreach (string line in lines)
            {
                Match m = Regex.Match(line, pattern);
                int firstNum = Convert(m.Value);
                m = Regex.Match(line, pattern, RegexOptions.RightToLeft);
                int lastNum = Convert(m.Value);
                sum += firstNum * 10 + lastNum;
            }
            Console.WriteLine(sum);
        }

        static int Convert(string text)
        {
            switch (text)
            {
                case "one":
                case "1":  
                    return 1;
                case "two":
                case "2":
                    return 2;
                case "three":
                case "3":
                    return 3;
                case "four":
                case "4":
                    return 4;
                case "five":
                case "5":
                    return 5;
                case "six":
                case "6":
                    return 6;
                case "seven":
                case "7":
                    return 7;
                case "eight":
                case "8":
                    return 8;
                case "nine":
                case "9":
                    return 9;
                case "zero":
                case "0":
                    return 0;
            }
            throw new ArgumentException("Bad number!", nameof(text));
        }
    }
}
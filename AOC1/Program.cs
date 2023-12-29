namespace AOC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] lines = File.ReadAllLines("input.txt");
            foreach (string line in lines)
            {
                int firstNum = 0;
                int lastNum = 0;
                foreach (char c in line)
                {
                    firstNum = c - '0';
                    if (firstNum >= 0 && firstNum < 10)
                    {
                        break;
                    }
                }

                foreach (char c in line.Reverse())
                {
                    lastNum = c - '0';
                    if (lastNum >= 0 && lastNum < 10)
                    {
                        break;
                    }
                }

                int num = firstNum * 10 + lastNum;
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
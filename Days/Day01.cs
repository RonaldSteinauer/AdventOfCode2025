namespace AdventOfCode2025.Days
{
    internal class Day01
    {
        public Day01()
        {
            var input = File.ReadAllLines(Environment.CurrentDirectory + "../../../../Input/Day01.txt");

            GetResult(input);
        }

        private void GetResult(string[] input)
        {
            int count = 0;
            int currentNumber = 50;

            foreach (var line in input)
            {
                var value = GetValue(line);

                currentNumber += value;

                while (currentNumber > 99)
                {
                    currentNumber -= 100;
                }

                while (currentNumber < 0)
                {
                    currentNumber += 100;
                }

                if (currentNumber == 0)
                {
                    count++;
                }

                Console.WriteLine(currentNumber);
            }

            Console.WriteLine("Anzahl: " + count);
        }

        private int GetValue(string input)
        {
            var number = int.Parse(input[1..]);
            return input[0] == 'L' ? -1 * number : number;
        }
    }
}
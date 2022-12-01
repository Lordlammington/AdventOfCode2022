namespace AdventOfCode.Days
{
    internal class Day1
    {
        public const string filePath = "C:\\Users\\Liam\\source\\repos\\AdventOfCode\\AdventOfCode\\PuzzleInputs\\Day1Input.txt";

        private static List<int> GetTotalCalorieList()
        {
            var calorieList = new List<int>();

            var runningTotal = 0;

            //Should probably turn this into a LINQ statement
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line == string.Empty)
                {
                    calorieList.Add(runningTotal);
                    runningTotal = 0;
                    continue;
                }
                runningTotal = int.Parse(line) + runningTotal;
            }

            return calorieList;
        }

        public static int ReturnHighest()
        {
            return GetTotalCalorieList().Max();
        }

        public static int ReturnTopNthSummed(int n)
        {
            return GetTotalCalorieList().OrderByDescending(p => p).Take(n).Sum();
        }
    }
}

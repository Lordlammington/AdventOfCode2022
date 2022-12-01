namespace AdventOfCode.Days
{
    internal class Day1
    {
        public const string fileloc = "C:\\Users\\Liam\\source\\repos\\AdventOfCode\\AdventOfCode\\PuzzleInputs\\Day1Input.txt";

        private static List<int> GetTotalCalorieList()
        {
            string[] loadedtext = File.ReadAllLines(fileloc);
            List<int> calorieList = new List<int>();

            var runningtotal = 0;

            foreach (var line in loadedtext)
            {
                if (line == string.Empty)
                {
                    calorieList.Add(runningtotal);
                    runningtotal = 0;
                    continue;
                }
                runningtotal = int.Parse(line) + runningtotal;
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

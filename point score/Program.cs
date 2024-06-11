namespace point_score;

class Program
{
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<int> scores = new List<int>();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // MARK: Result
            PrintStats(scores);
        }

        // MARK: Write your solution here
        public static void PrintStats(List<int> scores)
        {

            System.Console.WriteLine($"Lowest Scoring game -> {scores.Min()}");
            System.Console.WriteLine($"Highst Scoring game -> {scores.Max()}");
            System.Console.WriteLine($"Total Season points -> {scores.Sum()}");
            System.Console.WriteLine($"Average points per game -> {scores.Average()}");

            
        }
}

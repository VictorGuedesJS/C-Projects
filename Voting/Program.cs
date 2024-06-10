namespace Voting;

class Program
{
class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("How old are you?");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            if (age < 18)
            return 0;
            else
                return (age - 18) / 4;
        }
    }
}

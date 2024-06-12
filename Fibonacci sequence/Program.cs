namespace Fibonacci_sequence;

class Program
{
public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = [0, 1];

            for (int i = 2; i < length; i++)
            {
                int j = i - 1;
                int k = j - 1;

                sequence.Add(sequence[j] + sequence[k]);    
            }

            return sequence;
        }
}

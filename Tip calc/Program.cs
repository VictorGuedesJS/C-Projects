namespace Tip_calc;

class Program
{
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            var tips = CalculateTip(input);

            System.Console.WriteLine($"10% -> $ {tips.lowerTip} \n17.5% -> $ {tips.midTip} \n25% -> $ {tips.highTip}");
        }

        // MARK: Write your solution here
        public static (string lowerTip, string midTip, string highTip) CalculateTip(int cost)
        {

            var lowerTip = cost * 10/100.0f;
            var midTip = cost * 175/1000.0f;
            var highTip = cost * 25/100.0f;

            // System.Console.WriteLine("10% -> " + (cost * 10/100.0f));
            // System.Console.WriteLine("17.5% -> " + cost * 175/1000.0f);
            // System.Console.WriteLine("25% -> " + cost * 25/100.0f);

            return (lowerTip.ToString(), midTip.ToString(), highTip.ToString());

        }
}

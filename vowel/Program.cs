namespace vowel;

class Program
{
    public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

    public static void Main(string[] args)
    {
        // MARK: Setup
        Console.WriteLine("Type in a word or phrase to find it's vowel score:");
        string input = Console.ReadLine().ToLower();

        // MARK: Result
        VowelCount(input);
    }

    // MARK: Write your solution here
    public static void VowelCount(string text)
    {

       var score = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            
            char ch = text[i];

            if (ch == 'a'){
                score += vowelScores['a'];
            }
            if (ch == 'e'){
                score += vowelScores['e'];
            }
            if (ch == 'i'){
                score += vowelScores['i'];
            }
            if (ch == 'o'){
                score += vowelScores['o'];
            }
            if (ch == 'u'){
                score += vowelScores['u'];
            }
            if (ch == 'y'){
                score += vowelScores['y'];
            }
            
            
            
        }

        Console.WriteLine(score);

    }

}

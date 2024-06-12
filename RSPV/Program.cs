namespace RSPV;

class Program
{

        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");

            // MARK: Result
            InviteDetails();
        }

        // MARK: Write your solution here
        public static void InviteDetails()
        {

           List<string> invites = family.Union(friends).ToList();
           List<string> invitesrepeat = family.Concat(friends).ToList();


            System.Console.WriteLine($"{invites.Count()} total Invites");
            var duplicates = family.Intersect(friends).ToList();
            System.Console.WriteLine($"{invitesrepeat.Count() - invites.Count()} duplicate -> {string.Join(", ", duplicates)}");
            var missing = invites.Except(rsvp).ToList();
            System.Console.WriteLine($"Missing RSPV -> {string.Join(", ", missing)}");


        }
}

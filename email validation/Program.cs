namespace email_validation;

class Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the email address you'd like to validate:");
            var input = Console.ReadLine();

            // MARK: Result
            ValidateEmail(input);

        }

        // MARK: Write your solution here
        public static void ValidateEmail(string email)
        {
            if (!char.IsLetter(email.First()))

                Console.WriteLine("This email is invalid");    

            else{

                if (email.Contains("@"))
                {
                    if (email.EndsWith(".com"))
                    {
                        Console.WriteLine("This is email is valid");
                    }
                    else{
                        Console.WriteLine("This email is invalid");
                    }
                    
                }else{
                    Console.WriteLine("This email is invalid");
                }
                  
            }

        }
    }
}

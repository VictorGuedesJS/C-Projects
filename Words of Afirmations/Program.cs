using System;
using System.Timers;
using System.Collections.Generic;

namespace Words_of_Afirmations;

class Program
{
    static Random random = new Random();
    static List<string> encouragements = new List<string>()
    {
        "Way to go!",
        "Keep it up!",
        "Almost there!",
        "You're doing great!"
    };

     private static System.Timers.Timer aTimer;

    public static void Main(string[] args)
    {
        // MARK: Setup
        Console.WriteLine("Hit ENTER to start the timer!");
        Console.ReadLine();

        // MARK: Result
        StartTimer(3);

        Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
        Console.ReadLine();
        StopTimer();
    }

    // MARK: Write your solution here...
    public static void StartTimer(int interval)
    {
        System.Console.WriteLine("Timer Start");
        aTimer = new System.Timers.Timer(interval * 1000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;



    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {

        int index = random.Next(4);
        System.Console.WriteLine(encouragements[index]);

    }
    // 6
    public static void StopTimer()
    {
        
        System.Console.WriteLine("Timer Stop");

    }
}

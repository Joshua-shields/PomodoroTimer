using System;

class PomodoroTimer
{
    /// <summary>
    /// The workduration is 25 minutes at a time
    /// The break is 5 mins
    /// </summary>
    private static int seconds;
    private static bool isWorkMode = true;
    private static int workDuration = 25 * 60; // 25 minutes in seconds
    private static int breakDuration = 5 * 60; // 5 minutes in seconds

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("----- Pomodoro Timer -----");
            Console.WriteLine($"Mode: {(isWorkMode ? "Work (" + workDuration / 60 + "m)" : "Break (" + breakDuration / 60 + "m)")}");

            StartTimer();

            if (!isWorkMode)
            {
                Console.WriteLine("Press any key to start the next work session...");
                Console.ReadKey(true);
            }

            Console.WriteLine("Timer completed!");
        }
    }
    //********************************************************************************************************************************//
   
    /// Starts the Pomodoro timer and manages this also manages countdown logic.
    /// This method performs the following actions:
    /// First it sets the initial `seconds` value based on the current `isWorkMode`.
    /// Enters a loop that continues until `seconds` reaches zero.
    private static void StartTimer()
    {
        seconds = isWorkMode ? workDuration : breakDuration;

        while (seconds > 0)
        {
            Console.Clear();
            Console.WriteLine("----- Pomodoro Timer -----");
            Console.WriteLine($"Mode: {(isWorkMode ? "Work (" + workDuration / 60 + "m)" : "Break (" + breakDuration / 60 + "m)")}");
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            Console.WriteLine($"{minutes:00}:{remainingSeconds:00}"); // Calculates and displays the formatted remaining time (minutes:seconds).
            System.Threading.Thread.Sleep(1000); //Pauses for 1 second using `Thread.Sleep(1000)`.
            seconds--;
        }
    }
}

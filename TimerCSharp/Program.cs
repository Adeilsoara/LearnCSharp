using System;
using System.Timers;

public class Program {
    private static System.Timers.Timer aTimer;

    public static void Main() {
        
        SetTimer();

        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        
    }

    private static void SetTimer() {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e) {
        //Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
        //                 e.SignalTime);
        Console.WriteLine("Executando...");
    }
}

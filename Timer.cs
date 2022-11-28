
using System;
using System.Timers;

public class TimeCounter
{
   public System.Timers.Timer aTimer;
   

   public void Runner() {

        SetTimer();

        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();
      
        Console.WriteLine("Timer has Stop...");
   }
   public void SetTimer() {

        // Create a timer with a one second interval.
        aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer.
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e) {

        int mins = 1;
        int second = 10;
        int hour = 0;

        var d = new DateTime(2000, 1, 1, hour, mins, second);

        for (int i = 0; i <= ((hour * 3600) + (mins * 60) + second); i++ ) {

            Console.WriteLine(d.ToString("HH:mm:ss"));
            Console.WriteLine("(Press Enter Key to Stop Timer...)");
            d = d.AddSeconds(-1);
            System.Threading.Thread.Sleep(100);

            aTimer.Enabled = false;

            Console.Clear();
        }
    }
}
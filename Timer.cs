
using System;
using System.Timers;

public class TimeCounter
{

    public System.Timers.Timer aTimer;

    public int overtime_count = 0;
    public int second = 0;
    public int hour = 0;
    public int mins = 0;
    public int Penalty_price = 0;

    public void Runner() {

        SetCountdownTimer();

        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();
      
        Console.WriteLine("Timer has Stop...");
        
        if (overtime_count == 0) {

            Console.WriteLine();
            Console.WriteLine("InTime");
            Console.WriteLine();
            Console.WriteLine("Thank you for using our locker.");
        }

        if (overtime_count == 1) {

            Console.WriteLine();
            Console.WriteLine("OverTime");
            Console.WriteLine();
            Console.WriteLine("Penalty for x2 payment");
            Console.WriteLine("Please pay more {0} Bath to open locker", Penalty_price);
        }

   }
   public void SetCountdownTimer() {
    
        aTimer = new System.Timers.Timer(1000);
        aTimer.Elapsed += CountDown;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;

    }

    private void CountDown(Object source, ElapsedEventArgs e) {

        aTimer.Enabled = false;

        var down = new DateTime(2000, 1, 1, hour, mins, second);

        for (int i = 0; i <= ((hour * 3600) + (mins * 60) + second); i++ ) {

            Console.WriteLine("CountDown Time");
            Console.WriteLine(down.ToString("HH:mm:ss"));
            Console.WriteLine("(Press Enter Key to Stop Timer...)");
            down = down.AddSeconds(-1);
            System.Threading.Thread.Sleep(10);

            overtime_count = 0;

            Console.Clear();

        }

        int second2 = 0;
        int mins2 = 5;
        int hour2 = 0;

        var spare = new DateTime(2000, 1, 1, hour2, mins2, second2);

        for (int i = 0; i <= ((hour2 * 3600) + (mins2 * 60) + second2); i++ ) {

            Console.WriteLine("Spare Time");
            Console.WriteLine(spare.ToString("HH:mm:ss"));
            Console.WriteLine("(Press Enter Key to Stop Timer...)");
            spare = spare.AddSeconds(-1);
            System.Threading.Thread.Sleep(10);

            overtime_count = 0;

            Console.Clear();

        }

        var up = new DateTime(2000, 1, 1, 0, 0, 0);

        for (int j = 0; j <= 900 ; j++) {

            Console.WriteLine("OverTime");
            Console.WriteLine(up.ToString("HH:mm:ss"));
            Console.WriteLine("(Press Enter Key to Stop Timer...)");
            up = up.AddSeconds(+1);
            System.Threading.Thread.Sleep(10);

            overtime_count = 1;

            Console.Clear();

        }

        Console.WriteLine("This locker exceed usage limit.");
        Console.WriteLine("Pleas contact admin to continue");
        System.Environment.Exit(0);
    }
}
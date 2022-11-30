
using System;
using System.Timers;

public class TimeChecker {

    public System.Timers.Timer aTimer;

    public void OvertimeChecker(int overtime_count, int Penalty_price) {

        DelayCounter delayCounter = new DelayCounter();

        if (overtime_count == 0) {

            Console.WriteLine();
            Console.WriteLine("InTime");
            Console.WriteLine();
            Console.WriteLine("(//Assumimg you are opening the locker and taking out the stuff inside.)");
            Console.WriteLine();
            Console.WriteLine("Thank you for using our locker.");
        }

        if (overtime_count == 1) {

            Console.WriteLine();
            Console.WriteLine("OverTime");
            Console.WriteLine();
            Console.WriteLine("Penalty for x2 payment");
            Console.WriteLine("Please pay more {0} Bath to open locker", Penalty_price);
            Console.WriteLine();
            Console.WriteLine("(//Assumimg you are paying the penalty cost via cash, QR code, or whatever you prefer.)");
            Console.WriteLine();
            Console.WriteLine("Thank you for using our locker.");
            
        }
    }
}
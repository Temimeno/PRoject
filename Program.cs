using System;
using System.Timers;
class Program {

    public static System.Timers.Timer aTimer;

    public static void Main(string[] args) {

        TimeCounter timeCounter = new TimeCounter();

        timeCounter.Runner();
   }
}
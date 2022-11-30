
using System;
using System.Timers;

class InputDetail {

    public void RunnerInput() {

        Program program = new Program();

        program.RunnerInputFromProgram();

    }

    public void ChooseSizeQuestion() {

        Console.WriteLine("Please Select Locker Size");
        Console.WriteLine("   Small  (S)");
        Console.WriteLine("   Medium (M)");
        Console.WriteLine("   Large  (L)");
    }

    public void ChooseTimeQuestion() {

        Console.WriteLine("Choosing time for using locker");
        Console.WriteLine("1.) 5  mins");
        Console.WriteLine("2.) 15 mins");
        Console.WriteLine("3.) 30 mins");
        Console.WriteLine("4.) 1  hr");
        Console.WriteLine("5.) Custom time (Type your own hours and minutes)");

    }

    public void PrintRedicision() {

        Console.WriteLine("What do you want to do next?");
        Console.WriteLine("1.) Reselect size and time.");
        Console.WriteLine("2.) Exit program.");
        Console.WriteLine();
    }
}
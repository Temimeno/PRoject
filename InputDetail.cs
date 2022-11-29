
using System;
using System.Timers;
using System.Collections.Generic;
class InputDetail {

    private string LockerSize = "";
    private int hrs = 0;
    private int mins = 0;
    private int locker_price = 0;
    private int time_price = 0;
    private int total_price = 0;
    private List<int> ForSend = new List<int>();

    public List<int> GetList() {

        return ForSend;
    }

    public void Runner() {

        ChooseSize();
        ChooseTime();
        CalculatePricefromTime();
        Confirmation();

    }

    private void ChooseSizeQuestion() {

        Console.WriteLine("Please Select Locker Size");
        Console.WriteLine("   Small  (S)");
        Console.WriteLine("   Medium (M)");
        Console.WriteLine("   Large  (L)");
    }
    
    public void ChooseSize() {

        ChooseSizeQuestion();

        int i = 0;

        do {

            Console.Write("(Input S/M/L to select size) : ");
            string size = Console.ReadLine();

            switch(size) {
                
                case "s":
                case "S": {
                    Console.WriteLine();
                    Console.WriteLine("You select Small Locker (5 Bath)");
                    LockerSize = "Small";
                    locker_price += 5;
                    i = 1;
                    break;
                }

                case "m":
                case "M": {
                    Console.WriteLine();
                    Console.WriteLine("You select Medium Locker (10 Bath)");
                    LockerSize = "Medium";
                    locker_price += 10;
                    i = 1;
                    break;
                }

                case "l":
                case "L": {
                    Console.WriteLine();
                    Console.WriteLine("You select Large Locker (15 Bath)");
                    LockerSize = "Large";
                    locker_price += 15;
                    i = 1;
                    break;
                }

                default: {
                    Console.Clear();
                    Console.WriteLine("Please input only S/M/L only");
                    Console.WriteLine();
                    ChooseSizeQuestion();
                    i = 0;
                    break;
                }
            }

        } while( i == 0 );
    }

    private void ChooseTimeQuestion() {

        Console.WriteLine("Choosing time for using locker");
        Console.WriteLine("1.) 5  mins");
        Console.WriteLine("2.) 15 mins");
        Console.WriteLine("3.) 30 mins");
        Console.WriteLine("4.) 1  hr");
        Console.WriteLine("5.) Custom time (Type your own hours and minutes)");

    }

    public void ChooseTime() {

        RestCountDown();
        ChooseTimeQuestion();

        int i = 0;

        do {

            Console.Write("(Please input number 1-5) : ");
            string choice = Console.ReadLine();

            switch(choice) {

                case "1": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '5 minutes' of using time.");
                    mins = 5;
                    i = 1;
                    break;
                }

                case "2": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '15 minutes' of using time.");
                    mins = 15;
                    i = 1;
                    break;
                }

                case "3": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '30 minutes' of using time.");
                    mins = 30;
                    i = 1;
                    break;
                }

                case "4": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '1 hour' of using time.");
                    hrs = 1;
                    i = 1;
                    break;
                }

                case "5": {
                    Console.WriteLine();
                    CustomHrs();
                    Console.WriteLine();
                    if (hrs < 24) {
                        CustomMins();
                        Console.WriteLine();
                    }
                    Console.WriteLine("You choose custom time with '{0} hours' & '{1} minutes' of using time.", hrs, mins);
                    i = 1;
                    break;
                }

                default: {
                    Console.Clear();
                    Console.WriteLine("Please input number 1-5 only.");
                    Console.WriteLine();
                    ChooseTimeQuestion();
                    i = 0;
                    break;
                }
            }

        } while ( i == 0);
    }

    public void CustomHrs() {

        int i = 0;

        do {
            
            Console.Write("Input your 'Hours' from 0-24 (if none, type '0') : ");
            int hour = int.Parse(Console.ReadLine());

            if ((hour >= 0) && (hour <=24)) {
                hrs = hour;
                i = 1;
            }

            else {

                Console.WriteLine("Please choose 0-24 hrs only");
                Console.WriteLine();
            }

        } while( i == 0 );
    }

    public void CustomMins() {

        int i = 0;

        do {
            
            Console.Write("Input your 'Minutes' from 0-59 (if none, type '0') : ");
            int min = int.Parse(Console.ReadLine());

            if ((min >= 0) && (min <=59)) {

                mins = min;
                i = 1;
            }

            else {

                Console.WriteLine("Please choose 0-59 mins only");
                Console.WriteLine();

            }

        } while( i == 0 );

    }

    public void CalculatePricefromTime() {

        int time_price_hrs = hrs * 5;
        int time_price_mins = 0;
        
        if((hrs == 0) && (mins != 0)) {

            time_price_mins += 5;
        }
        else if ((mins >= 0) && (mins <= 30)) {

            time_price_mins += 0;
        }
        else if ((mins > 30) && (mins <= 59)) {

            time_price_mins += 5;
        }

        time_price = time_price_hrs + time_price_mins;
        total_price = locker_price + time_price;
    }

    public void PrintDetail() {

        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("               Finalized Detail & Payment");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("You choose '{0}' size Locker with the price of '{1}' Bath.", LockerSize, locker_price);
        Console.WriteLine("You choose '{0} hours' & '{1} minutes' of time usage with the price of '{2}' Bath.", hrs, mins, time_price);
        Console.WriteLine();
        Console.WriteLine("Total price : {0} Bath", total_price);
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine();

    }

    private void Confirmation() {

        RestCountDown();
        PrintDetail();

        int i = 0;

        do {

            Console.Write("Do you confirm your decision and continue to payment? (Y/N) : ");
            string ans = Console.ReadLine();

            switch(ans) {

                case "y":
                case "Y": {
                    Payment();
                    ForSend.Add(hrs);
                    ForSend.Add(mins);
                    ForSend.Add(total_price);
                    i = 1;
                    break;
                }

                case "n":
                case "N": {
                    ReDecision();
                    i = 1;
                    break;
                }

                default : {
                    Console.Clear();
                    Console.WriteLine("Please input Y or N only");
                    Console.WriteLine();
                    PrintDetail();
                    i = 0;
                    break;
                }
            }
        } while(i == 0);

    }

    private void Payment() {

        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are paying the cost via cash, QR code, or whatever you prefer.)");
        Console.WriteLine("(//Assuming your payment take around 4 seconds.)");
        System.Threading.Thread.Sleep(4000);
        RestCountDown();
    }

    private void ReDecision() {

        RestCountDown();
        PrintRedicision();

        int i = 0;

        do {

            Console.Write("Type your answer (1 or 2) : ");
            string ans = Console.ReadLine();

            switch(ans) {

                case "1": {
                    LockerSize = "";
                    hrs = 0;
                    mins = 0;
                    locker_price = 0;
                    time_price = 0;
                    total_price = 0;

                    RestCountDown();
                    Runner();
                    i = 1;
                    break;
                }

                case "2": {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for try out our service.");
                    System.Environment.Exit(0);
                    i = 1;
                    break;
                }

                default : {
                    Console.Clear();
                    Console.WriteLine("Please input 1 or 2 only");
                    Console.WriteLine();
                    PrintRedicision();
                    i = 0;
                    break;
                }
            }

        } while(i == 0);
    }

    private void PrintRedicision() {

        Console.WriteLine("What do you want to do next?");
        Console.WriteLine("1.) Reselect size and time.");
        Console.WriteLine("2.) Exit program.");
        Console.WriteLine();
    }

    private void RestCountDown() {

        Console.WriteLine();
        Console.WriteLine("[ Processing. Please wait a moment... ]");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();

    }
}
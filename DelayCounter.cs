using System;
using System.Timers;

class DelayCounter {

    public void QRscan() {

        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are scaning the QR code to access the system.)");
        Console.WriteLine("(//Assuming you take around 3 seconds.)");
        System.Threading.Thread.Sleep(3000);
        RestCountDown();
    }

    public void Payment() {

        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are paying the cost via cash, QR code, or whatever you prefer.)");
        Console.WriteLine("(//Assuming your payment take around 3 seconds.)");
        System.Threading.Thread.Sleep(3000);
        RestCountDown();
    }

    public void RestCountDown() {

        Console.WriteLine();
        Console.WriteLine("[ Processing. Please wait a moment... ]");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();

    }
}
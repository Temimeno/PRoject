using System;

public class Locker {

    string[] smallLocker = new [] {"S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8"};
    string[] mediumLocker = new [] {"M1", "M2", "M3", "M4"};
    string[] largeLocker = new [] {"L1", "L2"};

    public void pickSmall() {
        
        Random random = new Random();
        int index = random.Next(smallLocker.Length);

        Console.WriteLine("Please put your stuff in locker '{0}'.", smallLocker[index]);
        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are putting your stuff inside the locker and closing it.)");
        Console.WriteLine("(//Assuming you take around 3 seconds.)");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
    }

    public void pickMedium() {
        
        Random random = new Random();
        int index = random.Next(mediumLocker.Length);

        Console.WriteLine("Please put your stuff in locker '{0}'.", mediumLocker[index]);
        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are putting your stuff inside the locker and closing it.)");
        Console.WriteLine("(//Assuming you take around 3 seconds.)");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
    }

    public void pickLarge() {
        
        Random random = new Random();
        int index = random.Next(largeLocker.Length);

        Console.WriteLine("Please put your stuff in locker '{0}'.", largeLocker[index]);
        Console.WriteLine();
        Console.WriteLine("(//Assumimg you are putting your stuff inside the locker and closing it.)");
        Console.WriteLine("(//Assuming you take around 3 seconds.)");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
    }
}
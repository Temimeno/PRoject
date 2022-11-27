public class Timer {
    static void Main(string[] args) {

        int mins = 1;
        int second = 10;
        int hour = 0;

        var d = new DateTime(2000, 1, 1, hour, mins, second);

            for (int i = 0; i <= ((hour * 3600) + (mins * 60) + second); i++ )
            {                
                Console.Write(d.ToString("HH:mm:ss"));
                d = d.AddSeconds(-1);
                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }

        Console.WriteLine("Finish");
        Console.WriteLine("(Press Any Button to Continue)");
        Console.ReadLine();
    }
}
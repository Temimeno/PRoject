public class Timer {
    static void Main(string[] args) {

        int a = 10;

        for (int i = a; i >= 0; i--) {

            Console.Clear();
            Console.Write("Timeleft : {0} ", i);  // Override complete previous contents
            System.Threading.Thread.Sleep(1000);

        }

        Console.WriteLine();
        Console.WriteLine("Finish");

        /*
        var mins = 1;

        var d = new DateTime(2000, 1, 1, 0, mins, 0);

            for (int i = 0; i <= mins * 60; i++ )
            {                
                Console.Write(d.ToString("hh:mm:ss"));
                d = d.AddSeconds(-1);
                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }
        */
    }
}
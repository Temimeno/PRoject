using System;
using System.Timers;

public class Program{

    enum SelectMenuChoice{
        RegisterMenu = 1, LoginMenu =2
    }
    static Memberlist memberlist;
    public static void Prepare(){
        
        Console.Clear();
        Program.memberlist = new Memberlist();
    }

    static void Main(string[] args){
        
        Prepare(); //เตรียม memberlist 
        //โชว์เมนูหลัก
        ShowTextMenu();
    }
    ///////////////////////////////////       Main Menu      /////////////////////////////////////////////
    static void ShowTextMenu(){
        Console.WriteLine("______________________________________");
        Console.WriteLine();
        Console.WriteLine("      Welcome AppLockerMitchacheep    ");
        Console.WriteLine("______________________________________");
        Console.WriteLine("      1).Register Menu          ");
        Console.WriteLine("      2).Login    Menu   ");
        //Go to Select Menu
        SelectMenu();
         
    }
    //พิมพ์เลขเพื่อไปหน้าเมนู
    static void SelectMenu(){
        Console.Write("Please Select Menu Following Number : ");
        SelectMenuChoice selectMenuChoice =(SelectMenuChoice) int.Parse(Console.ReadLine());
        //Switch Console From Number
        SwitchPage(selectMenuChoice);
    }
    ///ไปหน้าเมนู
    static void SwitchPage(SelectMenuChoice selectMenuChoice){
        switch(selectMenuChoice){
            case SelectMenuChoice.RegisterMenu:
            RegisterScreen();
            break;
            case SelectMenuChoice.LoginMenu:
            Loginscreen();
            break;
        }
    }
 
    enum SelectRole{
        Collgain = 1,Teacher = 2
    }
    public static void RegisterScreen(){
        Console.Clear();
        Console.WriteLine("______________________________________");
        Console.WriteLine();
        Console.WriteLine("      Welcome RegisterMenu            ");
        Console.WriteLine("______________________________________");
        Console.WriteLine("      1).Collgain          ");
        Console.WriteLine("      2).Teacher           ");
        //ไปMethod พิมพ์เลข
        GetRole();
    }
    ////Login///
    static void Loginscreen(){

        InputDetail inputDetail = new InputDetail();
        DelayCounter delayCounter = new DelayCounter();

        Console.Clear();
        Console.WriteLine("______________________________________");
        Console.WriteLine();
        Console.WriteLine("      Welcome LoginMenu           ");
        Console.WriteLine("______________________________________");
        Console.Write("Please Input Your Id : ");
         string id = Console.ReadLine();
        Console.Write("Please Input Your Password : ");
        string password  = Console.ReadLine();
        if(memberlist.Logininspect(id,password)==true){
            Console.Clear();
            Console.WriteLine("Login SuccessFully");
            
            delayCounter.QRscan();
            inputDetail.RunnerInput();

            //ShowTextMenu();
        }
        else if(memberlist.Logininspect(id,password)== false){
            Console.Clear();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine("  Wrong ID Or Passwoord Or Not Register  ");
            Console.WriteLine("  Please Login again        ");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("  Press Any Key....To Continue ");
            Console.ReadLine();
            Console.Clear();
            ShowTextMenu();
        }
        
    }
    public static void GetRole(){
         Console.Write("Please Select Menu Following Number : ");
        SelectRole selectRole =( SelectRole) int.Parse(Console.ReadLine());
        //Switch Console From Number
        SwitchPageRole(selectRole);
    }
    //เปลี่ยนหน้าไปเมนู สมัครนักศึกาา กับ อาจารย์
    static void SwitchPageRole(SelectRole selectRole){
        switch(selectRole){
            case SelectRole.Collgain:
            RegisterCollgain();
            break;
            case SelectRole.Teacher:
            RegisterTeacher();
            break;
            
    }
    }
    static void RegisterCollgain(){

        DelayCounter delayCounter = new DelayCounter();

        Console.Clear();
        string id = TypeID();
        string Password  = TypePassword();
        Collgain collgain = new Collgain(TypeName(),TypeLastname(),id,Password);
        bool checkmem = memberlist.CheckRole(id,Password);
        if(checkmem == true)
        {
            Program.memberlist.MemberAdd(collgain);
            delayCounter.RestCountDown();
            ShowTextMenu();
        }
        
        else if(checkmem == false){
            Console.Clear();
            Console.WriteLine("_______________________________");
            Console.WriteLine();
            Console.WriteLine("  This user id has been used   ");
            Console.WriteLine("  Please Register again        ");
            Console.WriteLine("_______________________________");
            Console.WriteLine("  Press Any Key....To Continue ");
            Console.ReadLine();
            RegisterCollgain();
        }
      
    }
     static void RegisterTeacher(){

        DelayCounter delayCounter = new DelayCounter();

        Console.Clear();
        string id = TypeIdTeacher();
        string Password  = TypePassword();
        Teacher teacher = new Teacher(TypeName(),TypeLastname(),id,Password);
        bool checkmem = memberlist.CheckRole(id,Password);
        if(checkmem == true)
        {
            Program.memberlist.MemberAdd(teacher);
            delayCounter.RestCountDown();
            ShowTextMenu();
        }
        
        else if(checkmem == false){
            Console.Clear();
            Console.WriteLine("_______________________________");
            Console.WriteLine();
            Console.WriteLine("  This user id has been used   ");
            Console.WriteLine("  Please Register again        ");
            Console.WriteLine("_______________________________");
            Console.WriteLine("  Press Any Key....To Continue ");
            Console.ReadLine();
            RegisterTeacher();
        }
    
    }
    
     static string TypeName()
    {
        Console.Write("please input your firstname : ");
        return Console.ReadLine();
    }
     static string TypeLastname()
    {
        Console.Write("please input your lastame : ");
        return Console.ReadLine();
    }
   static string TypeID()
    {
        Console.Write("please input your ID : ");
        return Console.ReadLine();
    }
     static string TypePassword()
    {
        Console.Write("please input your Password : ");
        return Console.ReadLine();
    }
    static string TypeIdTeacher(){
         Console.Write("please input your Teacher ID : ");
        return Console.ReadLine();
    }

     static void BackToMenu(){
        Console.Clear();
        ShowTextMenu();
    }



    ///////////////////////////////////       Input Detail      /////////////////////////////////////////////



    string LockerSize = "";
    int hrs_select = 0;
    int mins_selcet = 0;
    int locker_price = 0;
    int time_price = 0;
    int total_price = 0;
    //ใช้เป็น Global Variable ทุกๆ Method จะได้ดึงไปใช้ได้

    public void RunnerInputFromProgram() {    

        ChooseSize();
        ChooseTime();
        CalculatePricefromTime();
        Confirmation();

    }

    public void ChooseSize() {

        InputDetail inputDetail = new InputDetail();

        inputDetail.ChooseSizeQuestion();

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
                    inputDetail.ChooseSizeQuestion();
                    i = 0;
                    break;
                }
            }

        } while( i == 0 );
    }

    public void ChooseTime() {

        InputDetail inputDetail = new InputDetail();
        DelayCounter delayCounter = new DelayCounter();

        delayCounter.RestCountDown();
        inputDetail.ChooseTimeQuestion();

        int i = 0;

        do {

            Console.Write("(Please input number 1-5) : ");
            string choice = Console.ReadLine();

            switch(choice) {

                case "1": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '5 minutes' of using time.");
                    mins_selcet = 5;
                    i = 1;
                    break;
                }

                case "2": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '15 minutes' of using time.");
                    mins_selcet = 15;
                    i = 1;
                    break;
                }

                case "3": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '30 minutes' of using time.");
                    mins_selcet = 30;
                    i = 1;
                    break;
                }

                case "4": {
                    Console.WriteLine();
                    Console.WriteLine("You choose '1 hour' of using time.");
                    hrs_select = 1;
                    i = 1;
                    break;
                }

                case "5": {
                    Console.WriteLine();
                    CustomHrs();
                    Console.WriteLine();
                    if (hrs_select < 24) {
                        CustomMins();
                        Console.WriteLine();
                    }
                    Console.WriteLine("You choose custom time with '{0} hours' & '{1} minutes' of using time.", hrs_select, mins_selcet);
                    i = 1;
                    break;
                }

                default: {
                    Console.Clear();
                    Console.WriteLine("Please input number 1-5 only.");
                    Console.WriteLine();
                    inputDetail.ChooseTimeQuestion();
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
                hrs_select = hour;
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

                mins_selcet = min;
                i = 1;
            }

            else {

                Console.WriteLine("Please choose 0-59 mins only");
                Console.WriteLine();

            }

        } while( i == 0 );

    }

    public void CalculatePricefromTime() {

        int time_price_hrs = hrs_select * 5;
        int time_price_mins = 0;
        
        if((hrs_select == 0) && (mins_selcet != 0)) {

            time_price_mins += 5;
        }
        else if ((mins_selcet >= 0) && (mins_selcet <= 30)) {

            time_price_mins += 0;
        }
        else if ((mins_selcet > 30) && (mins_selcet <= 59)) {

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
        Console.WriteLine("You choose '{0} hours' & '{1} minutes' of time usage with the price of '{2}' Bath.", hrs_select, mins_selcet, time_price);
        Console.WriteLine();
        Console.WriteLine("Total price : {0} Bath", total_price);
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine();

    }

    public void Confirmation() {

        InputDetail inputDetail = new InputDetail();
        DelayCounter delayCounter = new DelayCounter();

        delayCounter.RestCountDown();
        PrintDetail();

        int i = 0;

        do {

            Console.Write("Do you confirm your decision and continue to payment? (Y/N) : ");
            string ans = Console.ReadLine();

            switch(ans) {

                case "y":
                case "Y": {
                    delayCounter.Payment();
                    chooseLocker(LockerSize);
                    RunnerTimer();
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

    public void ReDecision() {

        InputDetail inputDetail = new InputDetail();
        DelayCounter delayCounter = new DelayCounter();

        delayCounter.RestCountDown();
        inputDetail.PrintRedicision();

        int i = 0;

        do {

            Console.Write("Type your answer (1 or 2) : ");
            string ans = Console.ReadLine();

            switch(ans) {

                case "1": {
                    LockerSize = "";
                    hrs_select = 0;
                    mins_selcet = 0;
                    locker_price = 0;
                    time_price = 0;
                    total_price = 0;

                    delayCounter.RestCountDown();
                    inputDetail.RunnerInput();
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
                    inputDetail.PrintRedicision();
                    i = 0;
                    break;
                }
            }

        } while(i == 0);
    }

    public void chooseLocker(string size) {

        Locker locker = new Locker();

        if(size == "Small") {

            locker.pickSmall();
        }

        if(size == "Medium") {

            locker.pickMedium();
        }

        if(size == "Large") {

            locker.pickLarge();
        }
    }



    ///////////////////////////////////       Timer      /////////////////////////////////////////////



    public System.Timers.Timer aTimer;

    public int overtime_count = 0;
    public int second = 0;
    public int hour = 0;
    public int mins = 0;
    public int Penalty_price = 0;

    public void RunnerTimer() {

        TimeChecker timeChecker = new TimeChecker();

        hour = hrs_select;
        mins = mins_selcet;
        Penalty_price = total_price;

        SetCountdownTimer();

        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();
      
        Console.WriteLine("Timer has Stop...");
        
        timeChecker.OvertimeChecker(overtime_count, Penalty_price);

   }

    public void SetCountdownTimer() {
    
        Program program = new Program();
        
        aTimer = new System.Timers.Timer(1000);
        aTimer.Elapsed += CountDown;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;

    }

    public void CountDown(Object source, ElapsedEventArgs e) {

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

        for (int j = 0; j <= 600 ; j++) {

            Console.WriteLine("OverTime");
            Console.WriteLine(up.ToString("HH:mm:ss"));
            Console.WriteLine("(Press Enter Key to Stop Timer...)");
            up = up.AddSeconds(+1);
            System.Threading.Thread.Sleep(10);

            overtime_count = 1;

            Console.Clear();

        }

        Console.WriteLine("This locker exceed usage limit.");
        Console.WriteLine("Please contact admin to get stuff out of locker.");
        System.Environment.Exit(0);
    }
}
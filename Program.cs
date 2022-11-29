class Program{
    enum SelectMenuChoice{
        RegisterMenu = 1, LoginMenu =2
    }
    static Memberlist memberlist;
    public static void Prepare(){
        Program.memberlist = new Memberlist();
    }

    static void Main(string[] args){
        
        Prepare();
        //โชว์เมนูหลัก
        ShowTextMenu();
    }
    ////////////////////////////       Main Menu   /////////////////////////////////////////////
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
    public static void Loginscreen(){
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
            Console.WriteLine("Login SuccessFully");//ใส่รหัสถูกแล้วจะไปที่ไหนก็ได้
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
        Console.Clear();
        //string name = TypeName();
        // string lastname = TypeLastname();
        string id = TypeID();
        string Password  = TypePassword();
        Collgain collgain = new Collgain(TypeName(),TypeLastname(),id,Password);
        //Collgain collgain = new Collgain(name,lastname,TypeID(),TypePassword());
        bool checkmem = memberlist.CheckRole(id,Password);
        if(checkmem == true)
        {
            Program.memberlist.MemberAdd(collgain);
            Console.Clear();
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
        Console.Clear();
        //string name = TypeName();
        // string lastname = TypeLastname();
        string id = TypeIdTeacher();
        string Password  = TypePassword();
        Teacher teacher = new Teacher(TypeName(),TypeLastname(),id,Password);
        bool checkmem = memberlist.CheckRole(id,Password);
        if(checkmem == true)
        {
            Program.memberlist.MemberAdd(teacher);
            Console.Clear();
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
    

}
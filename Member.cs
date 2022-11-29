public class Member{
    
    string FirstName;
    string Lastname;
    string Password;
     public Member(string FirstName,string Lastname,string Password)
    {
        this.FirstName= FirstName;
        this.Lastname = Lastname;
        this.Password = Password;
    }

    public string GetFirstName(){
        return this.FirstName;
    }
    public string GetLastName(){
        return this.Lastname;
    }
     public string GetPassword(){
        return  this.Password;
    }
}
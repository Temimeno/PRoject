using System;
class Collgain:Member
{
    string UsernameCollgain;
    public Collgain(string FirstName,string Lastname,string UsernameCollgain,string Password)
    :base(FirstName,Lastname,Password)
    {
        this.UsernameCollgain= UsernameCollgain;
    }
    public string GetUserName()
    {
        return this.UsernameCollgain;
    }
    
}
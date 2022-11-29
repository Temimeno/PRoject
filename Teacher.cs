using System;
class Teacher:Member
{
    string UsernameTeacher;
    public Teacher(string FirstName,string Lastname,string UsernameTeacher,string Password)
    :base(FirstName,Lastname,Password)
    {
        this.UsernameTeacher = UsernameTeacher;
    }
    public string GetUserNameTeacher()
    {
        return this.UsernameTeacher;
    }
    
}
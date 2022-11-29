using System.Collections.Generic;
class Memberlist{
    private List<Member> memberlist;
    public Memberlist()
    {
        this.memberlist = new List<Member>();
    }
    public void MemberAdd(Member member)
    {
       this.memberlist.Add(member);
    }
      public bool CheckRole(string Username , string Password)
   {
     {
        foreach(Member member in memberlist)
        {
            if(member is Collgain collgain)
              {
                if(collgain.GetUserName().Equals(Username)&&collgain.GetPassword().Equals(Password))
                {
                    return false;
                }
              }
            else if(member is Teacher teacher){
              if(teacher.GetUserNameTeacher().Equals(Username)&&teacher.GetPassword().Equals(Password)){
                return false;
              }
            }
        }
     }
      return true ;
   }
  public bool Logininspect(string username,string password){
    if(memberlist.Count > 0){
      foreach(Member member in memberlist)
      {
        if(member is Collgain collgain){
          if(username.Equals(collgain.GetUserName())&&password.Equals(collgain.GetPassword())){
            return true;
          }
        }
        else if(member is Teacher teacher)
        {
          if(username.Equals(teacher.GetUserNameTeacher())&&password.Equals(teacher.GetPassword())){
            return true;
          }
        }
      }
    }
    else if(memberlist.Count==0){
      return false;
    }
      
    
    return false;
  }
}
using System;
namespace BCModel
{
    public class Achievement
    {
        public int Id{get;set;}
        public int UserId {get;set;} 
        public string Badge {get;set;} 


    public   Achievement(string badge,int userid ){
        this.UserId=userid;
        this.Badge=badge;
        }
    }
}
using System;
namespace BCModel
{
    public class Achievement
    {
        public Achievement()
        {
        }
        public Achievement(string badge, string userid)
        {
            this.Email = userid;
            this.Badge = badge;
        }

        public Achievement(int id, string badge, string userid)
        {
            Id = id;
            this.Email = userid;
            this.Badge = badge;
        }

        public int Id{get;set;}
        public string Email {get;set;} 
        public string Badge {get;set;} 
    }
}
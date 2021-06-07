using System;
namespace BCModel
{
    public class Achievement
    {
        public Achievement()
        {
        }
        public Achievement(string badge, User userid)
        {
            this.User = userid;
            this.Badge = badge;
        }

        public Achievement(int id, string badge, User userid)
        {
            Id = id;
            this.User = userid;
            this.Badge = badge;
        }

        public int Id{get;set;}
        public User User {get;set;} 
        public string Badge {get;set;} 
    }
}
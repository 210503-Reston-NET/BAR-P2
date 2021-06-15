using System;
namespace BCModel
{
    public class Achievement
    {
        public Achievement()
        {
        }
        public Achievement(string badge, string userEmail)
        {
            this.UserEmail = userEmail;
            this.Badge = badge;
        }

        public Achievement(int achievementId, string badge, string userEmail)
        {
            AchievementId = achievementId;
            this.UserEmail = userEmail;
            this.Badge = badge;
        }

        public int AchievementId{get;set;}
        public string UserEmail {get;set;} 
        public string Badge {get;set;} 
    }
}
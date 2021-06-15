using System;
namespace BCModel
{
    public class User
    {
        public User()
        {
        }

        public User(string userEmail, string password, string address, int pagesRead)
        {
            this.UserEmail = userEmail;
            this.Password = password;
            this.Address = address;
            this.PagesRead = pagesRead;
        }

        public string UserEmail {get;set;}
        public string Password {get;set;}
        public string Address {get;set;}
        public int PagesRead { get; set; }
    }
}
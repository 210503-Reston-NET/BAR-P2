using System;
namespace BCModel
{
    public class User
    {
        public User()
        {
        }

        public User(string email, string password, string address, int pagesRead)
        {
            this.Email = email;
            this.Password = password;
            this.Address = address;
            this.PagesRead = pagesRead;
        }

        public string Email {get;set;}
        public string Password {get;set;}
        public string Address {get;set;}
        public int PagesRead { get; set; }
    }
}
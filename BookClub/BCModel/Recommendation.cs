using System;
using System.Collections.Generic;
namespace BCModel
{
    public class Recommendation
    {
        public Recommendation() { }

        public Recommendation(User user, Book book, string message, User receversEmail )
        {
            User = user;
            Book = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public Recommendation(int id, User user, Book book, string message, User receversEmail)
        {
            Id = id;
            User = user;
            Book = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public int Id{get;set;}
        public User User {get;set;}
        public Book Book {get;set;}
        public string Message {get;set;}
        public User ReceversEmails {get;set;}
        
    }
}
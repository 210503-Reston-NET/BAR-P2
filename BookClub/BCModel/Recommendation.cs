using System;
using System.Collections.Generic;
namespace BCModel
{
    public class Recommendation
    {
        public Recommendation() { }

        public Recommendation(User user, Book book, string message, List<string> receversEmail )
        {
            UserId = user;
            BookId = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public Recommendation(int id, User user, Book book, string message, List<string> receversEmail)
        {
            Id = id;
            UserId = user;
            BookId = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public int Id{get;set;}
        public User UserId {get;set;}
        public Book BookId {get;set;}
        public string Message {get;set;}
        public List<string> ReceversEmails {get;set;}
        
    }
}
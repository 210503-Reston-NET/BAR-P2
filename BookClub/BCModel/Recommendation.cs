using System;
using System.Collections.Generic;
namespace BCModel
{
    public class Recommendation
    {
        public Recommendation() { }

        public Recommendation(string user, string book, string message, string receversEmail )
        {
            SenderEmail = user;
            ISBN = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public Recommendation(int id, string user, string book, string message, string receversEmail)
        {
            Id = id;
            SenderEmail = user;
            ISBN = book;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public int Id{get;set;}
        public string SenderEmail {get;set;}
        public string ISBN {get;set;}
        public string Message {get;set;}
        public string ReceversEmails {get;set;}
        
    }
}
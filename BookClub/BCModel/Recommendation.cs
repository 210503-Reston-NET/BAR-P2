using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCModel
{
    public class Recommendation
    {
        public Recommendation() { }

        public Recommendation(string userEmail, string isbn, string message, string receversEmail )
        {
            UserEmail = userEmail;
            ISBN = isbn;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public Recommendation(int recommendationId, string userEmail, string isbn, string message, string receversEmail)
        {
            RecommendationId = recommendationId;
            UserEmail = userEmail;
            ISBN = isbn;
            Message = message;
            ReceversEmails = receversEmail;
        }

        public int RecommendationId{get;set;}
        [ForeignKey("User")]
        public string UserEmail {get;set;}
        public User User { get; set; }
        [ForeignKey("Book")]
        public string ISBN {get;set;}
        public Book Book { get; set; }
        public string Message {get;set;}
        public string ReceversEmails {get;set;}
        
    }
}
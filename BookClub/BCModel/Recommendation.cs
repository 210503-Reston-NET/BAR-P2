using System;
using System.Collections.Generic;
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
        public string UserEmail {get;set;}
        public string ISBN {get;set;}
        public string Message {get;set;}
        public string ReceversEmails {get;set;}
        
    }
}
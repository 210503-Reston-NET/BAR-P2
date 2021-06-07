using System;
namespace BCModel
{
    public class Recommendation
    {
        public int Id{get;set;}
        public int UserId {get;set;}
        public int BookId {get;set;}
        public string Message {get;set;}
        public List<string> ReceversEmails {get;set;}
        public Recommendation(){}
    }
}
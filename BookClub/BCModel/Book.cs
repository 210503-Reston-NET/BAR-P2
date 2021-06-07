using System;

namespace BCModel
{
    public class Book
    {
        public int Id {get;set;}
        public string ISBN {get;set;}
        public string Title {get;set;}
        public string Author {get;set;}
        public int CategoryId {get;set;}

        public Book(string isbn,strint title,string author,int categoryId){
            this.ISBN=isbn;
            this.Title=title;
            this.Author=author;
            this.CategoryId=categoryId;
        }

         public Book(int id, string isbn,strint title,string author,int categoryId):this(isbn,title, author,categoryId){
            this.ISBN=isbn;
            this.Title=title;
            this.Author=author;
            this.CategoryId=categoryId;
            this.Id=id;
        }
        
        

    }
}

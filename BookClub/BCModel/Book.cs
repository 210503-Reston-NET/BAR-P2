using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCModel
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string isbn, string title, string author, string categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.CategoryId = categoryId;
        }

        public Book(string isbn, string title, string author, string categoryId, string imageUrl) : this(isbn, title, author, categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.CategoryId = categoryId;
            this.ImageUrl = imageUrl;
        }

        public string ISBN {get;set;}
        public string Title {get;set;}
        public string Author {get;set;}
        [ForeignKey("Category")]
        public string CategoryId {get;set;}
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
        public List<BookClub> BookClubs { get; set; }
        public List<BooksRead> BooksReads { get; set; }
        public List<BooksToRead> BooksToReads { get; set; }
        public List<FavoriteBook> FavoriteBooks { get; set; }
        public List<Recommendation> Recommendations { get; set; }
    }
}

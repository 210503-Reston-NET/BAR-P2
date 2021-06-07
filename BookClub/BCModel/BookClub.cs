﻿using System;

namespace BCModel
{
    public class BookClub
    {
        public BookClub()
        {
        }

        public BookClub(string name, string description, Book bookId, User user)
        {
            this.Name = name;
            this.Description = description;
            this.Book = bookId;
            this.User = user;
        }

        public BookClub(int Id, string name, string description, Book bookId, User user) : this(name, description, bookId, user)
        {
            this.Name = name;
            this.Description = description;
            this.Book = bookId;
            this.Id = Id;
            this.User = user;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        
        public Book Book { get; set; }
    }
}

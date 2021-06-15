using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCModel
{
    public class BookClub
    {
        public BookClub()
        {
        }

        public BookClub(string name, string description, string isbn, string userEmail)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = isbn;
            this.UserEmail = userEmail;
        }

        public BookClub(int bookClubId, string name, string description, string isbn, string userEmail) : this(name, description, isbn, userEmail)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = isbn;
            this.BookClubId = bookClubId;
            this.UserEmail = userEmail;
        }

        public int BookClubId { get; set; }
        public string Name { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        [ForeignKey("Book")]
        public string ISBN { get; set; }
        public Book Book { get; set; }
        public List<FollowClub> FollowClubs { get; set; }
        public List<ClubPost> ClubPosts { get; set; }
    }
}

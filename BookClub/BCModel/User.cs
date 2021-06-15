using System;
using System.Collections.Generic;

namespace BCModel
{
    public class User
    {
        public User()
        {
        }

        public User(string userEmail, string password, string address, int pagesRead)
        {
            this.UserEmail = userEmail;
            this.Password = password;
            this.Address = address;
            this.PagesRead = pagesRead;
        }

        public string UserEmail {get;set;}
        public string Password {get;set;}
        public string Address {get;set;}
        public int PagesRead { get; set; }
        public List<Achievement>  Achievements{ get; set; }
        public List<BookClub> BookClub { get; set; }
        public List<BooksRead> BooksReads { get; set; }
        public List<BooksToRead> BooksToReads { get; set; }
        public List<ClubPost> ClubPosts { get; set; }
        public List<ClubPostLikes> ClubPostLikes { get; set; }
        public List<Comment> Comments { get; set; }
        public List<CommentLikes> CommentLikes { get; set; }
        public List<FavoriteBook> FavoriteBooks { get; set; }
        public List<FollowUser> FollowUsers { get; set; }
        public List<Recommendation> Recommendations { get; set; }
        public List<UserPost> UserPosts { get; set; }
        public List<UserPostLikes> UserPostLikes { get; set; }
    }
}
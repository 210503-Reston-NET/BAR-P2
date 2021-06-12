﻿using System;
using Xunit;
using BCModel;

namespace BCTest
{
    public class ModelsTest
    {
        [Fact]
        public void BookShouldSetValidData()
        {
            Book test = new Book("ISBN", "Title", "Author", "Category");
            string title = "Harry Potter";
            test.Title = title;
            Assert.Equal(title, test.Title);
        }

        [Fact]
        public void BookClubShouldSetValidData()
        {
            BookClub test = new BookClub("name", "description", "bookId", "user");
            string user = "bryce.zimbelman@revature.net";
            test.Email = user;
            Assert.Equal(user, test.Email);
        }

        [Fact]
        public void BookReadShouldSetValidData()
        {
            BooksRead test = new BooksRead("userid", "bookId");
            string user = "bryce.zimbelman@revature.net";
            test.User = user;
            Assert.Equal(user, test.User);
        }

        [Fact]
        public void BooksToReadShouldSetValidData()
        {
            BooksToRead test = new BooksToRead("userid", "bookId");
            string bookId = "123456789";
            test.ISBN = bookId;
            Assert.Equal(bookId, test.ISBN);
        }

        [Fact]
        public void CategoryShouldSetValidData()
        {
            Category test = new Category("name");
            string name = "horror";
            test.Name = name;
            Assert.Equal(name, test.Name);
        }

        [Fact]
        public void ClubPostShouldSetValidData()
        {
            ClubPost test = new ClubPost("user", "post", 1, 1, 1);
            int likes = 50;
            test.TotalLike = likes;
            Assert.Equal(likes, test.TotalLike);
        }

        [Fact]
        public void CommentShouldSetValidData()
        {
            Comment test = new Comment("user", 1, 1, "message");
            string user = "bryce.zimbelman@revature.net";
            test.Email = user;
            Assert.Equal(user, test.Email);
        }

        [Fact]
        public void FavoriteBookShouldSetValidData()
        {
            FavoriteBook test = new FavoriteBook("userId", "bookId");
            string bookId = "987654321";
            test.ISBN = bookId;
            Assert.Equal(bookId, test.ISBN);
        }

        [Fact]
        public void FollowClubShouldSetValidData()
        {
            FollowClub test = new FollowClub("follower", 1);
            string follower = "bryce.zimbelman@icloud.com";
            test.FollowerEmail = follower;
            Assert.Equal(follower, test.FollowerEmail);
        }

        [Fact]
        public void FollowUserShouldSetValidData()
        {
            FollowUser test = new FollowUser("follower", "followed");
            string follower = "bryce.zimbelman@icloud.com";
            test.FollowerEmail = follower;
            Assert.Equal(follower, test.FollowerEmail);
        }

        [Fact]
        public void UserShouldSetValidData()
        {
            User test = new User("email", "password", "address", 1);
            int pagesRead = 5000;
            test.PagesRead = pagesRead;
            Assert.Equal(pagesRead, test.PagesRead);
        }

        [Fact]
        public void UserPostShouldSetValidData()
        {
            UserPost test = new UserPost("user", "post", 1, 1);
            int dislikes = 13;
            test.TotalDislike = dislikes;
            Assert.Equal(dislikes, test.TotalDislike);
        }
    }
}
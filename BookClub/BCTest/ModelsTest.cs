using System;
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
            test.UserEmail = user;
            Assert.Equal(user, test.UserEmail);
        }

        [Fact]
        public void BookReadShouldSetValidData()
        {
            BooksRead test = new BooksRead("userid", "bookId", 0);
            string user = "bryce.zimbelman@revature.net";
            test.UserEmail = user;
            Assert.Equal(user, test.UserEmail);
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
            test.CategoryId = name;
            Assert.Equal(name, test.CategoryId);
        }

        [Fact]
        public void ClubPostShouldSetValidData()
        {
            ClubPost test = new ClubPost("user", "post", 1, 1, 1, new DateTime());
            int likes = 50;
            test.TotalLike = likes;
            Assert.Equal(likes, test.TotalLike);
        }

        [Fact]
        public void UserCommentShouldSetValidData()
        {
            UserComment test = new UserComment("user", 1, "message");
            string user = "bryce.zimbelman@revature.net";
            test.UserEmail = user;
            Assert.Equal(user, test.UserEmail);
        }

        [Fact]
        public void ClubCommentShouldSetValidData()
        {
            ClubComment test = new ClubComment("user", 1, "message");
            string user = "bryce.zimbelman@revature.net";
            test.UserEmail = user;
            Assert.Equal(user, test.UserEmail);
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
            UserPost test = new UserPost("user", "post", 1, 1, new DateTime());
            int dislikes = 13;
            test.TotalDislike = dislikes;
            Assert.Equal(dislikes, test.TotalDislike);
        }

        [Fact]
        public void ClubPostLikesShouldSetValidData()
        {
            ClubPostLikes test = new ClubPostLikes(true, false, 1, "bryce.zimbelman@revature.net");
            bool like = true;
            test.Like = like;
            Assert.Equal(like, test.Like);
        }

        [Fact]
        public void UserPostLikesShouldSetValidData()
        {
            ClubPostLikes test = new ClubPostLikes(false, true, 1, "bryce.zimbelman@revature.net");
            bool dislike = true;
            test.Dislike = dislike;
            Assert.Equal(dislike, test.Dislike);
        }

        [Fact]
        public void UserCommentLikesShouldSetValidData()
        {
            UserCommentLikes test = new UserCommentLikes(true, false, 1, "bryce.zimbelman@revature.net", 1);
            bool dislike = false;
            test.Dislike = dislike;
            Assert.Equal(dislike, test.Dislike);
        }

        [Fact]
        public void ClubCommentLikesShouldSetValidData()
        {
            ClubCommentLikes test = new ClubCommentLikes(true, false, 1, "bryce.zimbelman@revature.net", 1);
            bool dislike = false;
            test.Dislike = dislike;
            Assert.Equal(dislike, test.Dislike);
        }

        [Fact]
        public void UserFeedShouldSetValidData()
        {
            UserFeed test = new UserFeed("post", "email", "bookclub", 1, 1, 1, 5, 100, new DateTime());
            string post = "post";
            test.Post = post;
            Assert.Equal(post, test.Post);
        }
    }
}
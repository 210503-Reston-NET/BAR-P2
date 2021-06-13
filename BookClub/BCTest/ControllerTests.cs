using System;
using Microsoft.AspNetCore.Mvc;
using Moq;
using BCBL;
using BCModel;
using BCWebUI.Controllers;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Http;

namespace BCTest
{
    public class ControllerTests
    {
        [Fact]
        public void BookControllerShouldReturnList()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetAllBooks()).Returns(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BookController(mockBL.Object);
            var result = controller.GetAllBooks();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookControllerShouldReturnBook()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByISBN("123456789")).Returns(new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"));

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByISBN("123456789");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Book>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookControllerShouldReturnBookByTitle()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByTitle("Harry Potter")).Returns(new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"));

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByTitle("Harry Potter");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Book>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookControllerShouldReturnBookByAuthor()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByAuthor("JK Rowling")).Returns(
                new List<Book>
                {
                new Book("135798642", "Harry Potter 2", "JK Rowling", "Fantasy"),
                new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy")
                });

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByAuthor("JK Rowling");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookClubControllerShouldReturnList()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetAllBookClubs()).Returns(
                new List<BookClub>
                {
                    new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"),
                    new BookClub("Hunger Games", "Hungry Reads", "987654321", "bryce.zimbelman@revature.net")
                }
                );

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetAllBookClubs();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookClubControllerShouldReturnBookClub()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetBookClubById(1)).Returns(new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"));

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetBookClubById(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<BookClub>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BookClubControllerShouldReturnBookClubByBook()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetBookClubByBook("123456789")).Returns(
                new List<BookClub>
                {
                new BookClub("Harry Potter 2", "Ok Reads", "123456789", "bryce.zimbelman@icloud.com"),
                new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net")
                });

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetBookClubByBook("123456789");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BooksReadControllerShouldReturnList()
        {
            var mockBL = new Mock<IBooksReadBL>();
            mockBL.Setup(x => x.GetAllBooksRead()).Returns(
                new List<BooksRead>
                {
                    new BooksRead("bryce.zimbelman@revature.net", "123456789", 50),
                    new BooksRead("bryce.zimbelman@revature.net", "987654321", 50)
                }
                );

            var controller = new BooksReadController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BooksRead>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BooksReadControllerShouldReturnBooks()
        {
            var mockBL = new Mock<IBooksReadBL>();
            mockBL.Setup(x => x.GetBooksReadByUser("bryce.zimbelman@revature.net")).Returns(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BooksReadController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@revature.net");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BooksToReadControllerShouldReturnList()
        {
            var mockBL = new Mock<IBooksToReadBL>();
            mockBL.Setup(x => x.GetAllBooksRead()).Returns(
                new List<BooksToRead>
                {
                    new BooksToRead("bryce.zimbelman@revature.net", "123456789"),
                    new BooksToRead("bryce.zimbelman@revature.net", "987654321")
                }
                );

            var controller = new BookToReadController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BooksToRead>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void BooksToReadControllerShouldReturnBooks()
        {
            var mockBL = new Mock<IBooksToReadBL>();
            mockBL.Setup(x => x.GetBooksReadByUser("bryce.zimbelman@revature.net")).Returns(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BookToReadController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@revature.net");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CategoryControllerShouldReturnList()
        {
            var mockBL = new Mock<ICategoryBL>();
            mockBL.Setup(x => x.GetAllCategories()).Returns(
                new List<Category>
                {
                    new Category("Horor"),
                    new Category("Adventure")
                }
                );

            var controller = new CategoryController(mockBL.Object);
            var result = controller.GetAllCategories();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Category>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CategoryControllerShouldReturnCategory()
        {
            var mockBL = new Mock<ICategoryBL>();
            mockBL.Setup(x => x.GetCategory("horror")).Returns(
                new Category("horror")
                );

            var controller = new CategoryController(mockBL.Object);
            var result = controller.GetCategory("horror");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Category>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void ClubPostControllerShouldReturnList()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetAllClubPosts()).Returns(
                new List<ClubPost>
                {
                    new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0),
                    new ClubPost("bryce.zimbelman@revature.com", "Poor Read", 2, 0, 5)
                }
                );

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetAllClubPosts();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void ClubPostControllerShouldReturnClubPost()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetClubPostById(1)).Returns(
                new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0)
                );

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetClubPostById(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<ClubPost>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void ClubPostControllerShouldReturnClubPostByBookClub()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetClubPostByBookClub(1)).Returns(
                new List<ClubPost>
                {
                new ClubPost("bryce.zimbelman@icloud.com", "Gets Better", 1, 10, 2),
                new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0)
                });

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetClubPostByBookClub(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CommentControllerShouldReturnList()
        {
            var mockBL = new Mock<ICommentBL>();
            mockBL.Setup(x => x.GetAllComments()).Returns(
                new List<Comment>
                {
                    new Comment("bryce.zimbelman@icloud.com", 1, 0, "Good Read"),
                    new Comment("bryce.zimbelman@revature.com", 0, 1, "Poor Read")
                }
                );

            var controller = new CommentController(mockBL.Object);
            var result = controller.GetAllComments();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Comment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CommentControllerShouldReturnComment()
        {
            var mockBL = new Mock<ICommentBL>();
            mockBL.Setup(x => x.GetCommentById(1)).Returns(
                new Comment("bryce.zimbelman@icloud.com", 1, 0, "Good Read")
                );

            var controller = new CommentController(mockBL.Object);
            var result = controller.GetCommentById(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Comment>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CommentControllerShouldReturnUserPostComments()
        {
            var mockBL = new Mock<ICommentBL>();
            mockBL.Setup(x => x.GetUserPostComments(1)).Returns(
                new List<Comment>
                {
                new Comment("bryce.zimbelman@revature.net", 1, 0, "Poor Read"),
                new Comment("bryce.zimbelman@icloud.com", 1, 0, "Good Read")
                });

            var controller = new CommentController(mockBL.Object);
            var result = controller.GetUserPostComments(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Comment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void CommentControllerShouldReturnClubPostComments()
        {
            var mockBL = new Mock<ICommentBL>();
            mockBL.Setup(x => x.GetClubPostComments(1)).Returns(
                new List<Comment>
                {
                new Comment("bryce.zimbelman@revature.net", 0, 1, "Poor Read"),
                new Comment("bryce.zimbelman@icloud.com", 0, 1, "Good Read")
                });

            var controller = new CommentController(mockBL.Object);
            var result = controller.GetClubPostComments(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Comment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FavoriteBookControllerShouldReturnList()
        {
            var mockBL = new Mock<IFavoriteBookBL>();
            mockBL.Setup(x => x.GetAllBooksRead()).Returns(
                new List<FavoriteBook>
                {
                    new FavoriteBook("bryce.zimbelman@icloud.com", "12356789"),
                    new FavoriteBook("bryce.zimbelman@revature.com", "987654321")
                }
                );

            var controller = new FavoriteBookController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FavoriteBook>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FavoriteBookControllerShouldReturnFavoriteBook()
        {
            var mockBL = new Mock<IFavoriteBookBL>();
            mockBL.Setup(x => x.GetBooksReadByUser("bryce.zimbelman@icloud.com")).Returns(
                new List<Book>
                {

                new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                new Book("987654321", "Test", "Me", "Testing")

                });

            var controller = new FavoriteBookController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@icloud.com");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FollowClubControllerShouldReturnList()
        {
            var mockBL = new Mock<IFollowClubBL>();
            mockBL.Setup(x => x.GetAllFollowClub()).Returns(
                new List<FollowClub>
                {
                    new FollowClub("bryce.zimbelman@icloud.com", 1),
                    new FollowClub("bryce.zimbelman@revature.com", 1)
                }
                );

            var controller = new FollowClubController(mockBL.Object);
            var result = controller.GetAllFollowClub();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FollowClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FollowClubControllerShouldReturnClubsFollowed()
        {
            var mockBL = new Mock<IFollowClubBL>();
            mockBL.Setup(x => x.GetFollowingByUser("bryce.zimbelman@icloud.com")).Returns(
                new List<BookClub>
                {

                new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"),
                new BookClub("Hunger Games", "Hungry Reads", "987654321", "bryce.zimbelman@revature.net")

                });

            var controller = new FollowClubController(mockBL.Object);
            var result = controller.GetFollowingByUser("bryce.zimbelman@icloud.com");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FollowUserControllerShouldReturnList()
        {
            var mockBL = new Mock<IFollowUserBL>();
            mockBL.Setup(x => x.GetAllFollowUser()).Returns(
                new List<FollowUser>
                {
                    new FollowUser("bryce.zimbelman@icloud.com", "bryce.zimbelman@revature.net"),
                    new FollowUser("bryce.zimbelman@revature.com", "bryce.zimbelman@icloud.com")
                }
                );

            var controller = new FollowUserController(mockBL.Object);
            var result = controller.GetAllFollowUser();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FollowUser>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void FollowUserControllerShouldReturnUsersFollowed()
        {
            var mockBL = new Mock<IFollowUserBL>();
            mockBL.Setup(x => x.GetFollowersByUser("bryce.zimbelman@icloud.com")).Returns(
                new List<User>
                {

                new User("bryce.zimbelman@revature.net", "1Password!", "1514 Canyon Dr", 500),
                new User("bryce.zimbelman@gmail.com", "!Password1", "309 E Memorial Dr", 5000)

                });

            var controller = new FollowUserController(mockBL.Object);
            var result = controller.GetFollowersByUser("bryce.zimbelman@icloud.com");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void UserControllerShouldReturnList()
        {
            var mockBL = new Mock<IUserBL>();
            mockBL.Setup(x => x.GetAllUsers()).Returns(
                new List<User>
                {

                new User("bryce.zimbelman@revature.net", "1Password!", "1514 Canyon Dr", 500),
                new User("bryce.zimbelman@gmail.com", "!Password1", "309 E Memorial Dr", 5000)

                });

            var controller = new UserController(mockBL.Object);
            var result = controller.GetAllUsers();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void UserControllerShouldReturnUser()
        {
            var mockBL = new Mock<IUserBL>();
            mockBL.Setup(x => x.GetUserByEmail("bryce.zimbelman@icloud.com")).Returns(new User("bryce.zimbelman@icloud.com", "Password", "13590 SW Electric St", 5));

            var controller = new UserController(mockBL.Object);
            var result = controller.GetUserByEmail("bryce.zimbelman@icloud.com");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<User>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void UserPostControllerShouldReturnList()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetAllUserPosts()).Returns(
                new List<UserPost>
                {

                new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5),
                new UserPost("bryce.zimbelman@gmail.com", "Bad Reads", 10, 1)

                });

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetAllUserPosts();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void UserPostControllerShouldReturnUserPost()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetUserPostById(1)).Returns(new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5));

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetUserPostById(1);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<UserPost>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void UserPostControllerShouldReturnUserPostByUser()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetUserPostByUser("bryce.zimbelman@revature.net")).Returns(
                new List<UserPost>
                {
                new UserPost("bryce.zimbelman@revature.net", "Poor Reads", 0, 10),
                new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5)
                });

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetUserPostByUser("bryce.zimbelman@revature.net");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }
    }
}

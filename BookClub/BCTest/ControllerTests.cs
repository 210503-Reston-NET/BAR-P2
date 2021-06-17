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
using System.Threading.Tasks;

namespace BCTest
{
    public class ControllerTests
    {
        [Fact]
        public async Task BookControllerShouldReturnList()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetAllBooksAsync()).ReturnsAsync(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BookController(mockBL.Object);
            var result = controller.GetAllBooks();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookControllerShouldReturnBook()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByISBNAsync("123456789")).ReturnsAsync(new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"));

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByISBN("123456789");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Book>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookControllerShouldReturnBookByTitle()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByTitleAsync("Harry Potter")).ReturnsAsync(new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"));

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByTitle("Harry Potter");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Book>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookControllerShouldReturnBookByAuthor()
        {
            var mockBL = new Mock<IBookBL>();
            mockBL.Setup(x => x.GetBookByAuthorAsync("JK Rowling")).ReturnsAsync(
                new List<Book>
                {
                new Book("135798642", "Harry Potter 2", "JK Rowling", "Fantasy"),
                new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy")
                });

            var controller = new BookController(mockBL.Object);
            var result = controller.GetBookByAuthor("JK Rowling");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookClubControllerShouldReturnList()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetAllBookClubsAsync()).ReturnsAsync(
                new List<BookClub>
                {
                    new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"),
                    new BookClub("Hunger Games", "Hungry Reads", "987654321", "bryce.zimbelman@revature.net")
                }
                );

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetAllBookClubs();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookClubControllerShouldReturnBookClub()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetBookClubByIdAsync(1)).ReturnsAsync(new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"));

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetBookClubById(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<BookClub>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BookClubControllerShouldReturnBookClubByBook()
        {
            var mockBL = new Mock<IBookClubBL>();
            mockBL.Setup(x => x.GetBookClubByBookAsync("123456789")).ReturnsAsync(
                new List<BookClub>
                {
                new BookClub("Harry Potter 2", "Ok Reads", "123456789", "bryce.zimbelman@icloud.com"),
                new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net")
                });

            var controller = new BookClubController(mockBL.Object);
            var result = controller.GetBookClubByBook("123456789");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BooksReadControllerShouldReturnList()
        {
            var mockBL = new Mock<IBooksReadBL>();
            mockBL.Setup(x => x.GetAllBooksReadAsync()).ReturnsAsync(
                new List<BooksRead>
                {
                    new BooksRead("bryce.zimbelman@revature.net", "123456789", 50),
                    new BooksRead("bryce.zimbelman@revature.net", "987654321", 50)
                }
                );

            var controller = new BooksReadController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BooksRead>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BooksReadControllerShouldReturnBooks()
        {
            var mockBL = new Mock<IBooksReadBL>();
            mockBL.Setup(x => x.GetBooksReadByUserAsync("bryce.zimbelman@revature.net")).ReturnsAsync(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BooksReadController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@revature.net");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BooksToReadControllerShouldReturnList()
        {
            var mockBL = new Mock<IBooksToReadBL>();
            mockBL.Setup(x => x.GetAllBooksReadAsync()).ReturnsAsync(
                new List<BooksToRead>
                {
                    new BooksToRead("bryce.zimbelman@revature.net", "123456789"),
                    new BooksToRead("bryce.zimbelman@revature.net", "987654321")
                }
                );

            var controller = new BookToReadController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BooksToRead>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task BooksToReadControllerShouldReturnBooks()
        {
            var mockBL = new Mock<IBooksToReadBL>();
            mockBL.Setup(x => x.GetBooksReadByUserAsync("bryce.zimbelman@revature.net")).ReturnsAsync(
                new List<Book>
                {
                    new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                    new Book("987654321", "Test", "Me", "Testing")
                }
                );

            var controller = new BookToReadController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@revature.net");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task CategoryControllerShouldReturnList()
        {
            var mockBL = new Mock<ICategoryBL>();
            mockBL.Setup(x => x.GetAllCategoriesAsync()).ReturnsAsync(
                new List<Category>
                {
                    new Category("Horor"),
                    new Category("Adventure")
                }
                );

            var controller = new CategoryController(mockBL.Object);
            var result = controller.GetAllCategories();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Category>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task CategoryControllerShouldReturnCategory()
        {
            var mockBL = new Mock<ICategoryBL>();
            mockBL.Setup(x => x.GetCategoryAsync("horror")).ReturnsAsync(
                new Category("horror")
                );

            var controller = new CategoryController(mockBL.Object);
            var result = controller.GetCategory("horror");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<Category>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubPostControllerShouldReturnList()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetAllClubPostsAsync()).ReturnsAsync(
                new List<ClubPost>
                {
                    new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0, new DateTime()),
                    new ClubPost("bryce.zimbelman@revature.com", "Poor Read", 2, 0, 5, new DateTime())
                }
                );

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetAllClubPosts();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubPostControllerShouldReturnClubPost()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetClubPostByIdAsync(1)).ReturnsAsync(
                new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0, new DateTime())
                );

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetClubPostById(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<ClubPost>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubPostControllerShouldReturnClubPostByBookClub()
        {
            var mockBL = new Mock<IClubPostBL>();
            mockBL.Setup(x => x.GetClubPostByBookClubAsync(1)).ReturnsAsync(
                new List<ClubPost>
                {
                new ClubPost("bryce.zimbelman@icloud.com", "Gets Better", 1, 10, 2, new DateTime()),
                new ClubPost("bryce.zimbelman@icloud.com", "Good Read", 1, 5, 0, new DateTime())
                });

            var controller = new ClubPostController(mockBL.Object);
            var result = controller.GetClubPostByBookClub(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserCommentControllerShouldReturnList()
        {
            var mockBL = new Mock<IUserCommentBL>();
            mockBL.Setup(x => x.GetAllCommentsAsync()).ReturnsAsync(
                new List<UserComment>
                {
                    new UserComment("bryce.zimbelman@icloud.com", 1, "Good Read"),
                    new UserComment("bryce.zimbelman@revature.com", 2, "Poor Read")
                }
                );

            var controller = new UserCommentController(mockBL.Object);
            var result = controller.GetAllComments();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserComment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubCommentControllerShouldReturnList()
        {
            var mockBL = new Mock<IClubCommentBL>();
            mockBL.Setup(x => x.GetAllCommentsAsync()).ReturnsAsync(
                new List<ClubComment>
                {
                    new ClubComment("bryce.zimbelman@icloud.com", 1, "Good Read"),
                    new ClubComment("bryce.zimbelman@revature.com", 2, "Poor Read")
                }
                );

            var controller = new ClubCommentController(mockBL.Object);
            var result = controller.GetAllComments();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubComment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserCommentControllerShouldReturnComment()
        {
            var mockBL = new Mock<IUserCommentBL>();
            mockBL.Setup(x => x.GetCommentByIdAsync(1)).ReturnsAsync(
                new UserComment("bryce.zimbelman@icloud.com", 1, "Good Read")
                );

            var controller = new UserCommentController(mockBL.Object);
            var result = controller.GetCommentById(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<UserComment>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubCommentControllerShouldReturnComment()
        {
            var mockBL = new Mock<IClubCommentBL>();
            mockBL.Setup(x => x.GetCommentByIdAsync(1)).ReturnsAsync(
                new ClubComment("bryce.zimbelman@icloud.com", 1, "Good Read")
                );

            var controller = new ClubCommentController(mockBL.Object);
            var result = controller.GetCommentById(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<ClubComment>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserCommentControllerShouldReturnUserPostComments()
        {
            var mockBL = new Mock<IUserCommentBL>();
            mockBL.Setup(x => x.GetUserPostCommentsAsync(1)).ReturnsAsync(
                new List<UserComment>
                {
                new UserComment("bryce.zimbelman@revature.net", 1, "Poor Read"),
                new UserComment("bryce.zimbelman@icloud.com", 2, "Good Read")
                });

            var controller = new UserCommentController(mockBL.Object);
            var result = controller.GetUserPostComments(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserComment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task ClubCommentControllerShouldReturnClubPostComments()
        {
            var mockBL = new Mock<IClubCommentBL>();
            mockBL.Setup(x => x.GetCommentByClubIdAsync(1)).ReturnsAsync(
                new List<ClubComment>
                {
                new ClubComment("bryce.zimbelman@revature.net", 1, "Poor Read"),
                new ClubComment("bryce.zimbelman@icloud.com", 2, "Good Read")
                });

            var controller = new ClubCommentController(mockBL.Object);
            var result = controller.GetClubPostComments(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<ClubComment>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FavoriteBookControllerShouldReturnList()
        {
            var mockBL = new Mock<IFavoriteBookBL>();
            mockBL.Setup(x => x.GetAllBooksReadAsync()).ReturnsAsync(
                new List<FavoriteBook>
                {
                    new FavoriteBook("bryce.zimbelman@icloud.com", "12356789"),
                    new FavoriteBook("bryce.zimbelman@revature.com", "987654321")
                }
                );

            var controller = new FavoriteBookController(mockBL.Object);
            var result = controller.GetAllBooksRead();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FavoriteBook>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FavoriteBookControllerShouldReturnFavoriteBook()
        {
            var mockBL = new Mock<IFavoriteBookBL>();
            mockBL.Setup(x => x.GetBooksReadByUserAsync("bryce.zimbelman@icloud.com")).ReturnsAsync(
                new List<Book>
                {

                new Book("123456789", "Harry Potter", "JK Rowling", "Fantasy"),
                new Book("987654321", "Test", "Me", "Testing")

                });

            var controller = new FavoriteBookController(mockBL.Object);
            var result = controller.GetBooksReadByUser("bryce.zimbelman@icloud.com");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<Book>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FollowClubControllerShouldReturnList()
        {
            var mockBL = new Mock<IFollowClubBL>();
            mockBL.Setup(x => x.GetAllFollowClubAsync()).ReturnsAsync(
                new List<FollowClub>
                {
                    new FollowClub("bryce.zimbelman@icloud.com", 1),
                    new FollowClub("bryce.zimbelman@revature.com", 1)
                }
                );

            var controller = new FollowClubController(mockBL.Object);
            var result = controller.GetAllFollowClub();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FollowClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FollowClubControllerShouldReturnClubsFollowed()
        {
            var mockBL = new Mock<IFollowClubBL>();
            mockBL.Setup(x => x.GetFollowingByUserAsync("bryce.zimbelman@icloud.com")).ReturnsAsync(
                new List<BookClub>
                {

                new BookClub("Harry Potter", "Good Reads", "123456789", "bryce.zimbelman@revature.net"),
                new BookClub("Hunger Games", "Hungry Reads", "987654321", "bryce.zimbelman@revature.net")

                });

            var controller = new FollowClubController(mockBL.Object);
            var result = controller.GetFollowingByUser("bryce.zimbelman@icloud.com");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<BookClub>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FollowUserControllerShouldReturnList()
        {
            var mockBL = new Mock<IFollowUserBL>();
            mockBL.Setup(x => x.GetAllFollowUserAsync()).ReturnsAsync(
                new List<FollowUser>
                {
                    new FollowUser("bryce.zimbelman@icloud.com", "bryce.zimbelman@revature.net"),
                    new FollowUser("bryce.zimbelman@revature.com", "bryce.zimbelman@icloud.com")
                }
                );

            var controller = new FollowUserController(mockBL.Object);
            var result = controller.GetAllFollowUser();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<FollowUser>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task FollowUserControllerShouldReturnUsersFollowed()
        {
            var mockBL = new Mock<IFollowUserBL>();
            mockBL.Setup(x => x.GetFollowersByUserAsync("bryce.zimbelman@icloud.com")).ReturnsAsync(
                new List<User>
                {

                new User("bryce.zimbelman@revature.net", "1Password!", "1514 Canyon Dr", 500),
                new User("bryce.zimbelman@gmail.com", "!Password1", "309 E Memorial Dr", 5000)

                });

            var controller = new FollowUserController(mockBL.Object);
            var result = controller.GetFollowersByUser("bryce.zimbelman@icloud.com");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserControllerShouldReturnList()
        {
            var mockBL = new Mock<IUserBL>();
            mockBL.Setup(x => x.GetAllUsersAsync()).ReturnsAsync(
                new List<User>
                {

                new User("bryce.zimbelman@revature.net", "1Password!", "1514 Canyon Dr", 500),
                new User("bryce.zimbelman@gmail.com", "!Password1", "309 E Memorial Dr", 5000)

                });

            var controller = new UserController(mockBL.Object);
            var result = controller.GetAllUsers();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserControllerShouldReturnUser()
        {
            var mockBL = new Mock<IUserBL>();
            mockBL.Setup(x => x.GetUserByEmailAsync("bryce.zimbelman@icloud.com")).ReturnsAsync(new User("bryce.zimbelman@icloud.com", "Password", "13590 SW Electric St", 5));

            var controller = new UserController(mockBL.Object);
            var result = controller.GetUserByEmail("bryce.zimbelman@icloud.com");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<User>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserPostControllerShouldReturnList()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetAllUserPostsAsync()).ReturnsAsync(
                new List<UserPost>
                {

                new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5, new DateTime()),
                new UserPost("bryce.zimbelman@gmail.com", "Bad Reads", 10, 1, new DateTime())

                });

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetAllUserPosts();
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserPostControllerShouldReturnUserPost()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetUserPostByIdAsync(1)).ReturnsAsync(new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5, new DateTime()));

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetUserPostById(1);
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<UserPost>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task UserPostControllerShouldReturnUserPostByUser()
        {
            var mockBL = new Mock<IUserPostBL>();
            mockBL.Setup(x => x.GetUserPostByUserAsync("bryce.zimbelman@revature.net")).ReturnsAsync(
                new List<UserPost>
                {
                new UserPost("bryce.zimbelman@revature.net", "Poor Reads", 0, 10, new DateTime()),
                new UserPost("bryce.zimbelman@revature.net", "Good Reads", 1, 5, new DateTime())
                });

            var controller = new UserPostController(mockBL.Object);
            var result = controller.GetUserPostByUser("bryce.zimbelman@revature.net");
            var okResult = await result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.True(okResult is OkObjectResult);
            Assert.IsType<List<UserPost>>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }
    }
}

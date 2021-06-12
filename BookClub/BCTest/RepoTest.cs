using Model = BCModel;
using Microsoft.EntityFrameworkCore;
using BCDL;
using System.Linq;
using Xunit;

namespace BCTest
{
    public class RepoTest
    {
        private readonly DbContextOptions<BookClubDBContext> options;
        public RepoTest()
        {
            options = new DbContextOptionsBuilder<BookClubDBContext>().UseSqlite("Filename=Test.db").Options;
            Seed();
        }


        
        private void Seed()
        {
            using (var context = new BookClubDBContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Books.AddRange(
                    new Model.Book
                    {
                        ISBN = "123456789",
                        Title = "Unit Testing",
                        Author = "Bryce",
                        CategoryName = "Test"
                    },
                    new Model.Book
                    {
                        ISBN = "987654321",
                        Title = "More Testing",
                        Author = "Zimbelman",
                        CategoryName = "Test"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.BookClubs.AddRange(
                    new Model.BookClub
                    {
                        Name = "Harry Potter",
                        Description = "Magical Reads",
                        ISBN = "14598678",
                        Email = "bryce.zimbelman@revature.net"
                    },
                    new Model.BookClub
                    {
                        Name = "Hunger Games",
                        Description = "Very Hungry Readers",
                        ISBN = "19872345",
                        Email = "bryce.zimbelman@revature.net"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.BooksRead.AddRange(
                    new Model.BooksRead
                    {
                        User = "bryce.zimbelman@revature.net",
                        ISBN = "123456789"
                    },
                    new Model.BooksRead
                    {
                        User = "bryce.zimbelman@revature.net",
                        ISBN = "987654321"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.BooksToRead.AddRange(
                    new Model.BooksToRead
                    {
                        Email = "bryce.zimbelman@revature.net",
                        ISBN = "123456789"
                    },
                    new Model.BooksToRead
                    {
                        Email = "bryce.zimbelman@revature.net",
                        ISBN = "987654321"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Categories.AddRange(
                    new Model.Category
                    {
                        Name = "Horror"
                    },
                    new Model.Category
                    {
                        Name = "Action"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ClubPosts.AddRange(
                    new Model.ClubPost
                    {
                        User = "bryce.zimbelman@revature.net",
                        Post = "Good Book",
                        BookClubID = 1,
                        TotalLike = 3,
                        TotalDislike = 1
                    },
                    new Model.ClubPost
                    {
                        User = "bryce.zimbelman@revature.net",
                        Post = "Fun Book",
                        BookClubID = 2,
                        TotalLike = 9,
                        TotalDislike = 4
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Comments.AddRange(
                    new Model.Comment
                    {
                        Email = "bryce.zimbelman@revature.net",
                        UserPostID = 1,
                        ClubPostID = 0,
                        Message = "Wrong"
                    },
                    new Model.Comment
                    {
                        Email = "bryce.zimbelman@revature.net",
                        UserPostID = 0,
                        ClubPostID = 1,
                        Message = "Right"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FavoriteBooks.AddRange(
                    new Model.FavoriteBook
                    {
                        Email = "bryce.zimbelman@revature.net",
                        ISBN = "123456789"
                    },
                    new Model.FavoriteBook
                    {
                        Email = "bryce.zimbelman@revature.net",
                        ISBN = "987654321"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FollowClubs.AddRange(
                    new Model.FollowClub
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        ClubID = 1
                    },
                    new Model.FollowClub
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        ClubID = 2
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FollowUsers.AddRange(
                    new Model.FollowUser
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        FollowedEmail = "bryce.zimbelman@icloud.com"
                    },
                    new Model.FollowUser
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        FollowedEmail = "bryce.zimbelman@gmail.com"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Users.AddRange(
                    new Model.User
                    {
                        Email = "bryce.zimbelman@revature.net",
                        Password = "1Password!",
                        Address = "1514 Canyon Dr",
                        PagesRead = 1000
                    },
                    new Model.User
                    {
                        Email = "bryce.zimbelman@icloud.com",
                        Password = "!Password1",
                        Address = "309 E Memorial Dr",
                        PagesRead = 5000
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.UserPosts.AddRange(
                    new Model.UserPost
                    {
                        Email = "bryce.zimbelman@revature.net",
                        Post = "You all should join my BookClub",
                        TotalLike = 8,
                        TotalDislike = 0
                    },
                    new Model.UserPost
                    {
                        Email = "bryce.zimbelman@revature.net",
                        Post = "You all should join that other BookClub",
                        TotalLike = 0,
                        TotalDislike = 8
                    }
                    );
                context.SaveChanges();
            }
        }
        [Fact]
        public void GetAllBooksShouldReturnAllBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                var books = _repo.GetAllBooks();
                Assert.Equal(2, books.Count);
            }
        }

        [Fact]
        public void GetAllBookClubsShouldReturnAllBookClubs()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                var bookClubs = _repo.GetAllBookClubs();
                Assert.Equal(2, bookClubs.Count);
            }
        }

        [Fact]
        public void GetAllBooksReadShouldReturnAllBooksRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksReadRepo _repo = new BooksReadRepo(context);
                var booksRead = _repo.GetAllBooksRead();
                Assert.Equal(2, booksRead.Count);
            }
        }

        [Fact]
        public void GetAllBooksToReadShouldReturnAllBooksToRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksToReadRepo _repo = new BookToReadRepo(context);
                var booksToRead = _repo.GetAllBooksRead();
                Assert.Equal(2, booksToRead.Count);
            }
        }

        [Fact]
        public void GetAllCategoriesShouldReturnAllCategories()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICategoryRepo _repo = new CategoryRepo(context);
                var categories = _repo.GetAllCategories();
                Assert.Equal(2, categories.Count);
            }
        }

        [Fact]
        public void GetAllClubPostsShouldReturnAllClubPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                var clubPosts = _repo.GetAllClubPosts();
                Assert.Equal(2, clubPosts.Count);
            }
        }

        [Fact]
        public void GetAllCommentsShouldReturnAllComments()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICommentRepo _repo = new CommentRepo(context);
                var comments = _repo.GetAllComments();
                Assert.Equal(2, comments.Count);
            }
        }

        [Fact]
        public void GetAllFavoriteBooksShouldReturnAllFavoriteBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFavoriteBookRepo _repo = new FavoriteBookRepo(context);
                var favoriteBooks = _repo.GetAllBooksRead();
                Assert.Equal(2, favoriteBooks.Count);
            }
        }

        [Fact]
        public void GetAllClubFollowersShouldReturnAllClubFollowers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                var clubFollowers = _repo.GetAllFollowClub();
                Assert.Equal(2, clubFollowers.Count);
            }
        }

        [Fact]
        public void GetAllUserFollowersShouldReturnAllUserFollowers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                var userFollowers = _repo.GetAllFollowUser();
                Assert.Equal(2, userFollowers.Count);
            }
        }

        [Fact]
        public void GetAllUsersShouldReturnAllUsers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserRepo _repo = new UserRepo(context);
                var users = _repo.GetAllUsers();
                Assert.Equal(2, users.Count);
            }
        }

        [Fact]
        public void GetAllUserPostsShouldReturnAllUserPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                var userPosts = _repo.GetAllUserPosts();
                Assert.Equal(2, userPosts.Count);
            }
        }

        [Fact]
        public void AddBookShouldAddBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                _repo.AddBook(new Model.Book("135798642", "Interesting Book", "Me", "Boring"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Books.FirstOrDefault(books => books.ISBN == "135798642");
                Assert.NotNull(result);
                Assert.Equal("Interesting Book", result.Title);
            }
        }

        [Fact]
        public void AddBookClubShouldAddBookClub()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                _repo.AddBookClub(new Model.BookClub("Good Reads", "Interestings Reads", "987123456", "bryce.zimbelman@revature.net"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BookClubs.FirstOrDefault(bookClub => bookClub.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("Good Reads", result.Name);
            }
        }

        [Fact]
        public void AddBooksReadShouldAddBooksRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksReadRepo _repo = new BooksReadRepo(context);
                _repo.AddBooksRead(new Model.BooksRead("bryce.zimbelman@icloud.com", "135798642"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BooksRead.FirstOrDefault(booksRead => booksRead.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public void AddBooksToReadShouldAddBooksToRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksToReadRepo _repo = new BookToReadRepo(context);
                _repo.AddBooksRead(new Model.BooksToRead("bryce.zimbelman@revature.net", "135798642"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BooksToRead.FirstOrDefault(booksToRead => booksToRead.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public void AddCategoryShouldAddCategory()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICategoryRepo _repo = new CategoryRepo(context);
                _repo.AddCategory(new Model.Category("Adventure"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Categories.FirstOrDefault(category => category.Name == "Adventure");
                Assert.NotNull(result);
                Assert.Equal("Adventure", result.Name);
            }
        }

        [Fact]
        public void AddClubPostShouldAddClubPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                _repo.AddClubPost(new Model.ClubPost("bryce.zimbelman@revature.net", "Boring Book!", 1, 0, 10));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.ClubPosts.FirstOrDefault(clubPost => clubPost.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("Boring Book!", result.Post);
            }
        }

        [Fact]
        public void AddCommentShoulAddComment()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICommentRepo _repo = new CommentRepo(context);
                _repo.AddComment(new Model.Comment("bryce.zimbelman@revature.net", 2, 0, "maybe"));
            }

            using (var assertcontext = new BookClubDBContext(options))
            {
                var result = assertcontext.Comments.FirstOrDefault(comment => comment.Id == 3);
                Assert.NotNull(result);
                Assert.Equal(2, result.UserPostID);
            }
        }

        [Fact]
        public void AddFavoriteBookShouldAddFavoriteBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFavoriteBookRepo _repo = new FavoriteBookRepo(context);
                _repo.AddBooksRead(new Model.FavoriteBook("bryce.zimbelman@revature.net", "135798642"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FavoriteBooks.FirstOrDefault(favoriteBook => favoriteBook.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public void AddFollowClubShouldAddFollowClub()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                _repo.AddFollowClub(new Model.FollowClub("bryce.zimbelman@revature.net", 3));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FollowClubs.FirstOrDefault(clubFollower => clubFollower.Id == 3);
                Assert.NotNull(result);
                Assert.Equal(3, result.ClubID);
            }
        }

        [Fact]
        public void AddFollowUserShouldAddFollowUser()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                _repo.AddFollowUser(new Model.FollowUser("bryce.zimbelman@gmail.com", "bryce.zimbelman@revature.net"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FollowUsers.FirstOrDefault(userFollower => userFollower.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("bryce.zimbelman@gmail.com", result.FollowerEmail);
                Assert.Equal("bryce.zimbelman@revature.net", result.FollowedEmail);
            }
        }

        [Fact]
        public void AddUserShouldAddUser()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserRepo _repo = new UserRepo(context);
                _repo.AddUser(new Model.User("bryce.zimbelman@gmail.com", "Password!", "13590 SW Electric St", 10));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Users.FirstOrDefault(user => user.Email == "bryce.zimbelman@gmail.com");
                Assert.NotNull(result);
                Assert.Equal(10, result.PagesRead);
            }
        }

        [Fact]
        public void AddUserPostShouldReturnUserPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                _repo.AddUserPost(new Model.UserPost("bryce.zimbelman@icloud.com", "Does anyone else read Harry Potter?", 24, 3));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.UserPosts.FirstOrDefault(userPost => userPost.Id == 3);
                Assert.NotNull(result);
                Assert.Equal(24, result.TotalLike);
            }
        }
    }
}

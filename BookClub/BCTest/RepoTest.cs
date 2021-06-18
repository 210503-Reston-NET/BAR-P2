using Model = BCModel;
using Microsoft.EntityFrameworkCore;
using BCDL;
using System.Linq;
using Xunit;
using System;
using System.Threading.Tasks;

namespace BCTest
{
    public class RepoTest
    {
        private readonly DbContextOptions<BookClubDBContext> options;
        public RepoTest()
        {
            options = new DbContextOptionsBuilder<BookClubDBContext>().UseSqlite("Filename=Test.db;foreign keys=false").Options;
            Seed();
        }



        private void Seed()
        {
            using (var context = new BookClubDBContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Users.AddRange(
                    new Model.User
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        Password = "1Password!",
                        Address = "1514 Canyon Dr",
                        PagesRead = 1000
                    },
                    new Model.User
                    {
                        UserEmail = "bryce.zimbelman@icloud.com",
                        Password = "!Password1",
                        Address = "309 E Memorial Dr",
                        PagesRead = 5000
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Categories.AddRange(
                    new Model.Category
                    {
                        CategoryId = "Horror"
                    },
                    new Model.Category
                    {
                        CategoryId = "Action"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Books.AddRange(
                    new Model.Book
                    {
                        ISBN = "123456789",
                        Title = "Unit Testing",
                        Author = "Bryce",
                        CategoryId = "Test"
                    },
                    new Model.Book
                    {
                        ISBN = "987654321",
                        Title = "More Testing",
                        Author = "Zimbelman",
                        CategoryId = "Test"
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
                        UserEmail = "bryce.zimbelman@revature.net"
                    },
                    new Model.BookClub
                    {
                        Name = "Hunger Games",
                        Description = "Very Hungry Readers",
                        ISBN = "19872345",
                        UserEmail = "bryce.zimbelman@revature.net"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.BooksRead.AddRange(
                    new Model.BooksRead
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "123456789",
                        BookPages = 50
                    },
                    new Model.BooksRead
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "987654321",
                        BookPages = 50
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.BooksToRead.AddRange(
                    new Model.BooksToRead
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "123456789"
                    },
                    new Model.BooksToRead
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "987654321"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ClubPosts.AddRange(
                    new Model.ClubPost
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        Post = "Good Book",
                        BookClubId = 1,
                        TotalLike = 3,
                        TotalDislike = 1,
                        Date = new DateTime()
                    },
                    new Model.ClubPost
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        Post = "Fun Book",
                        BookClubId = 2,
                        TotalLike = 9,
                        TotalDislike = 4,
                        Date = new DateTime()
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.UserPosts.AddRange(
                    new Model.UserPost
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        Post = "You all should join my BookClub",
                        TotalLike = 8,
                        TotalDislike = 0,
                        Date = new DateTime()
                    },
                    new Model.UserPost
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        Post = "You all should join that other BookClub",
                        TotalLike = 0,
                        TotalDislike = 8,
                        Date = new DateTime()
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.UserComments.AddRange(
                    new Model.UserComment
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        UserPostID = 1,
                        Message = "Wrong"
                    },
                    new Model.UserComment
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        UserPostID = 1,
                        Message = "Right"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ClubComments.AddRange(
                    new Model.ClubComment
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ClubPostID = 1,
                        Message = "Wrong"
                    },
                    new Model.ClubComment
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ClubPostID = 1,
                        Message = "Right"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FavoriteBooks.AddRange(
                    new Model.FavoriteBook
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "123456789"
                    },
                    new Model.FavoriteBook
                    {
                        UserEmail = "bryce.zimbelman@revature.net",
                        ISBN = "987654321"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FollowClubs.AddRange(
                    new Model.FollowClub
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        BookClubId = 1
                    },
                    new Model.FollowClub
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        BookClubId = 2
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.FollowUsers.AddRange(
                    new Model.FollowUser
                    {
                        FollowerEmail = "bryce.zimbelman@revature.net",
                        UserEmail = "bryce.zimbelman@icloud.com"
                    },
                    new Model.FollowUser
                    {
                        FollowerEmail = "bryce.zimbelman@icloud.com",
                        UserEmail = "bryce.zimbelman@revature.net"
                    }
                    );


                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ClubPostLikes.AddRange(
                    new Model.ClubPostLikes
                    {
                        Like = false,
                        Dislike = true,
                        ClubPostId = 1,
                        UserEmail = "bryce.zimbelman@revature.net"
                    },
                    new Model.ClubPostLikes
                    {
                        Like = true,
                        Dislike = false,
                        ClubPostId = 1,
                        UserEmail = "bryce.zimbelman@icloud.com"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.UserPostLikes.AddRange(
                    new Model.UserPostLikes
                    {
                        Like = false,
                        Dislike = true,
                        UserPostId = 1,
                        UserEmail = "bryce.zimbelman@revature.net"
                    },
                    new Model.UserPostLikes
                    {
                        Like = true,
                        Dislike = false,
                        UserPostId = 1,
                        UserEmail = "bryce.zimbelman@icloud.com"
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.UserCommentLikes.AddRange(
                    new Model.UserCommentLikes
                    {
                        Like = false,
                        Dislike = true,
                        UserCommentId = 1,
                        UserEmail = "bryce.zimbelman@revature.net",
                        UserPostId = 1
                    },
                    new Model.UserCommentLikes
                    {
                        Like = true,
                        Dislike = false,
                        UserCommentId = 1,
                        UserEmail = "bryce.zimbelman@icloud.com",
                        UserPostId = 1
                    }
                    );

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.ClubCommentLikes.AddRange(
                    new Model.ClubCommentLikes
                    {
                        Like = false,
                        Dislike = true,
                        ClubCommentId = 1,
                        UserEmail = "bryce.zimbelman@revature.net"
                    },
                    new Model.ClubCommentLikes
                    {
                        Like = true,
                        Dislike = false,
                        ClubCommentId = 1,
                        UserEmail = "bryce.zimbelman@icloud.com"
                    }
                    );
                context.SaveChanges();
            }
        }
        [Fact]
        public async Task GetAllBooksShouldReturnAllBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                var books = await _repo.GetAllBooksAsync();
                Assert.Equal(2, books.Count);
            }
        }

        [Fact]
        public async Task GetAllBookClubsShouldReturnAllBookClubs()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                var bookClubs = await _repo.GetAllBookClubsAsync();
                Assert.Equal(2, bookClubs.Count);
            }
        }

        [Fact]
        public async Task GetAllBooksReadShouldReturnAllBooksRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksReadRepo _repo = new BooksReadRepo(context);
                var booksRead = await _repo.GetAllBooksReadAsync();
                Assert.Equal(2, booksRead.Count);
            }
        }

        [Fact]
        public async Task GetAllBooksToReadShouldReturnAllBooksToRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksToReadRepo _repo = new BookToReadRepo(context);
                var booksToRead = await _repo.GetAllBooksReadAsync();
                Assert.Equal(2, booksToRead.Count);
            }
        }

        [Fact]
        public async Task GetAllCategoriesShouldReturnAllCategories()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICategoryRepo _repo = new CategoryRepo(context);
                var categories = await _repo.GetAllCategoriesAsync();
                Assert.Equal(2, categories.Count);
            }
        }

        [Fact]
        public async Task GetAllClubPostsShouldReturnAllClubPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                var clubPosts = await _repo.GetAllClubPostsAsync();
                Assert.Equal(2, clubPosts.Count);
            }
        }

        [Fact]
        public async Task GetAllUserCommentsShouldReturnAllUserComments()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentRepo _repo = new UserCommentRepo(context);
                var comments = await _repo.GetAllCommentsAsync();
                Assert.Equal(2, comments.Count);
            }
        }

        [Fact]
        public async Task GetAllClubCommentsShouldReturnAllClubComments()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubCommentRepo _repo = new ClubCommentRepo(context);
                var comments = await _repo.GetAllCommentsAsync();
                Assert.Equal(2, comments.Count);
            }
        }

        [Fact]
        public async Task GetAllFavoriteBooksShouldReturnAllFavoriteBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFavoriteBookRepo _repo = new FavoriteBookRepo(context);
                var favoriteBooks = await _repo.GetAllBooksReadAsync();
                Assert.Equal(2, favoriteBooks.Count);
            }
        }

        [Fact]
        public async Task GetAllClubFollowersShouldReturnAllClubFollowers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                var clubFollowers = await _repo.GetAllFollowClubAsync();
                Assert.Equal(2, clubFollowers.Count);
            }
        }

        [Fact]
        public async Task GetAllUserFollowersShouldReturnAllUserFollowers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                var userFollowers = await _repo.GetAllFollowUserAsync();
                Assert.Equal(2, userFollowers.Count);
            }
        }

        [Fact]
        public async Task GetAllUsersShouldReturnAllUsers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserRepo _repo = new UserRepo(context);
                var users = await _repo.GetAllUsersAsync();
                Assert.Equal(2, users.Count);
            }
        }

        [Fact]
        public async Task GetAllUserPostsShouldReturnAllUserPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                var userPosts = await _repo.GetAllUserPostsAsync();
                Assert.Equal(2, userPosts.Count);
            }
        }

        [Fact]
        public async Task GetAllClubPostLikesShouldReturnAllClubPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostLikesRepo _repo = new ClubPostLikesRepo(context);
                var clubPostLikes = await _repo.GetAllClubPostLikesAsync();
                Assert.Equal(2, clubPostLikes.Count);
            }
        }

        [Fact]
        public async Task GetAllUserPostLikesShouldReturnAllUserPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostLikesRepo _repo = new UserPostLikesRepo(context);
                var userPostLikes = await _repo.GetAllUserPostLikesAsync();
                Assert.Equal(2, userPostLikes.Count);
            }
        }

        [Fact]
        public async Task GetAllUserCommentLikesShouldReturnAllUserCommentLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentLikesRepo _repo = new UserCommentLikesRepo(context);
                var commentLikes = await _repo.GetAllCommentLikesAsync();
                Assert.Equal(2, commentLikes.Count);
            }
        }

            [Fact]
        public async Task GetBookShouldReturnBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                var book = await _repo.GetBookByISBNAsync("123456789");
                Assert.Equal("Unit Testing", book.Title);
            }
        }

        [Fact]
        public async Task GetBookByAuthorShouldReturnBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                var books = await _repo.GetBookByAuthorAsync("Bryce");
                foreach (Model.Book book in books)
                {
                    Assert.Equal("Unit Testing", book.Title);
                }
            }
        }

        [Fact]
        public async Task GetBookClubShouldReturnBookClub()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                var bookClub = await _repo.GetBookClubByIdAsync(1);
                Assert.Equal("Harry Potter", bookClub.Name);
            }
        }

        [Fact]
        public async Task GetBookClubByBookShouldReturnBookClubs()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                var bookClubs = await _repo.GetBookClubByBookAsync("14598678");
                foreach (Model.BookClub bookClub in bookClubs)
                {
                    Assert.Equal("Harry Potter", bookClub.Name);
                }
            }
        }

        [Fact]
        public async Task GetBooksReadByUserShouldReturnBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksReadRepo _repo = new BooksReadRepo(context);
                var books = await _repo.GetBooksReadByUserAsync("bryce.zimbelman@revature.net");
                foreach (Model.Book book in books)
                {
                    Assert.Equal("Test", book.CategoryId);
                }
            }
        }

        [Fact]
        public async Task GetBooksToReadByUserShouldReturnBooks()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksToReadRepo _repo = new BookToReadRepo(context);
                var books = await _repo.GetBooksReadByUserAsync("bryce.zimbelman@revature.net");
                foreach (Model.Book book in books)
                {
                    Assert.Equal("Test", book.CategoryId);
                }
            }
        }

        [Fact]
        public async Task GetCategoryShouldReturnCategory()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICategoryRepo _repo = new CategoryRepo(context);
                var category = await _repo.GetCategoryAsync("Horror");
                Assert.Equal("Horror", category.CategoryId);
            }
        }

        [Fact]
        public async Task GetClubPostByIdShouldReturnClubPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                var clubPost = await _repo.GetClubPostByIdAsync(1);
                Assert.Equal("Good Book", clubPost.Post);
            }
        }

        [Fact]
        public async Task GetClubPostByBookClubShouldReturnClubPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                var clubPosts = await _repo.GetClubPostByBookClubAsync(1);
                foreach (Model.ClubPost clubPost in clubPosts)
                {
                    Assert.Equal(1, clubPost.BookClubId);
                }
            }
        }

        [Fact]
        public async Task GetUserCommentShouldReturnUserComment()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentRepo _repo = new UserCommentRepo(context);
                var comment = await _repo.GetCommentByIdAsync(1);
                Assert.Equal("Right", comment.Message);
            }
        }

        [Fact]
        public async Task GetClubCommentShouldReturnClubComment()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubCommentRepo _repo = new ClubCommentRepo(context);
                var comment = await _repo.GetCommentByIdAsync(1);
                Assert.Equal("Wrong", comment.Message);
            }
        }

        [Fact]
        public async Task GetUserCommentByUserPostShouldReturnComments()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentRepo _repo = new UserCommentRepo(context);
                var comments = await _repo.GetCommentByUserPostAsync(1);
                foreach (Model.UserComment comment in comments)
                {
                    Assert.Equal(1, comment.UserPostID);
                }

            }
        }

        [Fact]
        public async Task GetClubCommentByClubPostShouldReturnComments()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubCommentRepo _repo = new ClubCommentRepo(context);
                var comments = await _repo.GetCommentByClubIdAsync(1);
                foreach (Model.ClubComment comment in comments)
                {
                    Assert.Equal(1, comment.ClubPostID);
                }

            }
        }

        [Fact]
        public async Task GetFollowersByClubShouldReturnUsers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                var followers = await _repo.GetFollowersByClubAsync(1);
                foreach (Model.User user in followers)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", user.UserEmail);
                }
            }
        }

        [Fact]
        public async Task GetFollowingByUserShouldReturnUsers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                var following = await _repo.GetFollowingByUserAsync("bryce.zimbelman@icloud.com");
                foreach (Model.User user in following)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", user.UserEmail);
                }
            }
        }

        [Fact]
        public async Task IsFollowingByUserShouldReturnBool()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                var following = await _repo.IsFollowingAsync("bryce.zimbelman@icloud.com", "bryce.zimbelman@revature.net");
                Assert.True(following);
            }
        }

        [Fact]
        public async Task GetFollowingByUserShouldReturnBookClubs()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                var bookClubs = await _repo.GetFollowingByUserAsync("bryce.zimbelman@revature.net");
                foreach (Model.BookClub bookClub in bookClubs)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", bookClub.UserEmail);
                }
            }
        }

        [Fact]
        public async Task GetFollowersByUserShouldReturnUsers()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                var followers = await _repo.GetFollowersByUserAsync("bryce.zimbelman@icloud.com");
                foreach (Model.User user in followers)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", user.UserEmail);
                }
            }
        }

        [Fact]
        public async Task GetUserShouldReturnUser()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserRepo _repo = new UserRepo(context);
                var user = await _repo.GetUserByEmailAsync("bryce.zimbelman@revature.net");
                Assert.Equal("bryce.zimbelman@revature.net", user.UserEmail);

            }
        }

        [Fact]
        public async Task GetUserPostShouldReturnUserPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                var userPost = await _repo.GetUserPostByIdAsync(1);
                Assert.Equal("You all should join that other BookClub", userPost.Post);

            }
        }

        [Fact]
        public async Task GetUserPostByUserShouldReturnUserPosts()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                var userPosts = await _repo.GetUserPostByUserAsync("bryce.zimbelman@revature.net");
                foreach (Model.UserPost userPost in userPosts)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", userPost.UserEmail);
                }
            }
        }

        [Fact]
        public async Task GetClubPostLikeByClubPostShouldReturnClubPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostLikesRepo _repo = new ClubPostLikesRepo(context);
                var clubPostLikes = await _repo.GetClubPostLikesByClubPostAsync(1);
                foreach (Model.ClubPostLikes likes in clubPostLikes)
                {
                    Assert.Equal(1, likes.ClubPostId);
                }
            }
        }

        [Fact]
        public async Task GetClubPostLikesByIdShouldReturnClubPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostLikesRepo _repo = new ClubPostLikesRepo(context);
                var clubPostLike = await _repo.GetClubPostLikesByIdAsync(1);
                Assert.Equal(1, clubPostLike.ClubPostLikesId);
            }
        }

        [Fact]
        public async Task GetUserPostLikeByClubPostShouldReturnUserPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostLikesRepo _repo = new UserPostLikesRepo(context);
                var userPostLikes = await _repo.GetUserPostLikesByUserPostAsync(1);
                foreach (Model.UserPostLikes likes in userPostLikes)
                {
                    Assert.Equal(1, likes.UserPostId);
                }
            }
        }

        [Fact]
        public async Task GetUserPostLikesByIdShouldReturnUserPostLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostLikesRepo _repo = new UserPostLikesRepo(context);
                var userPostLike = await _repo.GetUserPostLikesByIdAsync(1);
                Assert.Equal(1, userPostLike.UserPostLikesId);
            }
        }

        [Fact]
        public async Task GetCommentLikeByUserPostShouldReturnUserPostCommentLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentLikesRepo _repo = new UserCommentLikesRepo(context);
                var commentLikes = await _repo.GetCommentLikesByUserPostAsync(1);
                foreach (Model.UserCommentLikes likes in commentLikes)
                {
                    Assert.Equal(1, likes.UserPostId);
                }
            }
        }

        [Fact]
        public async Task GetCommentLikesByIdShouldReturnCommentLikes()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentLikesRepo _repo = new UserCommentLikesRepo(context);
                var commentLike = await _repo.GetCommentLikesByIdAsync(1);
                Assert.Equal(1, commentLike.UserCommentLikesId);
            }
        }

        [Fact]
        public async Task GetUserFeedShouldReturnUserFeed()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserFeedRepo _repo = new UserFeedRepo(context);
                var userFeeds = await _repo.GetuserFeedAsync("bryce.zimbelman@revature.net");
                foreach (Model.UserFeed post in userFeeds)
                {
                    Assert.Equal("bryce.zimbelman@revature.net", post.UserEmail);
                }
            }
        }

        [Fact]
        public async Task AddBookShouldAddBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookRepo _repo = new BookRepo(context);
                await _repo.AddBookAsync(new Model.Book("135798642", "Interesting Book", "Me", "Boring"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Books.FirstOrDefault(books => books.ISBN == "135798642");
                Assert.NotNull(result);
                Assert.Equal("Interesting Book", result.Title);
            }
        }

        [Fact]
        public async Task AddBookClubShouldAddBookClub()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBookClubRepo _repo = new BookClubRepo(context);
                await _repo.AddBookClubAsync(new Model.BookClub("Good Reads", "Interestings Reads", "987123456", "bryce.zimbelman@revature.net"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BookClubs.FirstOrDefault(bookClub => bookClub.BookClubId == 3);
                Assert.NotNull(result);
                Assert.Equal("Good Reads", result.Name);
            }
        }

        [Fact]
        public async Task AddBooksReadShouldAddBooksRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksReadRepo _repo = new BooksReadRepo(context);
                await _repo.AddBooksReadAsync(new Model.BooksRead("bryce.zimbelman@icloud.com", "135798642", 50));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BooksRead.FirstOrDefault(booksRead => booksRead.BooksReadId == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public async Task AddBooksToReadShouldAddBooksToRead()
        {
            using (var context = new BookClubDBContext(options))
            {
                IBooksToReadRepo _repo = new BookToReadRepo(context);
                await _repo.AddBooksReadAsync(new Model.BooksToRead("bryce.zimbelman@revature.net", "135798642"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.BooksToRead.FirstOrDefault(booksToRead => booksToRead.BooksToReadId == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public async Task AddCategoryShouldAddCategory()
        {
            using (var context = new BookClubDBContext(options))
            {
                ICategoryRepo _repo = new CategoryRepo(context);
                await _repo.AddCategoryAsync(new Model.Category("Adventure"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Categories.FirstOrDefault(category => category.CategoryId == "Adventure");
                Assert.NotNull(result);
                Assert.Equal("Adventure", result.CategoryId);
            }
        }

        [Fact]
        public async Task AddClubPostShouldAddClubPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostRepo _repo = new ClubPostRepo(context);
                await _repo.AddClubPostAsync(new Model.ClubPost("bryce.zimbelman@revature.net", "Boring Book!", 1, 0, 10, new DateTime()));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.ClubPosts.FirstOrDefault(clubPost => clubPost.ClubPostId == 3);
                Assert.NotNull(result);
                Assert.Equal("Boring Book!", result.Post);
            }
        }

        [Fact]
        public async Task AddUserCommentShoulAddUserComment()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserCommentRepo _repo = new UserCommentRepo(context);
                await _repo.AddCommentAsync(new Model.UserComment("bryce.zimbelman@revature.net", 2, "maybe"));
            }

            using (var assertcontext = new BookClubDBContext(options))
            {
                var result = assertcontext.UserComments.FirstOrDefault(comment => comment.UserCommentId == 3);
                Assert.NotNull(result);
                Assert.Equal(2, result.UserPostID);
            }
        }

        [Fact]
        public async Task AddClubCommentShoulAddClubComment()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubCommentRepo _repo = new ClubCommentRepo(context);
                await _repo.AddCommentAsync(new Model.ClubComment("bryce.zimbelman@revature.net", 2, "maybe"));
            }

            using (var assertcontext = new BookClubDBContext(options))
            {
                var result = assertcontext.ClubComments.FirstOrDefault(comment => comment.ClubCommentId == 3);
                Assert.NotNull(result);
                Assert.Equal(2, result.ClubPostID);
            }
        }

        [Fact]
        public async Task AddFavoriteBookShouldAddFavoriteBook()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFavoriteBookRepo _repo = new FavoriteBookRepo(context);
                await _repo.AddBooksReadAsync(new Model.FavoriteBook("bryce.zimbelman@revature.net", "135798642"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FavoriteBooks.FirstOrDefault(favoriteBook => favoriteBook.FavoriteBookId == 3);
                Assert.NotNull(result);
                Assert.Equal("135798642", result.ISBN);
            }
        }

        [Fact]
        public async Task AddFollowClubShouldAddFollowClub()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowClubRepo _repo = new FollowClubRepo(context);
                await _repo.AddFollowClubAsync(new Model.FollowClub("bryce.zimbelman@revature.net", 3));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FollowClubs.FirstOrDefault(clubFollower => clubFollower.FollowClubId == 3);
                Assert.NotNull(result);
                Assert.Equal(3, result.BookClubId);
            }
        }

        [Fact]
        public async Task AddFollowUserShouldAddFollowUser()
        {
            using (var context = new BookClubDBContext(options))
            {
                IFollowUserRepo _repo = new FollowUserRepo(context);
                await _repo.AddFollowUserAsync(new Model.FollowUser("bryce.zimbelman@gmail.com", "bryce.zimbelman@revature.net"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.FollowUsers.FirstOrDefault(userFollower => userFollower.FollowUserId == 3);
                Assert.NotNull(result);
                Assert.Equal("bryce.zimbelman@gmail.com", result.FollowerEmail);
                Assert.Equal("bryce.zimbelman@revature.net", result.UserEmail);
            }
        }

        [Fact]
        public async Task AddUserShouldAddUser()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserRepo _repo = new UserRepo(context);
                await _repo.AddUserAsync(new Model.User("bryce.zimbelman@gmail.com", "Password!", "13590 SW Electric St", 10));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.Users.FirstOrDefault(user => user.UserEmail == "bryce.zimbelman@gmail.com");
                Assert.NotNull(result);
                Assert.Equal(10, result.PagesRead);
            }
        }

        [Fact]
        public async Task AddUserPostShouldAddUserPost()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostRepo _repo = new UserPostRepo(context);
                await _repo.AddUserPostAsync(new Model.UserPost("bryce.zimbelman@icloud.com", "Does anyone else read Harry Potter?", 24, 3, new DateTime()));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.UserPosts.FirstOrDefault(userPost => userPost.UserPostId == 3);
                Assert.NotNull(result);
                Assert.Equal(24, result.TotalLike);
            }
        }
        [Fact]
        public async Task AddClubPostLikShouldAddClubPostLike()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostLikesRepo _repo = new ClubPostLikesRepo(context);
                await _repo.AddClubPostLikeAsync(new Model.ClubPostLikes(true, false, 1, "bryce.zimbelman@gmail.com"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.ClubPostLikes.FirstOrDefault(like => like.ClubPostLikesId == 3);
                Assert.NotNull(result);
                Assert.Equal("bryce.zimbelman@gmail.com", result.UserEmail);
            }
        }

        [Fact]
        public async Task AddClubPostLikShouldAddClubPostLike2()
        {
            using (var context = new BookClubDBContext(options))
            {
                IClubPostLikesRepo _repo = new ClubPostLikesRepo(context);
                await _repo.AddClubPostLikeAsync(new Model.ClubPostLikes
                {
                    Like = false,
                    Dislike = true,
                    ClubPostId = 1,
                    UserEmail = "bryce.zimbelman@revature.net"
                });
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.ClubPostLikes.FirstOrDefault(like => like.ClubPostLikesId == 2);
                Assert.NotNull(result);
                Assert.NotEqual("bryce.zimbelman@revature.net", result.UserEmail);
            }
        }

        [Fact]
        public async Task AddUserPostLikeShouldAddUserPostLike()
        {
            using (var context = new BookClubDBContext(options))
            {
                IUserPostLikesRepo _repo = new UserPostLikesRepo(context);
                await _repo.AddUserPostLikeAsync(new Model.UserPostLikes(true, false, 1, "bryce.zimbelman@gmail.com"));
            }

            using (var assertContext = new BookClubDBContext(options))
            {
                var result = assertContext.UserPostLikes.FirstOrDefault(like => like.UserPostLikesId == 3);
                Assert.NotNull(result);
                Assert.Equal("bryce.zimbelman@gmail.com", result.UserEmail);
            }
        }
    }
}
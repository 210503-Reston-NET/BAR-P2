using Microsoft.EntityFrameworkCore;
using BCModel;

namespace BCDL
{
    public class BookClubDBContext : DbContext
    {
        protected BookClubDBContext()
        {
        }

        public BookClubDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookClub> BookClubs { get; set; }
        public DbSet<BooksRead> BooksRead { get; set; }
        public DbSet<BooksToRead> BooksToRead { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClubPost> ClubPosts { get; set; }
        public DbSet<UserComment> UserComments { get; set; }
        public DbSet<ClubComment> ClubComments { get; set; }
        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<FollowUser> FollowUsers { get; set; }
        public DbSet<FollowClub> FollowClubs { get; set; }
        public DbSet<ClubPostLikes> ClubPostLikes { get; set; }
        public DbSet<UserPostLikes> UserPostLikes { get; set; }
        public DbSet<UserCommentLikes> UserCommentLikes { get; set; }
        public DbSet<ClubCommentLikes> ClubCommentLikes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(user => user.UserEmail);
            modelBuilder.Entity<Category>()
                .HasKey(cat => cat.CategoryId);
            modelBuilder.Entity<Book>()
                .HasKey(book => book.ISBN);
            modelBuilder.Entity<BookClub>()
                .Property(bookClub => bookClub.BookClubId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserPost>()
                .Property(userPostt => userPostt.UserPostId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ClubPost>()
                .Property(clubPostt => clubPostt.ClubPostId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserComment>()
                .Property(userComment => userComment.UserCommentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ClubComment>()
                .Property(clubComment => clubComment.ClubCommentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FavoriteBook>()
                .Property(fav => fav.FavoriteBookId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<BooksToRead>()
                .Property(read => read.BooksToReadId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<BooksRead>()
                .Property(read => read.BooksReadId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FollowClub>()
                .Property(FClub => FClub.FollowClubId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FollowUser>()
                .Property(FUser => FUser.FollowUserId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ClubPostLikes>()
                .Property(ClubPostLikes => ClubPostLikes.ClubPostLikesId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserPostLikes>()
                .Property(UserPostLikes => UserPostLikes.UserPostLikesId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserCommentLikes>()
                .Property(UserCommentLikes => UserCommentLikes.UserCommentLikesId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ClubCommentLikes>()
                .Property(ClubCommentLikes => ClubCommentLikes.ClubCommentLikesId)
                .ValueGeneratedOnAdd();
        }
    }
}

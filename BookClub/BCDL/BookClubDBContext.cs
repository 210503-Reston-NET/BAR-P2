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

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookClub> BookClubs { get; set; }
        public DbSet<BooksRead> BooksRead { get; set; }
        public DbSet<BooksToRead> BooksToRead { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClubPost> ClubPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<FollowUser> FollowUsers { get; set; }
        public DbSet<FollowClub> FollowClubs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(user => user.Email);
            modelBuilder.Entity<Category>()
                .HasKey(cat => cat.Name);
            modelBuilder.Entity<Book>()
                .HasKey(book => book.ISBN);
            modelBuilder.Entity<BookClub>()
                .Property(bookClub => bookClub.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Achievement>()
                .Property(achievement => achievement.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserPost>()
                .Property(userPostt => userPostt.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ClubPost>()
                .Property(clubPostt => clubPostt.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Comment>()
                .Property(comment => comment.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Recommendation>()
                .Property(rec => rec.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FavoriteBook>()
                .Property(fav => fav.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<BooksToRead>()
                .Property(read => read.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<BooksRead>()
                .Property(read => read.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FollowClub>()
                .Property(FClub => FClub.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<FollowUser>()
                .Property(FUser => FUser.Id)
                .ValueGeneratedOnAdd();
        }
    }
}

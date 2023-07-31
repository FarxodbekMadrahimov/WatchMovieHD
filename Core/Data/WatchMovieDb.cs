using Core.models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace Core.data
{
    public class WatchMovieHD : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=ing0077K; Database=WatchMovieHD");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<film> films { get; set; }
        public DbSet<duration> durations { get; set; }
        public DbSet<Achivement> achives { get; set; }  
        public DbSet<Achivements> Achivements { get; set; }
        public DbSet<Viewedfilms> Viewedfilms { get; set; }
        public DbSet<likedFilms> LikedFilms { get; set; }
        public DbSet<Users> User { get; set; }
        //public void Adduser(string newusers)
        //{
        //    var db = new WatchMovieHD();
        //    var user = new Users(newusers);
        //    db.Add(user);
        //    db.SaveChanges();

        //}
    }

    
}
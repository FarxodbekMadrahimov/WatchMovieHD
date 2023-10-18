namespace Core.data
{
    public class WatchMovieHD : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=ing0077K; Database=WatchMovieHD");
            base.OnConfiguring(optionsBuilder);
            //
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
        }
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                new Film()
                {
                    Id = 1,
                    Type = "movie",
                    Name = "the shawshank redemption",
                    Genre = "drama",
                    Year = "1994",
                    Duration = "142 min",
                    Producer = "frank darabont",
                    //Achivement = "academy",
                    Country = "usa"
                },
                new Film()
                {
                    Id = 2,
                    Type = "movie",
                    Name = "The Godfather",
                    Genre = "Crime",
                    Year = "1972",
                    Duration = "175 min ",
                    Producer = "Francis Ford Coppola",
                    //Achivement = "Academy",
                    Country = "USA"
                },
                new Film()
                {
                    Id = 3,
                    Type = "movie",
                    Name = "Inception",
                    Genre = "Fantastic",
                    Year = "2010",
                    Duration = "148 min",
                    Producer = "Christopher Nolan",
                    //Achivement = "Academy",
                    Country = "USA"
                }

                );
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 3,
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "user123",
                    email = "user123@email.com",
                    password = "secure_password123"
                },
                new Users
                {
                    Id = 4,
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "movie_lover",
                    email = "movie_lover@email.com",
                    password = "strong_pass_456"
                }

                );
            modelBuilder.Entity<Achivement>().HasData(
                new Achivement
                {
                    Id = 1,
                    Name = "Academy",
                    Description = "Awarded for outstanding achievements in the film industry."
                },
                new Achivement
                {
                    Id = 2,
                    Name = "GoldenGlobe",
                    Description = "Recognizes excellence in film and television."
                },
                new Achivement
                {
                    Id = 3,
                    Name = "Oscar",
                    Description = "Recognizes excellence in film and television."
                }

                 );
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    SeedData(modelBuilder);
        //}
        public DbSet<Film> Films { get; set; }
        public DbSet<Achivement> achives { get; set; }  
        public DbSet<Achivements> achivments { get; set; }  
        public DbSet<Viewedfilms> Viewedfilms { get; set; }
        public DbSet<likedFilms> LikedFilms { get; set; }
        public DbSet<Users> User { get; set; }
        //public void SeedData()
        //{
        //    if (!Films.Any())
        //    {
        //        Films.AddRange(FilmSeedData.Films);
        //    }

        //    if (!achives.Any())
        //    {
        //        achives.AddRange(FilmAwardSeedData.FilmAwards);
        //    }

        //    if (!User.Any())
        //    {
        //        User.AddRange(UserSeedData.Users);
        //    }

        //    SaveChanges();
        //}
        //public void Adduser(string newusers)
        //{
        //    var db = new WatchMovieHD();
        //    var user = new Users(newusers);
        //    db.Add(user);
        //    db.SaveChanges();

        //}
    }

    
}
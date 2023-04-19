
namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {         
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Superman2",
                    Description = "Superman is a superhero who appears in American comic books published by DC Comics. The character was created by writer Jerry Siegel and artist Joe Shuster, and debuted in the comic book Action Comics #1 (cover-dated June 1938 and published April 18, 1938).[1] Superman has been adapted to a number of other media, including radio serials, novels, films, television shows, theater productions, and video games.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/35/Supermanflying.png",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Batman",
                    Description = "Batman[a] is a superhero appearing in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and debuted in the 27th issue of the comic book Detective Comics on March 30, 1939. In the DC Universe continuity, Batman is the alias of Bruce Wayne, a wealthy American playboy, philanthropist, and industrialist who resides in Gotham City.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c7/Batman_Infobox.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Spider-Man",
                    Description = "Spider-Man is a superhero appearing in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko, he first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books. He has been featured in comic books, television shows, films, video games, novels, and plays.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "Spider-Man3",
                    Description = "Spider-Man is a superhero appearing in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko, he first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books. He has been featured in comic books, television shows, films, video games, novels, and plays.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png",
                    Price = 9.99m
                }
             );
        }

        public DbSet<Product> Products { get; set; }

       
    }
}

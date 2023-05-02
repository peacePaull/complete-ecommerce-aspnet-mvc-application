using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var  serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            //Cinema
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                {
                    new Cinema()
                    {
                        Name = "Filmhouse IMAX",
                        Logo = "https://www.zamxahotels.com/guides/wp-content/uploads/2020/01/Imax-film-theatre-lekki-lagos-nigeria-3.jpg",
                        Description = "Filmhouse IMAX is the first IMAX (image maximum) movie theatre in Nigeria launched by Filmhouse Cinema, and shows movies in both 3D and 2D for both kids and adults."

                    },

                    new Cinema()
                    {
                        Name = "Genesis Deluxe Cinemas",
                        Logo = "https://www.blog.solutionwheels.com/wp-content/uploads/2020/11/download-1-5.png",
                        Description = "Genesis Deluxe Cinemas is movie viewing theater based in Lagos providing shows and latest movies for its viewers."

                    },
                    
                    new Cinema()
                    {
                        Name = "Silverbird Cinemas",
                        Logo = "data:image/png;base64,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",
                        Description = "Silverbird Cinemas provide Nigerians and expatriates day and date releases of blockbuster movies in an environment and ambience that is comparable to, and sometimes arguably better than, the service quality available in developed markets."

                    },
                    
                    new Cinema()
                    {
                        Name = "Ozone Cinemas",
                        Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx5vfdROq9_U-nv9U-w1CMOw2D011c-b3XzA&usqp=CAU",
                        Description = "Ozone Cinemas is a four-screen cinema with 619 luxury seats offering daily show of latest movies.\r\n\r\n"

                    },
                    
                    new Cinema()
                    {
                        Name = "The Filmhouse",
                        Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRfnqUMj7MA3Rj753RyaywvwOHNt4jiAsUc3w&usqp=CAU",
                        Description = "The Filmhouse is a dynamic film exhibition company experienced in cinema operation and development, film distribution and film entertainment."

                    }
                });
                context.SaveChanges();
            }

            //Actors
            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        FullName = "Actor 1",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 2",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 3",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 4",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 5",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                    },
                });
                context.SaveChanges();
            }

            //Producers
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                {
                    new Producer()
                    {
                        FullName = "Producer 1",
                        Bio = "This is the Bio of the first Producer",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 2",
                        Bio = "This is the Bio of the second Producer",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 3",
                        Bio = "This is the Bio of the third Producer",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 4",
                        Bio = "This is the Bio of the fourth Producer",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 5",
                        Bio = "This is the Bio of the fifth Producer",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                    }
                });
                context.SaveChanges();
            }

            //Movies
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name = "Life",
                        Description = "This is the Life movie description",
                        Price = 3000,
                        ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 3,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Documentary
                    },
                    new Movie()
                    {
                        Name = "The ShawShank Redemption",
                        Description = "This is the ShawShank Redemption description",
                        Price = 2500,
                        ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(3),
                        CinemaId = 1,
                        ProducerId = 1,
                        MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                    {
                        Name = "Ghost",
                        Description = "This is the Ghost movie description",
                        Price = 3000,
                        ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7),
                        CinemaId = 4,
                        ProducerId = 4,
                        MovieCategory = MovieCategory.Horror
                    },
                    new Movie()
                    {
                        Name = "Race",
                        Description = "This is the Race movie description",
                        Price = 3500,
                        ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-5),
                        CinemaId = 1,
                        ProducerId = 2,
                        MovieCategory = MovieCategory.Documentary
                    },
                    new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the Scoob movie description",
                        Price = 3000,
                        ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Cartoon
                    },
                    new Movie()
                    {
                        Name = "Cold Soles",
                        Description = "This is the Cold Soles movie description",
                        Price = 3000,
                        ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                        StartDate = DateTime.Now.AddDays(3),
                        EndDate = DateTime.Now.AddDays(20),
                        CinemaId = 1,
                        ProducerId = 5,
                        MovieCategory = MovieCategory.Drama
                    },
                });
                context.SaveChanges();
            }

            //Actors & Movies
            if (!context.Actor_Movies.Any())
            {
                context.Actor_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie()
                    {
                        ActorId = 1,
                        MovieId = 1
                    },
                    new Actor_Movie()
                    {
                        ActorId = 3,
                        MovieId = 1
                    },

                    new Actor_Movie()
                    {
                        ActorId = 1,
                        MovieId = 2
                    },
                    new Actor_Movie()
                    {
                        ActorId = 4,
                        MovieId = 2
                    },

                    new Actor_Movie()
                    {
                        ActorId = 1,
                        MovieId = 3
                    },
                    new Actor_Movie()
                    {
                        ActorId = 2,
                        MovieId = 3
                    },
                    new Actor_Movie()
                    {
                        ActorId = 5,
                        MovieId = 3
                    }, 
                    new Actor_Movie()
                    {
                        ActorId = 2,
                        MovieId = 4
                    },
                    new Actor_Movie()
                    {
                        ActorId = 3,
                        MovieId = 4
                    },
                    new Actor_Movie()
                    {
                        ActorId = 4,
                        MovieId = 4
                    },
                    new Actor_Movie()
                    {
                        ActorId = 2,
                        MovieId = 5
                    },
                    new Actor_Movie()
                    {
                        ActorId = 3,
                        MovieId = 5
                    },
                    new Actor_Movie()
                    {
                        ActorId = 4,
                        MovieId = 5
                    },
                    new Actor_Movie()
                    {
                        ActorId = 5,
                        MovieId = 5
                    },
                    new Actor_Movie()
                    {
                        ActorId = 3,
                        MovieId = 6
                    },
                    new Actor_Movie()
                    {
                        ActorId = 4,
                        MovieId = 6
                    },
                    new Actor_Movie()
                    {
                        ActorId = 5,
                        MovieId = 6
                    }
                });
                context.SaveChanges();
            }

        }
    }
}
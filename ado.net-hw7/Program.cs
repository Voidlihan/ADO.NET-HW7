using System;

namespace ado.net_hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new Context())
            {
                var user1 = new User
                {
                    Rate = 5,   
                };
                var user2 = new User
                {
                    Rate = 3
                };
                var rating1 = new Rating
                {
                    rating_users = user1
                };
                var rating2 = new Rating
                {
                    rating_users = user2
                };
                var userrating1 = new UserRating
                {
                    rating = rating1,
                    users = user1
                };
                var userrating2 = new UserRating
                {
                    rating = rating2,
                    users = user2
                };
                var videogame1 = new Videgame
                {
                    Name = "Fallout",
                    Description = "Postapocalypse game"
                };
                var videogamerating1 = new VideogameRatings
                {
                    videgames = videogame1,
                    ratings = rating1
                };
                var videogamerating2 = new VideogameRatings
                {
                    videgames = videogame1,
                    ratings = rating2
                };
                context.Add(user1);
                context.Add(user2);
                context.Add(rating1);
                context.Add(rating2);
                context.Add(userrating1);
                context.Add(userrating2);
                context.Add(videogame1);
                context.Add(videogamerating1);
                context.Add(videogamerating2);
                var res = from a in user1 where (user1.Rate / user2.Rate) select a;
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public class Rating : Entity
    {
        public User rating_users { get; set; }
        public ICollection<UserRating> Users { get; set; } = new List<UserRating>();
    }
}

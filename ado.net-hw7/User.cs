using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public class User : Entity
    {
        public int Rate { get; set; }
        public ICollection<UserRating> userRatings { get; set; } = new List<UserRating>();
    }
}

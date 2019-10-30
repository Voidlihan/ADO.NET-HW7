using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public class UserRating : Entity
    {
        public User users { get; set; }
        public Rating rating { get; set; }
    }
}

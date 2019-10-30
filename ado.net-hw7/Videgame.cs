using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public class Videgame : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<VideogameRatings> Ratings { get; set; } = new List<VideogameRatings>();
    }
}

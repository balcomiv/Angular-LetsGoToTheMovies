using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLetsGoToTheMovies.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }
    }
}

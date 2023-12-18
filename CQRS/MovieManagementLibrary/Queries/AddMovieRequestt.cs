using MediatR;
using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Queries
{
    public class AddMovieRequestt :IRequest<MovieModel>
    {
        public MovieModel movie { get; set; }

        public AddMovieRequestt(MovieModel movie)
        {
            this.movie = movie;
        }
    }
}

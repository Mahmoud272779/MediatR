using MediatR;
using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Queries
{
    public class GetMovieByIdRequest:IRequest<MovieModel>
    {
        public GetMovieByIdRequest(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}

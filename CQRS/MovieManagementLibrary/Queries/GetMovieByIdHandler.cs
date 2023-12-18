using MediatR;
using MovieManagementLibrary.Data;
using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Queries
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdRequest, MovieModel>
    {
        private readonly IMediator mediator;

        public GetMovieByIdHandler( IMediator mediator)
        {
            
            this.mediator = mediator;
        }

        public async Task<MovieModel> Handle(GetMovieByIdRequest request, CancellationToken cancellationToken)
        {
            var movies =await  mediator.Send(new GetMovieListQuery());
            return movies.FirstOrDefault(m=>m.Id==request.id);
        }
    }
}

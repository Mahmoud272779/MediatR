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
    public class AddMovieHandler : IRequestHandler<AddMovieRequestt, MovieModel>
    {
        private readonly IDataRepo _dataRepository;

        public AddMovieHandler(IDataRepo dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<MovieModel> Handle(AddMovieRequestt request, CancellationToken cancellationToken)
        {
            _dataRepository.AddMovie(request.movie);
            return request.movie;
        }
    }
}

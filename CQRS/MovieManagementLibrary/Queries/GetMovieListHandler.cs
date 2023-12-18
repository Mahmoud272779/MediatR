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
    
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepo _dataRepo;

        public GetMovieListHandler(IDataRepo dataRepo)
        {
            _dataRepo = dataRepo;
        }

        public async Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return _dataRepo.GetMovies();
        }
    }
}

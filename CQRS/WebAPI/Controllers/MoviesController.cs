using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;
using System.Runtime.Intrinsics.X86;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("AllMovies")]
        public async Task <List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }


        [HttpGet("GetById")]
        public async Task<MovieModel> GetbyId(int id)
        {
            return await _mediator.Send(new GetMovieByIdRequest( id));
        }

        [HttpPost]
        public async Task<MovieModel> addMovie(MovieModel movie)
        {
            return await _mediator.Send(new AddMovieRequestt(movie));
        }
    }
}

﻿using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Data
{
    public interface IDataRepo
    {
        List<MovieModel> GetMovies();
        MovieModel AddMovie(MovieModel movie);
    }
}

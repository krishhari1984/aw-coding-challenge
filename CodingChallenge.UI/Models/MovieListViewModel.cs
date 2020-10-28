using System.Collections.Generic;
using CodingChallenge.DataAccess.Models;

namespace CodingChallenge.UI.Models
{
    public class MovieListViewModel
    {
        public List<Movie> Movies { get; set; }
        public GridOptions GridOptions { get; set; }
        public string Category { get; set; }
        public List<Movie> Data { get; set; }
    }
}
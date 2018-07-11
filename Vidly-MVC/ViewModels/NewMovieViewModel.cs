using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BerrasCinema;
using BerrasCinema.Models;

namespace BerrasCinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly CinemaDBContext _context;

        public MoviesController(CinemaDBContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
        }
    }
}

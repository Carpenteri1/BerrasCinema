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
    public class OrdersController : Controller
    {
        private readonly CinemaDBContext _context;
        private const int NoSeatsLeft = 0;

        public OrdersController(CinemaDBContext context)
        {
            _context = context;
        }

        public IActionResult Error()
        {
            return View();
        }


        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.TicketOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Index()
        {
            ViewBag.SeatsLeft = new SelectList(_context.Movie.ToList(), "SeatsLeft", "SeatsLeft");
            ViewBag.MovieList = new SelectList(_context.Movie.ToList(), "MovieName", "MovieName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                foreach(var s in _context.Movie)
                {
                    if (order.MovieName == s.MovieName && !s.SeatsLeft.Equals(NoSeatsLeft))
                    {
                        int tempAmmount = s.SeatsLeft - order.AmmountOfTickets;
                        if(tempAmmount >= 0)
                        {
                            order.MovieID = s.MovieID;
                            s.SeatsLeft -= order.AmmountOfTickets;
                        }
                    }
                }

                if (!order.MovieID.Equals(0))
                {
                    Order _order = new Order
                    {
                        OrderID = order.OrderID,
                        AmmountOfTickets = order.AmmountOfTickets,
                        FirstName = order.FirstName,
                        LastName = order.LastName,
                        Email = order.Email,
                        ConfirmEmail = order.ConfirmEmail,
                        MovieName = order.MovieName,
                        MovieID = order.MovieID,
                    };

                    _context.Add(_order);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details), new {id = _order.OrderID});
                }
                else
                {
                    return RedirectToAction(nameof(Error));
                }
         
            }
            return View(order);
        }

    }
}

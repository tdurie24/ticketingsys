using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Controllers
{
    /// <summary>
    /// Ticket Controller
    /// </summary>
    public class TicketsController : Controller
    {
        private ITicketService ticketService;
        public TicketsController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }
        public async Task<IActionResult> Index()
        {
            var tickets = await this.ticketService.GetTicketsAsync(0).ConfigureAwait(false) ;
            return View(tickets);
        }
    }
}
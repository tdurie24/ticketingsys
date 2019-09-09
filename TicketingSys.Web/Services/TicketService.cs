using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketingSys.Data;
using TicketingSys.Domain;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Services
{
    /// <summary>
    /// Ticketing Service
    /// </summary>
    /// <seealso cref="TicketingSys.Domain.Contracts.ITicketService" />
    public class TicketService : ITicketService
    {
        private TicketingDbContext ticketingDbContext;
        public TicketService(TicketingDbContext ticketingDbContext)
        {
            this.ticketingDbContext = ticketingDbContext;
        }

        /// <summary>
        /// Creates the ticket asynchronous.
        /// </summary>
        /// <param name="ticket">The ticket.</param>
        /// <returns></returns>
        public async Task<int> CreateTicketAsync(Ticket ticket)
        {
            try
            {
                await this.ticketingDbContext.Tickets.AddAsync(ticket).ConfigureAwait(false);
                return this.ticketingDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the tickets asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<List<Ticket>> GetTicketsAsync(int userId)
        {
            try
            {
                var tickets = new List<Ticket>();
                tickets = userId != 0
                    ? await this.ticketingDbContext.Tickets.Where(x => x.UserId == userId).ToListAsync()
                    : await this.ticketingDbContext.Tickets.ToListAsync();

                return tickets;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketingSys.Data;
using TicketingSys.Domain;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Services
{
    /// <summary>
    /// ResolutionStatus Service
    /// </summary>
    /// <seealso cref="TicketingSys.Domain.Contracts.IResolutionStatusService" />
    public class ResolutionStatusService : IResolutionStatusService
    {
        private TicketingDbContext ticketingDbContext;
        public ResolutionStatusService(TicketingDbContext ticketingDbContext)
        {
            this.ticketingDbContext = ticketingDbContext;
        }

        /// <summary>
        /// Gets the resolution status asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<ResolutionStatus>> GetResolutionStatusAsync()
        {
            try
            {
                return await this.ticketingDbContext.ResolutionStatuses.ToListAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketingSys.Data;
using TicketingSys.Domain;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Services
{
    /// <summary>
    /// IIssueSeverity Service
    /// </summary>
    /// <seealso cref="TicketingSys.Domain.Contracts.IIssueSeverityService" />
    public class IssueSeverityService : IIssueSeverityService
    {
        private TicketingDbContext ticketingDbContext;
        public IssueSeverityService(TicketingDbContext ticketingDbContext)
        {
            this.ticketingDbContext = ticketingDbContext;
        }

        /// <summary>
        /// Gets the issue severities asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<IssueSeverity>> GetIssueSeveritiesAsync()
        {
            try
            {
                return await this.ticketingDbContext.IssueSeverities.ToListAsync(); ;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}

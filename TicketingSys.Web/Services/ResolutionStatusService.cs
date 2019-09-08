using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketingSys.Data;
using TicketingSys.Domain;
using TicketingSys.Domain.Contracts;

namespace TicketingSys.Web.Services
{
    public class ResolutionStatusService : IResolutionStatusService
    {
        private TicketingDbContext ticketingDbContext;
        public ResolutionStatusService(TicketingDbContext ticketingDbContext)
        {
            this.ticketingDbContext = ticketingDbContext;
        }

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

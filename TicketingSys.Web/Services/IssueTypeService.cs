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
    /// IssueType Service
    /// </summary>
    /// <seealso cref="TicketingSys.Domain.Contracts.IIssueTypeService" />
    public class IssueTypeService : IIssueTypeService
    {
        private TicketingDbContext ticketingDbContext;
        public IssueTypeService(TicketingDbContext ticketingDbContext)
        {
            this.ticketingDbContext = ticketingDbContext;
        }

        /// <summary>
        /// Gets the issue types asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<IssueType>> GetIssueTypesAsync()
        {
            try
            {
                return await this.ticketingDbContext.IssueTypes.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

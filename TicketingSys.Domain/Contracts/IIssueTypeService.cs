using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSys.Domain.Contracts
{
    public interface IIssueTypeService
    {
        Task<List<IssueType>> GetIssueTypesAsync();
    }
}

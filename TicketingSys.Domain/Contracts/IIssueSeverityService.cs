using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketingSys.Domain.Contracts
{
    public interface IIssueSeverityService
    {
        Task<List<IssueSeverity>> GetIssueSeveritiesAsync();
    }
}

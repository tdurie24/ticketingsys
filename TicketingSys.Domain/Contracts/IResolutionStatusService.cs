using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketingSys.Domain.Contracts
{
    public interface IResolutionStatusService
    {
        Task<List<ResolutionStatus>> GetResolutionStatusAsync();
    }
}

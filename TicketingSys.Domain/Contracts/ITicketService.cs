using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketingSys.Domain.Contracts
{
    public interface ITicketService
    {
        Task<int> CreateTicketAsync(Ticket ticket);
        Task<List<Ticket>> GetTicketsAsync(int userId);
    }
}

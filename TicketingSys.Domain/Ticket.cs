using System;

namespace TicketingSys.Domain
{        
    public class Ticket
    {
        public int TicketId { get; set; }
        public int IssueTypeId { get; set; }
        public int IssueSeverityId { get; set; }
        public int ResolutionStatusId { get; set; }
        public string ResolutionSteps { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
    }
}

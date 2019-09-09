using System;

namespace TicketingSys.Domain
{
    /// <summary>
    /// Ticket Model 
    /// </summary>
    public class Ticket
    {
        public int TicketId { get; set; }
        public int IssueTypeId { get; set; }
        public int IssueSeverityId { get; set; }
        public int ResolutionStatusId { get; set; }
        public string ResolutionSteps { get; set; }
        public string TicketNumber { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace TicketingSys.Domain
{
    /// <summary>
    /// Resolution Status Model
    /// </summary>
    public class ResolutionStatus
    {
        public int ResolutionStatusId { get; set; }
        public string Name { get; set; }
    }
}

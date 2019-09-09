using System;
using System.ComponentModel.DataAnnotations;

namespace TicketingSys.Domain
{
    /// <summary>
    /// Issue Severity Model
    /// </summary>
    public class IssueSeverity
    {
        public int IssueSeverityId { get; set; }
        public string Name { get; set; }
    }
}

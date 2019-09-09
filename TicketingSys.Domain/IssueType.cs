using System;
using System.ComponentModel.DataAnnotations;

namespace TicketingSys.Domain
{
    /// <summary>
    /// Issue Type Model
    /// </summary>
    public class IssueType
    {
        public int IssueTypeId { get; set; }
        public string Name { get; set; }
    }
}

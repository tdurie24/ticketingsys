using System;

namespace TicketingSys.Domain
{
    /// <summary>
    /// User Model
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string  Name { get; set; }

        public int UserRoleId { get; set; }
        public DateTime  DateLogged { get; set; }
    }
}

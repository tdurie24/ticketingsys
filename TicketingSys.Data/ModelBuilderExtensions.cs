using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TicketingSys.Domain;

namespace TicketingSys.Data
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Seeds the specified model builder.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasData(
                    new UserRole { UserRoleId = 1, Name = "User" },
                    new UserRole { UserRoleId = 2, Name = "Technician" }
                    );
            modelBuilder.Entity<IssueType>().HasData(
                new IssueType { IssueTypeId = 1, Name = "Technical" },
                new IssueType { IssueTypeId = 2, Name = "Network" },
                new IssueType { IssueTypeId = 3, Name = "Software" },
                new IssueType { IssueTypeId = 4, Name = "Hardware" }
                );
            modelBuilder.Entity<IssueSeverity>().HasData(
                new IssueSeverity { IssueSeverityId = 1, Name = "High" },
                new IssueSeverity { IssueSeverityId = 2, Name = "Medium" },
                new IssueSeverity { IssueSeverityId = 3, Name = "Low" }
                );
            modelBuilder.Entity<ResolutionStatus>().HasData(
                new ResolutionStatus { ResolutionStatusId = 1, Name = "Logged" },
                new ResolutionStatus { ResolutionStatusId = 2, Name = "Active" },
                new ResolutionStatus { ResolutionStatusId = 3, Name = "Resolved" },
                new ResolutionStatus { ResolutionStatusId = 4, Name = "Closed" }
               );
        }
    }
}

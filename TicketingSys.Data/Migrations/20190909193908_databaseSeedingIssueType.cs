using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketingSys.Data.Migrations
{
    public partial class databaseSeedingIssueType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IssueSeverities",
                columns: new[] { "IssueSeverityId", "Name" },
                values: new object[,]
                {
                    { 1, "High" },
                    { 2, "Medium" },
                    { 3, "Low" }
                });

            migrationBuilder.InsertData(
                table: "IssueTypes",
                columns: new[] { "IssueTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Technical" },
                    { 2, "Network" },
                    { 3, "Software" },
                    { 4, "Hardware" }
                });

            migrationBuilder.InsertData(
                table: "ResolutionStatuses",
                columns: new[] { "ResolutionStatusId", "Name" },
                values: new object[,]
                {
                    { 1, "Logged" },
                    { 2, "Active" },
                    { 3, "Resolved" },
                    { 4, "Closed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IssueSeverities",
                keyColumn: "IssueSeverityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IssueSeverities",
                keyColumn: "IssueSeverityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IssueSeverities",
                keyColumn: "IssueSeverityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IssueTypes",
                keyColumn: "IssueTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IssueTypes",
                keyColumn: "IssueTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IssueTypes",
                keyColumn: "IssueTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IssueTypes",
                keyColumn: "IssueTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ResolutionStatuses",
                keyColumn: "ResolutionStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ResolutionStatuses",
                keyColumn: "ResolutionStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ResolutionStatuses",
                keyColumn: "ResolutionStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ResolutionStatuses",
                keyColumn: "ResolutionStatusId",
                keyValue: 4);
        }
    }
}

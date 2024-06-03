using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class NullFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 21, 38, 3, 797, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 21, 38, 3, 797, DateTimeKind.Local).AddTicks(9138));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 21, 33, 44, 549, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 21, 33, 44, 549, DateTimeKind.Local).AddTicks(9317));
        }
    }
}

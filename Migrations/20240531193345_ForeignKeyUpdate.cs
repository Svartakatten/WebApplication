using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 20, 36, 31, 920, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "LeaveApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 20, 36, 31, 920, DateTimeKind.Local).AddTicks(6091));
        }
    }
}

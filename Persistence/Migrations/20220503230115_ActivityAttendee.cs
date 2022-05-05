using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class ActivityAttendee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsHost = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttendees", x => new { x.AppUserId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"),
                column: "Dates",
                value: new DateTime(2022, 12, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("259c3963-6c21-4967-8199-155e999389af"),
                column: "Dates",
                value: new DateTime(2022, 3, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"),
                column: "Dates",
                value: new DateTime(2022, 11, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"),
                column: "Dates",
                value: new DateTime(2022, 9, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"),
                column: "Dates",
                value: new DateTime(2022, 10, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"),
                column: "Dates",
                value: new DateTime(2022, 6, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"),
                column: "Dates",
                value: new DateTime(2022, 8, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a5c4885c-4116-4583-87db-7a5c641510af"),
                column: "Dates",
                value: new DateTime(2023, 1, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"),
                column: "Dates",
                value: new DateTime(2022, 7, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"),
                column: "Dates",
                value: new DateTime(2022, 4, 3, 20, 1, 15, 300, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ActivityId",
                table: "AspNetUsers",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttendees_ActivityId",
                table: "ActivityAttendees",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Activities_ActivityId",
                table: "AspNetUsers",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Activities_ActivityId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ActivityAttendees");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ActivityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"),
                column: "Dates",
                value: new DateTime(2022, 11, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("259c3963-6c21-4967-8199-155e999389af"),
                column: "Dates",
                value: new DateTime(2022, 2, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"),
                column: "Dates",
                value: new DateTime(2022, 10, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"),
                column: "Dates",
                value: new DateTime(2022, 8, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"),
                column: "Dates",
                value: new DateTime(2022, 9, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"),
                column: "Dates",
                value: new DateTime(2022, 5, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"),
                column: "Dates",
                value: new DateTime(2022, 7, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a5c4885c-4116-4583-87db-7a5c641510af"),
                column: "Dates",
                value: new DateTime(2022, 12, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"),
                column: "Dates",
                value: new DateTime(2022, 6, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"),
                column: "Dates",
                value: new DateTime(2022, 3, 25, 18, 37, 15, 711, DateTimeKind.Local).AddTicks(9360));
        }
    }
}

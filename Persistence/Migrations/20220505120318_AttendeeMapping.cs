using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AttendeeMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("259c3963-6c21-4967-8199-155e999389af"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a5c4885c-4116-4583-87db-7a5c641510af"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"), "Somewhere on the Thames", "travel", "London", new DateTime(2022, 12, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7869), "Activity 2 months ago", false, "Future Activity 7" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("259c3963-6c21-4967-8199-155e999389af"), "Pub", "drinks", "London", new DateTime(2022, 3, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7786), "Activity 2 months ago", false, "Past Activity 1" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"), "Roundhouse Camden", "music", "London", new DateTime(2022, 11, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7866), "Activity 6 months in future", false, "Future Activity 6" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"), "Yet another pub", "drinks", "London", new DateTime(2022, 9, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7831), "Activity 4 months in future", false, "Future Activity 4" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"), "Just another pub", "drinks", "London", new DateTime(2022, 10, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7862), "Activity 5 months in future", false, "Future Activity 5" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"), "Natural History Museum", "culture", "London", new DateTime(2022, 6, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7819), "Activity 1 month in future", false, "Future Activity 1" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"), "Another pub", "drinks", "London", new DateTime(2022, 8, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7827), "Activity 3 months in future", false, "Future Activity 3" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("a5c4885c-4116-4583-87db-7a5c641510af"), "Cinema", "film", "London", new DateTime(2023, 1, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7872), "Activity 8 months in future", false, "Future Activity 8" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"), "O2 Arena", "music", "London", new DateTime(2022, 7, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7824), "Activity 2 months in future", false, "Future Activity 2" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Avenue", "Category", "City", "Dates", "Description", "IsCancelled", "Title" },
                values: new object[] { new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"), "Louvre", "culture", "Paris", new DateTime(2022, 4, 4, 20, 28, 31, 145, DateTimeKind.Local).AddTicks(7815), "Activity 1 month ago", false, "Past Activity 2" });
        }
    }
}

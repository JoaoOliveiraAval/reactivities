using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class RemoveRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Activities",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Activities",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"),
                column: "Dates",
                value: new DateTime(2022, 11, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("259c3963-6c21-4967-8199-155e999389af"),
                column: "Dates",
                value: new DateTime(2022, 2, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"),
                column: "Dates",
                value: new DateTime(2022, 10, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"),
                column: "Dates",
                value: new DateTime(2022, 8, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"),
                column: "Dates",
                value: new DateTime(2022, 9, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"),
                column: "Dates",
                value: new DateTime(2022, 5, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"),
                column: "Dates",
                value: new DateTime(2022, 7, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a5c4885c-4116-4583-87db-7a5c641510af"),
                column: "Dates",
                value: new DateTime(2022, 12, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"),
                column: "Dates",
                value: new DateTime(2022, 6, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"),
                column: "Dates",
                value: new DateTime(2022, 3, 1, 18, 20, 25, 618, DateTimeKind.Local).AddTicks(33));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Activities",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Activities",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac"),
                column: "Dates",
                value: new DateTime(2022, 9, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("259c3963-6c21-4967-8199-155e999389af"),
                column: "Dates",
                value: new DateTime(2021, 12, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3"),
                column: "Dates",
                value: new DateTime(2022, 8, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6"),
                column: "Dates",
                value: new DateTime(2022, 6, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe"),
                column: "Dates",
                value: new DateTime(2022, 7, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68"),
                column: "Dates",
                value: new DateTime(2022, 3, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c"),
                column: "Dates",
                value: new DateTime(2022, 5, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a5c4885c-4116-4583-87db-7a5c641510af"),
                column: "Dates",
                value: new DateTime(2022, 10, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0"),
                column: "Dates",
                value: new DateTime(2022, 4, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2"),
                column: "Dates",
                value: new DateTime(2022, 1, 20, 0, 55, 45, 94, DateTimeKind.Local).AddTicks(8758));
        }
    }
}

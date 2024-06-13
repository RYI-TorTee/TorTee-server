using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class MakeSubmissionGradeNullble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("d85a973e-825e-487e-b895-064782f4e1ca"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("e1b63328-5e56-4214-a00b-329930150c5a"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f94b15f3-1973-4ce2-9fb4-54833efa7595"));

            migrationBuilder.AlterColumn<float>(
                name: "Grade",
                table: "AssignmentSubmission",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("09be1a9b-7e1f-49f1-9898-a2837e44b7d4"), "Write a message to Mentor" },
                    { new Guid("365e0b99-785a-4b84-a671-cc39973623d9"), "When would you like to reach that goal?" },
                    { new Guid("89767658-b21c-41b6-9bc9-ec830c48be04"), "What best describes the goal of your mentorship?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("09be1a9b-7e1f-49f1-9898-a2837e44b7d4"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("365e0b99-785a-4b84-a671-cc39973623d9"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("89767658-b21c-41b6-9bc9-ec830c48be04"));

            migrationBuilder.AlterColumn<float>(
                name: "Grade",
                table: "AssignmentSubmission",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("d85a973e-825e-487e-b895-064782f4e1ca"), "What best describes the goal of your mentorship?" },
                    { new Guid("e1b63328-5e56-4214-a00b-329930150c5a"), "Write a message to Mentor" },
                    { new Guid("f94b15f3-1973-4ce2-9fb4-54833efa7595"), "When would you like to reach that goal?" }
                });
        }
    }
}

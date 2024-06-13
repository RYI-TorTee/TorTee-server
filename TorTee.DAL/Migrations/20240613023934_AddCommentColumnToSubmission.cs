using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentColumnToSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CommentOfMentor",
                table: "AssignmentSubmission",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("601b9d75-5497-450a-8ed4-6b7787d09b08"), "What best describes the goal of your mentorship?" },
                    { new Guid("6a48ad81-5323-4cfd-bd51-ebe76ddade2a"), "When would you like to reach that goal?" },
                    { new Guid("b23def17-c946-40f6-91b9-aeb193d2191c"), "Write a message to Mentor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("601b9d75-5497-450a-8ed4-6b7787d09b08"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("6a48ad81-5323-4cfd-bd51-ebe76ddade2a"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("b23def17-c946-40f6-91b9-aeb193d2191c"));

            migrationBuilder.DropColumn(
                name: "CommentOfMentor",
                table: "AssignmentSubmission");

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
    }
}

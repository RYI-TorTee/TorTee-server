using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMentorshipTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentorships");

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("ba83f550-e361-4c10-8d9e-a44f27cc86f6"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("d116957d-f74d-48b0-910c-879ea309f159"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1c60283-a64b-4ea9-be9d-622c6436cd8a"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "MenteeApplications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "MenteeApplications",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "MenteeApplications");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "MenteeApplications");

            migrationBuilder.CreateTable(
                name: "Mentorships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenteeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MentorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentorships_AspNetUsers_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentorships_AspNetUsers_MentorId",
                        column: x => x.MentorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("ba83f550-e361-4c10-8d9e-a44f27cc86f6"), "What best describes the goal of your mentorship?" },
                    { new Guid("d116957d-f74d-48b0-910c-879ea309f159"), "When would you like to reach that goal?" },
                    { new Guid("f1c60283-a64b-4ea9-be9d-622c6436cd8a"), "Write a message to Mentor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mentorships_MenteeId",
                table: "Mentorships",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorships_MentorId",
                table: "Mentorships",
                column: "MentorId");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sessions_MentorId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_MenteePlans_MentorId",
                table: "MenteePlans");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MenteePlans");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MenteePlans",
                newName: "DescriptionOfPlan");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRead",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CallPerMonth",
                table: "MentorApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionOfPlan",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationOfMeeting",
                table: "MentorApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "MentorApplications",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSlot",
                table: "MentorApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CallPerMonth",
                table: "MenteePlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurationOfMeeting",
                table: "MenteePlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "IX_Sessions_MentorId",
                table: "Sessions",
                column: "MentorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenteePlans_MentorId",
                table: "MenteePlans",
                column: "MentorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sessions_MentorId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_MenteePlans_MentorId",
                table: "MenteePlans");

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

            migrationBuilder.DropColumn(
                name: "DateRead",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CallPerMonth",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "DescriptionOfPlan",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "DurationOfMeeting",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "TotalSlot",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "CallPerMonth",
                table: "MenteePlans");

            migrationBuilder.DropColumn(
                name: "DurationOfMeeting",
                table: "MenteePlans");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "DescriptionOfPlan",
                table: "MenteePlans",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MenteePlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_MentorId",
                table: "Sessions",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_MenteePlans_MentorId",
                table: "MenteePlans",
                column: "MentorId");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMentorApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentorApplications_AspNetUsers_UserId",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MentorApplications");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "MentorApplications",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Achievement",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_MentorApplications_AspNetUsers_UserId",
                table: "MentorApplications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentorApplications_AspNetUsers_UserId",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Achievement",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "MentorApplications");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "MentorApplications");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "MentorApplications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MentorApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MentorApplications_AspNetUsers_UserId",
                table: "MentorApplications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

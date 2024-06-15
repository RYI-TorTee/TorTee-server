using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("0c114da3-b115-4d71-bd78-2b8c76fcdbb6"), "When would you like to reach that goal?" },
                    { new Guid("79ce9eba-acbe-455e-a9a5-f53524be2838"), "What best describes the goal of your mentorship?" },
                    { new Guid("92aeb483-9948-4289-b177-5da4562dfadf"), "Write a message to Mentor" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("04b4f51f-5261-446c-ab27-90f7c2dc427c"), "Creativity" },
                    { new Guid("06f11ba1-8d46-4439-bf03-e76b0a144014"), "Content Marketing" },
                    { new Guid("08440b0d-1dfe-4729-8b25-cd2e32cecd66"), "Email Marketing" },
                    { new Guid("09178e51-3a40-4251-8adf-12918df9f6d0"), "Negotiation" },
                    { new Guid("0cc981c6-c3a1-420f-b315-81d89a477cb5"), "SEO (Search Engine Optimization)" },
                    { new Guid("13fd0bb1-16dc-452b-91b0-73858709ab5b"), "Cloud Computing" },
                    { new Guid("152ac53d-42c2-465b-bc1c-8767a31e6bfa"), "Mobile Development" },
                    { new Guid("17fcde52-63b2-4c7a-ab63-e08dd88e9968"), "Web Development" },
                    { new Guid("1ebc1e31-176e-4a03-a4a6-215ecfcbe309"), "Collaboration" },
                    { new Guid("1ed8129f-7618-4b4a-aee6-f72d7c479bb0"), "Product Management" },
                    { new Guid("226450c7-7f52-4a98-b289-f42e94445601"), "Artificial Intelligence" },
                    { new Guid("23cb1ee5-d803-49c3-9299-c2d35e59ebf1"), "Emotional Intelligence" },
                    { new Guid("28961a0f-edcf-4a05-8f28-a1f1f5d3cb84"), "Network Administration" },
                    { new Guid("300a41d0-4f30-4daf-9edf-fa74d99c9b3f"), "Sales" },
                    { new Guid("30af04eb-f03f-408f-acf8-473b517d5f7d"), "Blockchain" },
                    { new Guid("36e1c0e7-a4ae-4583-bd84-7229557f2710"), "Digital Marketing" },
                    { new Guid("3b827781-f1e9-42c1-930a-acdae80844c6"), "Data Analysis" },
                    { new Guid("3e6c942f-8e12-4491-a9d3-7ad3f08e836f"), "Problem Solving" },
                    { new Guid("3f0d9701-1f9d-4d7e-8429-7927b9d1a52e"), "Graphic Design" },
                    { new Guid("42a05aad-1324-4ba8-8c2e-ed2eb11f64b7"), "Public Relations" },
                    { new Guid("43a6b127-ebef-4ded-aef7-5ee3359c9884"), "Time Management" },
                    { new Guid("5cfc26bb-484e-4d89-9494-f334653a51b3"), "Communication" },
                    { new Guid("69f307e0-5c66-42aa-ab84-56d4341c9746"), "Software Development" },
                    { new Guid("6cd1a3ac-e3d2-4b0f-90e6-2127230531a6"), "Brand Management" },
                    { new Guid("70096f62-55b1-469b-bc53-d0e4ed3d4744"), "Project Management" },
                    { new Guid("7a92c774-2dc8-459e-85f9-57502d3a00ff"), "Critical Thinking" },
                    { new Guid("7e21951e-2bb0-46d9-812f-1fb51e80d781"), "Machine Learning" },
                    { new Guid("8885aa61-c750-40be-b393-def24608f126"), "Market Research" },
                    { new Guid("8e1f1559-0f28-4406-ab7f-9ed9269bb328"), "Entrepreneurship" },
                    { new Guid("8f47d25f-4297-4c99-a03c-845831b1a9a3"), "Strategic Planning" },
                    { new Guid("925be8e7-9a54-46a5-ab0e-55f7eb9ea056"), "Supply Chain Management" },
                    { new Guid("935d9f6e-8520-4c39-9f28-ef40c1dff4cb"), "Interpersonal Skills" },
                    { new Guid("9f370291-36d0-453e-833a-29833c076590"), "Database Management" },
                    { new Guid("a0b4cc3d-c35e-4dbb-8a43-8db78b88d70f"), "Team Leadership" },
                    { new Guid("ab9b00ba-d4ed-428a-ba3e-c4da0a12b7f0"), "Business Strategy" },
                    { new Guid("bd5f3339-a2c8-4207-92d0-d781d54aa67b"), "Business Analysis" },
                    { new Guid("c261fda7-512c-43c6-8dd8-e157ec42845b"), "Operations Management" },
                    { new Guid("c86252b1-1ad9-4874-9c17-b90a487362b6"), "SEM (Search Engine Marketing)" },
                    { new Guid("cd1ded5a-8f57-4ba5-b1fd-8351d96e5506"), "Cybersecurity" },
                    { new Guid("cd2e77dc-acdd-4bd9-8e21-d9f8ef39bf97"), "Financial Analysis" },
                    { new Guid("cf28138d-a560-427a-9778-92fc8742f32b"), "DevOps" },
                    { new Guid("d5c54fff-b22e-49d1-a81a-5fc242e879c9"), "Conflict Resolution" },
                    { new Guid("e236cab2-ae1b-4e7b-ba6f-025fa48884ef"), "Work Ethic" },
                    { new Guid("ef9f6512-0102-47a0-84ca-f1a0acd0f2b4"), "IT Support" },
                    { new Guid("f765a141-ee5f-4834-8061-7b0aa82e683d"), "Risk Management" },
                    { new Guid("f8f864ba-0c83-497c-b997-68b37dfbdde9"), "Adaptability" },
                    { new Guid("fd4c578b-e845-4049-bb43-6ab30335d1c5"), "Customer Service" },
                    { new Guid("fd7f7f3d-9807-44a3-9b16-2c368058e525"), "Social Media Marketing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("0c114da3-b115-4d71-bd78-2b8c76fcdbb6"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("79ce9eba-acbe-455e-a9a5-f53524be2838"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("92aeb483-9948-4289-b177-5da4562dfadf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("04b4f51f-5261-446c-ab27-90f7c2dc427c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("06f11ba1-8d46-4439-bf03-e76b0a144014"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("08440b0d-1dfe-4729-8b25-cd2e32cecd66"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("09178e51-3a40-4251-8adf-12918df9f6d0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0cc981c6-c3a1-420f-b315-81d89a477cb5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("13fd0bb1-16dc-452b-91b0-73858709ab5b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("152ac53d-42c2-465b-bc1c-8767a31e6bfa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("17fcde52-63b2-4c7a-ab63-e08dd88e9968"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1ebc1e31-176e-4a03-a4a6-215ecfcbe309"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1ed8129f-7618-4b4a-aee6-f72d7c479bb0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("226450c7-7f52-4a98-b289-f42e94445601"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("23cb1ee5-d803-49c3-9299-c2d35e59ebf1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("28961a0f-edcf-4a05-8f28-a1f1f5d3cb84"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("300a41d0-4f30-4daf-9edf-fa74d99c9b3f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("30af04eb-f03f-408f-acf8-473b517d5f7d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("36e1c0e7-a4ae-4583-bd84-7229557f2710"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3b827781-f1e9-42c1-930a-acdae80844c6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3e6c942f-8e12-4491-a9d3-7ad3f08e836f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3f0d9701-1f9d-4d7e-8429-7927b9d1a52e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("42a05aad-1324-4ba8-8c2e-ed2eb11f64b7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("43a6b127-ebef-4ded-aef7-5ee3359c9884"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5cfc26bb-484e-4d89-9494-f334653a51b3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("69f307e0-5c66-42aa-ab84-56d4341c9746"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6cd1a3ac-e3d2-4b0f-90e6-2127230531a6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("70096f62-55b1-469b-bc53-d0e4ed3d4744"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7a92c774-2dc8-459e-85f9-57502d3a00ff"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7e21951e-2bb0-46d9-812f-1fb51e80d781"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8885aa61-c750-40be-b393-def24608f126"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8e1f1559-0f28-4406-ab7f-9ed9269bb328"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8f47d25f-4297-4c99-a03c-845831b1a9a3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("925be8e7-9a54-46a5-ab0e-55f7eb9ea056"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("935d9f6e-8520-4c39-9f28-ef40c1dff4cb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9f370291-36d0-453e-833a-29833c076590"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a0b4cc3d-c35e-4dbb-8a43-8db78b88d70f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ab9b00ba-d4ed-428a-ba3e-c4da0a12b7f0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bd5f3339-a2c8-4207-92d0-d781d54aa67b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c261fda7-512c-43c6-8dd8-e157ec42845b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c86252b1-1ad9-4874-9c17-b90a487362b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cd1ded5a-8f57-4ba5-b1fd-8351d96e5506"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cd2e77dc-acdd-4bd9-8e21-d9f8ef39bf97"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cf28138d-a560-427a-9778-92fc8742f32b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d5c54fff-b22e-49d1-a81a-5fc242e879c9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e236cab2-ae1b-4e7b-ba6f-025fa48884ef"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ef9f6512-0102-47a0-84ca-f1a0acd0f2b4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f765a141-ee5f-4834-8061-7b0aa82e683d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f8f864ba-0c83-497c-b997-68b37dfbdde9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fd4c578b-e845-4049-bb43-6ab30335d1c5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fd7f7f3d-9807-44a3-9b16-2c368058e525"));

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
    }
}

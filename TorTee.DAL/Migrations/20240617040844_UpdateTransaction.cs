using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transactions_MenteeApplicationId",
                table: "Transactions");

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

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionId",
                table: "MenteeApplications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("7df0ad50-ce58-4328-ae97-af6cac7c2ffd"), "When would you like to reach that goal?" },
                    { new Guid("f69e9b69-ff7b-4da1-9879-6afeef0c2c61"), "What best describes the goal of your mentorship?" },
                    { new Guid("fec19748-8dff-4715-919c-0a6dc86c90fc"), "Write a message to Mentor" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("017e6450-c6e9-496e-baf8-2d4ec169b71c"), "Graphic Design" },
                    { new Guid("0ebd28a5-f04c-4108-bd81-82f857fac555"), "Blockchain" },
                    { new Guid("0fcb9b16-e349-4391-8e8e-f89c8fc136c1"), "Time Management" },
                    { new Guid("10e654c4-4ee4-4493-910c-17e0d6982d29"), "Public Relations" },
                    { new Guid("17ed74e4-6c4b-41fd-b0f1-4f623c283ceb"), "Strategic Planning" },
                    { new Guid("1a043a82-c533-4fe7-a68c-82ff18cf3c42"), "Product Management" },
                    { new Guid("1a35f545-6539-45c4-a04a-72fc66b00c3e"), "SEM (Search Engine Marketing)" },
                    { new Guid("1f0e39b4-0b54-444d-8222-119c2c9577a7"), "Network Administration" },
                    { new Guid("31227fbf-08e9-4519-83da-0eed3cb74b51"), "Work Ethic" },
                    { new Guid("419cf589-6a58-431b-925c-ed47d85461d9"), "Emotional Intelligence" },
                    { new Guid("453287fb-4fe4-4cae-9618-825c74685c62"), "Problem Solving" },
                    { new Guid("499a2aa0-44ed-43e7-9d96-d57641e8312f"), "Cloud Computing" },
                    { new Guid("4baf83e2-e619-44b1-a528-c73f1bbee9ca"), "Digital Marketing" },
                    { new Guid("4d664d9b-84a5-4d75-b977-0f90be296980"), "Critical Thinking" },
                    { new Guid("50f7c183-1d52-4220-b53f-31a54382bed4"), "IT Support" },
                    { new Guid("5290ccb3-b014-4d36-b3fc-01574af5558d"), "Database Management" },
                    { new Guid("52f94d08-86c1-406a-bd8c-817597e9783b"), "Collaboration" },
                    { new Guid("568956a5-b9a2-4f3f-bc41-7ad900eabb09"), "Negotiation" },
                    { new Guid("5863c816-a922-4992-b1f3-7788d6648199"), "Risk Management" },
                    { new Guid("5ecf955e-83a4-45f8-9355-097f4d6844e6"), "Project Management" },
                    { new Guid("5eee34bf-aca4-49c6-b4ee-dfb763f8e0ac"), "Communication" },
                    { new Guid("6697c682-c043-4e03-9870-4e725e42837a"), "Email Marketing" },
                    { new Guid("6c4cf6ef-b3ce-4be2-ade3-fb0fbc9397b5"), "Social Media Marketing" },
                    { new Guid("7361991d-91ac-418d-af10-ea3414c03b2e"), "Financial Analysis" },
                    { new Guid("77d7e39e-e6f1-46a1-8eb7-679f3da306c8"), "Creativity" },
                    { new Guid("7a18267f-7cab-4686-b3aa-03922f76e02d"), "Operations Management" },
                    { new Guid("7f04d8b5-c479-4526-ae9c-36b1073b9d1f"), "Business Analysis" },
                    { new Guid("8c50a8f7-7925-4358-b559-951ee16ae1b7"), "Market Research" },
                    { new Guid("8f4a064d-2ce1-4535-b81e-af584c4c6d8f"), "Customer Service" },
                    { new Guid("9f3dbf70-9ef9-4fcc-820e-044b48890e9c"), "Entrepreneurship" },
                    { new Guid("a167870f-f2c0-4d2d-ad0e-7a8bfdd7dce6"), "Supply Chain Management" },
                    { new Guid("a19a5eec-f932-47b4-8d6d-bfbb38dcfa59"), "DevOps" },
                    { new Guid("aa2d5a50-df4a-4ec6-988f-82810cc409f7"), "Cybersecurity" },
                    { new Guid("ab1b5ed0-6a4a-4d91-90a2-41da19448c6d"), "Software Development" },
                    { new Guid("b1b78e0a-898b-4bbc-9903-9efb65aca74c"), "Data Analysis" },
                    { new Guid("b427ca80-b203-4844-8ae2-c4f87ebb513c"), "Artificial Intelligence" },
                    { new Guid("c008fa52-10bd-4956-bbd3-2bcf8e510c67"), "Adaptability" },
                    { new Guid("c21e002c-9229-4d58-8d9d-67c0cc243721"), "Mobile Development" },
                    { new Guid("c6c0a215-3d9e-418b-98e7-dfdebc067273"), "Team Leadership" },
                    { new Guid("c9a2766e-ec86-440d-8eb9-135c20ca57d4"), "SEO (Search Engine Optimization)" },
                    { new Guid("cba7e5b5-4b41-49ee-9c6b-3428c9158ab8"), "Sales" },
                    { new Guid("cd26e179-df7d-416c-9871-b16b227ce3a8"), "Machine Learning" },
                    { new Guid("d74b6962-a35a-484a-8ac5-3919f2cffd23"), "Brand Management" },
                    { new Guid("e135a219-c402-4ab1-9fab-458e2d4b3e63"), "Conflict Resolution" },
                    { new Guid("e55842c3-e8bc-45b3-b2e6-6b504b799420"), "Web Development" },
                    { new Guid("ef145c6f-2270-4a71-b93e-d6aff2acec56"), "Interpersonal Skills" },
                    { new Guid("f0fe85c6-14c8-45c0-8411-a641e594385f"), "Content Marketing" },
                    { new Guid("fc9d7f19-6d4d-4b6f-a2da-6ab85e193e1b"), "Business Strategy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MenteeApplicationId",
                table: "Transactions",
                column: "MenteeApplicationId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transactions_MenteeApplicationId",
                table: "Transactions");

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("7df0ad50-ce58-4328-ae97-af6cac7c2ffd"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f69e9b69-ff7b-4da1-9879-6afeef0c2c61"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("fec19748-8dff-4715-919c-0a6dc86c90fc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("017e6450-c6e9-496e-baf8-2d4ec169b71c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0ebd28a5-f04c-4108-bd81-82f857fac555"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0fcb9b16-e349-4391-8e8e-f89c8fc136c1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("10e654c4-4ee4-4493-910c-17e0d6982d29"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("17ed74e4-6c4b-41fd-b0f1-4f623c283ceb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1a043a82-c533-4fe7-a68c-82ff18cf3c42"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1a35f545-6539-45c4-a04a-72fc66b00c3e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1f0e39b4-0b54-444d-8222-119c2c9577a7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("31227fbf-08e9-4519-83da-0eed3cb74b51"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("419cf589-6a58-431b-925c-ed47d85461d9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("453287fb-4fe4-4cae-9618-825c74685c62"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("499a2aa0-44ed-43e7-9d96-d57641e8312f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4baf83e2-e619-44b1-a528-c73f1bbee9ca"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4d664d9b-84a5-4d75-b977-0f90be296980"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("50f7c183-1d52-4220-b53f-31a54382bed4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5290ccb3-b014-4d36-b3fc-01574af5558d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("52f94d08-86c1-406a-bd8c-817597e9783b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("568956a5-b9a2-4f3f-bc41-7ad900eabb09"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5863c816-a922-4992-b1f3-7788d6648199"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5ecf955e-83a4-45f8-9355-097f4d6844e6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5eee34bf-aca4-49c6-b4ee-dfb763f8e0ac"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6697c682-c043-4e03-9870-4e725e42837a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6c4cf6ef-b3ce-4be2-ade3-fb0fbc9397b5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7361991d-91ac-418d-af10-ea3414c03b2e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("77d7e39e-e6f1-46a1-8eb7-679f3da306c8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7a18267f-7cab-4686-b3aa-03922f76e02d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7f04d8b5-c479-4526-ae9c-36b1073b9d1f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8c50a8f7-7925-4358-b559-951ee16ae1b7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8f4a064d-2ce1-4535-b81e-af584c4c6d8f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9f3dbf70-9ef9-4fcc-820e-044b48890e9c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a167870f-f2c0-4d2d-ad0e-7a8bfdd7dce6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a19a5eec-f932-47b4-8d6d-bfbb38dcfa59"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("aa2d5a50-df4a-4ec6-988f-82810cc409f7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ab1b5ed0-6a4a-4d91-90a2-41da19448c6d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b1b78e0a-898b-4bbc-9903-9efb65aca74c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b427ca80-b203-4844-8ae2-c4f87ebb513c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c008fa52-10bd-4956-bbd3-2bcf8e510c67"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c21e002c-9229-4d58-8d9d-67c0cc243721"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c6c0a215-3d9e-418b-98e7-dfdebc067273"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c9a2766e-ec86-440d-8eb9-135c20ca57d4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cba7e5b5-4b41-49ee-9c6b-3428c9158ab8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cd26e179-df7d-416c-9871-b16b227ce3a8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d74b6962-a35a-484a-8ac5-3919f2cffd23"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e135a219-c402-4ab1-9fab-458e2d4b3e63"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e55842c3-e8bc-45b3-b2e6-6b504b799420"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ef145c6f-2270-4a71-b93e-d6aff2acec56"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f0fe85c6-14c8-45c0-8411-a641e594385f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fc9d7f19-6d4d-4b6f-a2da-6ab85e193e1b"));

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "MenteeApplications");

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

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MenteeApplicationId",
                table: "Transactions",
                column: "MenteeApplicationId");
        }
    }
}

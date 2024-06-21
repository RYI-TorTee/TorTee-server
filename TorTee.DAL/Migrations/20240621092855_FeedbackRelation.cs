using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FeedbackRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenteeApplications_Feedbacks_FeedbackId",
                table: "MenteeApplications");

            migrationBuilder.DropIndex(
                name: "IX_MenteeApplications_FeedbackId",
                table: "MenteeApplications");

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("399f967c-b42f-4691-8a7b-4cb00b04b5e0"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("5572fc8c-ea17-4fa8-a195-2e3a98407904"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("a5cda77d-3085-40b9-8f32-bc3a819dd68a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0694db78-d695-4cbb-9935-5899c8bc0aaa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0793cc8b-f8f1-4e7c-86c1-f6cdbfa2b876"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0c275c3d-dbe1-469f-bfde-a8fa1bd497b7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("11eaa480-d687-4006-9375-9ed88d76dd4c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("121d714e-dca2-4caa-92f7-84d5dde7fc46"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("27aeaa7c-7ed2-41d3-9541-17b043b67a21"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2cf7e387-d756-4f9e-a3b9-4ce8280d99d3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2df33056-efd3-4487-9e3c-7a98579375bc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2e3c43ee-a7cc-482d-a5f1-9a1d4d67f601"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2f0d1852-3c1b-47a3-8e23-48c1e457b08b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("35941563-7b63-4db6-b756-6f157ba0aa0f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3ab3d5bb-1888-43e2-9d74-dafb0b399109"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("42cf4ffa-90ce-40b2-98bb-6c3968342a07"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("43376596-e697-42d9-a9c0-62906f4b7771"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("43675e2a-e173-4c64-bc96-727defcd10b2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("47f330b4-a7f8-4c57-835a-cac48882e01f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4e9aad22-f613-4676-8efa-d2189fed8432"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4f12897d-0070-457f-94ca-1ca8396bb67f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("50b151cc-5b3d-4d64-be2f-e7d8c5cfa98b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("52f83ce7-8b53-45bf-81eb-bde2ddf974b3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("532c9a0d-0352-4798-a640-1bdb7b4971a0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("57dad023-cc0f-449b-b14a-3eb43c9ff4f8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5d7a5532-8aea-48e2-869f-1c3f53b5d395"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5d80227c-103a-4c5b-8406-063553bd5eeb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("60eaf85e-86a0-45b2-9f6d-3a8263708ea7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("65fbddf0-16ce-4347-a900-9a1b37ea6151"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6d6c6eec-c699-48fb-bd41-79ae88dae9e0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6de91cf4-9349-46ed-b676-0af5de760462"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7d19e2b0-7e20-4536-a138-b9fdcde5e25f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8741f27d-1e9c-4ffc-8c94-6eef47e3b089"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8b093ae3-4ce6-486b-aa79-ef7364dee61c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8fbcf041-bab2-4e30-8381-e06139f3671b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9dbd14b4-115b-456f-baff-7b1947bf1480"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ae5eed13-759c-4444-b412-896880dda209"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b534ec31-b5e6-4425-9032-45fb82f63801"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b585a6d8-65b1-4cfc-a84a-d577ab850286"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b67241df-64e5-472f-a038-f927cc7fef91"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bb2b0c84-bbab-4408-b242-fdfb1be63178"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c0a30f4f-1783-4173-8ac4-b3b2931742c5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d2076ce7-a95e-4617-bd0a-2df551c18cee"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e1d14a84-748a-4019-bca5-97e18510f556"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e42956f1-3b98-4cc6-ae7b-ebe114c15c00"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e53776f9-eb9d-4a03-a510-5b1458292cc3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e8795ac1-77b4-4c30-90eb-636537d7bd34"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f3675ef9-96bc-4e36-85be-4fcd3c599996"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f53c00f3-9e4b-47e9-bf10-87738e6f421c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fc8ced59-5979-4fa9-94ff-68e112c5ccb0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ffc61ffd-57b1-4bf0-8f58-bdca77d883b3"));

            migrationBuilder.AddColumn<Guid>(
                name: "MenteeApplicationId",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("3685c6c7-f1e9-4194-a6b0-8835596ab0e1"), "What best describes the goal of your mentorship?" },
                    { new Guid("461fc821-87a0-48c0-8bec-aaa5af2ab490"), "Write a message to Mentor" },
                    { new Guid("9856643c-00d2-49f8-bf1d-d6c0a7d38d8f"), "When would you like to reach that goal?" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("0e68507c-4c6e-4489-8532-20d4d03637fb"), "Public Relations" },
                    { new Guid("1872f05b-2720-4b24-a392-f5cd2eae7d25"), "Entrepreneurship" },
                    { new Guid("366a0a18-037f-4afd-87be-b3159e1138ab"), "Operations Management" },
                    { new Guid("3a032dd9-3792-40bc-a0b2-a6418dc06575"), "Digital Marketing" },
                    { new Guid("47852fac-0e6d-4b14-828c-15e8a92b3b34"), "Strategic Planning" },
                    { new Guid("4c1bc776-86d1-416a-80e9-33efcc5205b6"), "Project Management" },
                    { new Guid("4c9da501-69cd-4c89-a69c-ee0a94f538b3"), "Web Development" },
                    { new Guid("4e8ddb89-bd86-44ed-89b2-7121ec9b9e2f"), "Time Management" },
                    { new Guid("54747524-62d5-4332-bedd-f1f2569938e2"), "Problem Solving" },
                    { new Guid("55c4ab2c-19e6-4198-83c0-c42719a4d1e5"), "Graphic Design" },
                    { new Guid("62f6b960-267a-4270-be36-bffd545b7840"), "Critical Thinking" },
                    { new Guid("634306ff-9115-4c53-8ba5-34a9e2aedf88"), "IT Support" },
                    { new Guid("63a247f4-fe79-4c87-8f9d-070058d6d2e5"), "Risk Management" },
                    { new Guid("75e9cfc2-8227-4283-b3ab-615a3506c4f4"), "Collaboration" },
                    { new Guid("78109c45-3ede-4b45-a886-0198fb7f11ed"), "Emotional Intelligence" },
                    { new Guid("7c75da39-e1d2-4f00-9f7f-5e001ff45772"), "Database Management" },
                    { new Guid("7f9ad1d6-f1b9-4993-874a-b0d07ec340f6"), "Software Development" },
                    { new Guid("813f8143-0ab0-44bf-8bcb-e318d129b0dd"), "Work Ethic" },
                    { new Guid("87c297c2-422b-4247-87c6-68da564785d6"), "Business Analysis" },
                    { new Guid("89910884-7dd5-4e04-8636-e0a912711b93"), "Email Marketing" },
                    { new Guid("914b2319-4a0a-454b-a013-c92c5b70b5c0"), "Cybersecurity" },
                    { new Guid("9209a98c-58f0-4b6c-b0b8-2268a857f069"), "Social Media Marketing" },
                    { new Guid("98601cac-8d41-4310-a0b3-2eb0da753693"), "Cloud Computing" },
                    { new Guid("a87fbb79-17de-4b6c-b145-995fa32733b8"), "Customer Service" },
                    { new Guid("aab569c8-e81d-4dc6-ac4b-cf5d484052be"), "SEO (Search Engine Optimization)" },
                    { new Guid("abf4c33a-74a8-40d7-aa25-2489d231388a"), "Interpersonal Skills" },
                    { new Guid("acb98f99-52c5-485b-b706-6988ff7df8d2"), "Blockchain" },
                    { new Guid("ad1993f4-a5e3-457b-8d2f-c0172e04c680"), "Communication" },
                    { new Guid("b64d867a-8cbb-4a56-a3d1-9f224754608d"), "Negotiation" },
                    { new Guid("b6db4002-b608-426a-b70c-2957b9953f57"), "Market Research" },
                    { new Guid("ba866550-c0a4-43a1-9321-a9eaed601de1"), "Brand Management" },
                    { new Guid("bb3be023-0dfe-4a22-aa51-5f71b0827227"), "Content Marketing" },
                    { new Guid("bc35de5c-4b78-4c6d-9a4c-3ae296a1c319"), "Data Analysis" },
                    { new Guid("bc7593ac-1c6c-4c2c-b259-c941cf93f056"), "Financial Analysis" },
                    { new Guid("bdd968b0-16a5-4e68-9d5c-8176e1aacbd5"), "Machine Learning" },
                    { new Guid("bf710b1c-5bb0-47bc-80c0-0a4b21013a97"), "SEM (Search Engine Marketing)" },
                    { new Guid("bff74aad-d237-4ef6-b985-316884913369"), "Sales" },
                    { new Guid("cd017d80-9165-43e5-86cd-4aaa26598b3f"), "Creativity" },
                    { new Guid("d115aacb-3529-4b64-946e-8788bf7b23d7"), "Conflict Resolution" },
                    { new Guid("d16a29ee-b1fe-4d55-a619-5ace614b2f28"), "Mobile Development" },
                    { new Guid("d61e8480-8676-4884-bb00-640d1f23d025"), "Network Administration" },
                    { new Guid("d86d9a47-934f-402b-a34e-4b2b99839e32"), "DevOps" },
                    { new Guid("e2270e3c-266d-4613-a2a0-d0ea518e6c2b"), "Supply Chain Management" },
                    { new Guid("e42050cf-ce91-4f22-b04b-7af899d4d5de"), "Artificial Intelligence" },
                    { new Guid("e616fa1c-d5f4-461b-be2d-3ab3cbd0287d"), "Team Leadership" },
                    { new Guid("ec75adce-91c9-4b7f-a915-2c979a8cdeb3"), "Business Strategy" },
                    { new Guid("f06e7fee-abf4-4d82-8278-9b724b7cc776"), "Adaptability" },
                    { new Guid("f3490198-5603-4c22-9714-2f7861ad2c97"), "Product Management" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_MenteeApplicationId",
                table: "Feedbacks",
                column: "MenteeApplicationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_MenteeApplications_MenteeApplicationId",
                table: "Feedbacks",
                column: "MenteeApplicationId",
                principalTable: "MenteeApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_MenteeApplications_MenteeApplicationId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_MenteeApplicationId",
                table: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("3685c6c7-f1e9-4194-a6b0-8835596ab0e1"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("461fc821-87a0-48c0-8bec-aaa5af2ab490"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("9856643c-00d2-49f8-bf1d-d6c0a7d38d8f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0e68507c-4c6e-4489-8532-20d4d03637fb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1872f05b-2720-4b24-a392-f5cd2eae7d25"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("366a0a18-037f-4afd-87be-b3159e1138ab"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3a032dd9-3792-40bc-a0b2-a6418dc06575"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("47852fac-0e6d-4b14-828c-15e8a92b3b34"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4c1bc776-86d1-416a-80e9-33efcc5205b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4c9da501-69cd-4c89-a69c-ee0a94f538b3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4e8ddb89-bd86-44ed-89b2-7121ec9b9e2f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("54747524-62d5-4332-bedd-f1f2569938e2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("55c4ab2c-19e6-4198-83c0-c42719a4d1e5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("62f6b960-267a-4270-be36-bffd545b7840"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("634306ff-9115-4c53-8ba5-34a9e2aedf88"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("63a247f4-fe79-4c87-8f9d-070058d6d2e5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("75e9cfc2-8227-4283-b3ab-615a3506c4f4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("78109c45-3ede-4b45-a886-0198fb7f11ed"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7c75da39-e1d2-4f00-9f7f-5e001ff45772"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7f9ad1d6-f1b9-4993-874a-b0d07ec340f6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("813f8143-0ab0-44bf-8bcb-e318d129b0dd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("87c297c2-422b-4247-87c6-68da564785d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("89910884-7dd5-4e04-8636-e0a912711b93"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("914b2319-4a0a-454b-a013-c92c5b70b5c0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9209a98c-58f0-4b6c-b0b8-2268a857f069"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("98601cac-8d41-4310-a0b3-2eb0da753693"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a87fbb79-17de-4b6c-b145-995fa32733b8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("aab569c8-e81d-4dc6-ac4b-cf5d484052be"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("abf4c33a-74a8-40d7-aa25-2489d231388a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("acb98f99-52c5-485b-b706-6988ff7df8d2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ad1993f4-a5e3-457b-8d2f-c0172e04c680"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b64d867a-8cbb-4a56-a3d1-9f224754608d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b6db4002-b608-426a-b70c-2957b9953f57"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ba866550-c0a4-43a1-9321-a9eaed601de1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bb3be023-0dfe-4a22-aa51-5f71b0827227"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bc35de5c-4b78-4c6d-9a4c-3ae296a1c319"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bc7593ac-1c6c-4c2c-b259-c941cf93f056"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bdd968b0-16a5-4e68-9d5c-8176e1aacbd5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bf710b1c-5bb0-47bc-80c0-0a4b21013a97"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bff74aad-d237-4ef6-b985-316884913369"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cd017d80-9165-43e5-86cd-4aaa26598b3f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d115aacb-3529-4b64-946e-8788bf7b23d7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d16a29ee-b1fe-4d55-a619-5ace614b2f28"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d61e8480-8676-4884-bb00-640d1f23d025"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d86d9a47-934f-402b-a34e-4b2b99839e32"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e2270e3c-266d-4613-a2a0-d0ea518e6c2b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e42050cf-ce91-4f22-b04b-7af899d4d5de"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e616fa1c-d5f4-461b-be2d-3ab3cbd0287d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ec75adce-91c9-4b7f-a915-2c979a8cdeb3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f06e7fee-abf4-4d82-8278-9b724b7cc776"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f3490198-5603-4c22-9714-2f7861ad2c97"));

            migrationBuilder.DropColumn(
                name: "MenteeApplicationId",
                table: "Feedbacks");

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("399f967c-b42f-4691-8a7b-4cb00b04b5e0"), "When would you like to reach that goal?" },
                    { new Guid("5572fc8c-ea17-4fa8-a195-2e3a98407904"), "What best describes the goal of your mentorship?" },
                    { new Guid("a5cda77d-3085-40b9-8f32-bc3a819dd68a"), "Write a message to Mentor" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("0694db78-d695-4cbb-9935-5899c8bc0aaa"), "Risk Management" },
                    { new Guid("0793cc8b-f8f1-4e7c-86c1-f6cdbfa2b876"), "Network Administration" },
                    { new Guid("0c275c3d-dbe1-469f-bfde-a8fa1bd497b7"), "Product Management" },
                    { new Guid("11eaa480-d687-4006-9375-9ed88d76dd4c"), "Blockchain" },
                    { new Guid("121d714e-dca2-4caa-92f7-84d5dde7fc46"), "Cybersecurity" },
                    { new Guid("27aeaa7c-7ed2-41d3-9541-17b043b67a21"), "Negotiation" },
                    { new Guid("2cf7e387-d756-4f9e-a3b9-4ce8280d99d3"), "SEO (Search Engine Optimization)" },
                    { new Guid("2df33056-efd3-4487-9e3c-7a98579375bc"), "Mobile Development" },
                    { new Guid("2e3c43ee-a7cc-482d-a5f1-9a1d4d67f601"), "Work Ethic" },
                    { new Guid("2f0d1852-3c1b-47a3-8e23-48c1e457b08b"), "Data Analysis" },
                    { new Guid("35941563-7b63-4db6-b756-6f157ba0aa0f"), "Brand Management" },
                    { new Guid("3ab3d5bb-1888-43e2-9d74-dafb0b399109"), "Supply Chain Management" },
                    { new Guid("42cf4ffa-90ce-40b2-98bb-6c3968342a07"), "Customer Service" },
                    { new Guid("43376596-e697-42d9-a9c0-62906f4b7771"), "Sales" },
                    { new Guid("43675e2a-e173-4c64-bc96-727defcd10b2"), "Public Relations" },
                    { new Guid("47f330b4-a7f8-4c57-835a-cac48882e01f"), "Collaboration" },
                    { new Guid("4e9aad22-f613-4676-8efa-d2189fed8432"), "Business Strategy" },
                    { new Guid("4f12897d-0070-457f-94ca-1ca8396bb67f"), "Team Leadership" },
                    { new Guid("50b151cc-5b3d-4d64-be2f-e7d8c5cfa98b"), "Content Marketing" },
                    { new Guid("52f83ce7-8b53-45bf-81eb-bde2ddf974b3"), "Strategic Planning" },
                    { new Guid("532c9a0d-0352-4798-a640-1bdb7b4971a0"), "Interpersonal Skills" },
                    { new Guid("57dad023-cc0f-449b-b14a-3eb43c9ff4f8"), "Critical Thinking" },
                    { new Guid("5d7a5532-8aea-48e2-869f-1c3f53b5d395"), "DevOps" },
                    { new Guid("5d80227c-103a-4c5b-8406-063553bd5eeb"), "Financial Analysis" },
                    { new Guid("60eaf85e-86a0-45b2-9f6d-3a8263708ea7"), "Creativity" },
                    { new Guid("65fbddf0-16ce-4347-a900-9a1b37ea6151"), "Project Management" },
                    { new Guid("6d6c6eec-c699-48fb-bd41-79ae88dae9e0"), "Graphic Design" },
                    { new Guid("6de91cf4-9349-46ed-b676-0af5de760462"), "Business Analysis" },
                    { new Guid("7d19e2b0-7e20-4536-a138-b9fdcde5e25f"), "Communication" },
                    { new Guid("8741f27d-1e9c-4ffc-8c94-6eef47e3b089"), "Web Development" },
                    { new Guid("8b093ae3-4ce6-486b-aa79-ef7364dee61c"), "SEM (Search Engine Marketing)" },
                    { new Guid("8fbcf041-bab2-4e30-8381-e06139f3671b"), "Artificial Intelligence" },
                    { new Guid("9dbd14b4-115b-456f-baff-7b1947bf1480"), "Digital Marketing" },
                    { new Guid("ae5eed13-759c-4444-b412-896880dda209"), "Conflict Resolution" },
                    { new Guid("b534ec31-b5e6-4425-9032-45fb82f63801"), "Social Media Marketing" },
                    { new Guid("b585a6d8-65b1-4cfc-a84a-d577ab850286"), "Cloud Computing" },
                    { new Guid("b67241df-64e5-472f-a038-f927cc7fef91"), "Database Management" },
                    { new Guid("bb2b0c84-bbab-4408-b242-fdfb1be63178"), "Software Development" },
                    { new Guid("c0a30f4f-1783-4173-8ac4-b3b2931742c5"), "IT Support" },
                    { new Guid("d2076ce7-a95e-4617-bd0a-2df551c18cee"), "Market Research" },
                    { new Guid("e1d14a84-748a-4019-bca5-97e18510f556"), "Machine Learning" },
                    { new Guid("e42956f1-3b98-4cc6-ae7b-ebe114c15c00"), "Operations Management" },
                    { new Guid("e53776f9-eb9d-4a03-a510-5b1458292cc3"), "Entrepreneurship" },
                    { new Guid("e8795ac1-77b4-4c30-90eb-636537d7bd34"), "Email Marketing" },
                    { new Guid("f3675ef9-96bc-4e36-85be-4fcd3c599996"), "Emotional Intelligence" },
                    { new Guid("f53c00f3-9e4b-47e9-bf10-87738e6f421c"), "Adaptability" },
                    { new Guid("fc8ced59-5979-4fa9-94ff-68e112c5ccb0"), "Time Management" },
                    { new Guid("ffc61ffd-57b1-4bf0-8f58-bdca77d883b3"), "Problem Solving" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenteeApplications_FeedbackId",
                table: "MenteeApplications",
                column: "FeedbackId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenteeApplications_Feedbacks_FeedbackId",
                table: "MenteeApplications",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id");
        }
    }
}

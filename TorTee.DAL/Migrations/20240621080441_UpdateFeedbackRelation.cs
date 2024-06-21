using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFeedbackRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_AspNetUsers_MenteeId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_AspNetUsers_MentorId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_MenteeId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_MentorId",
                table: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("63804588-b07a-4cc9-b5a4-5ec27a9e1af8"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("a2945086-f99c-4812-8f76-9a0129bcbe03"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("ef9897d1-873a-4022-9eab-264d1560d30f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0a052113-73a3-49e7-8a83-01313ee83c4a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0c1ec588-2478-4519-92a4-49770a0a51e6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1311047e-9637-4467-bcb3-24f0396618d7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("20591672-1956-4265-a107-d6c5219a4ab7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("24334669-3bc5-4415-9d1a-dafa65ccedba"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("25c19b46-cf55-4242-a339-82913b5c67c6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2ff5163f-8c5e-478d-a2ea-0b9864f9a85c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("32577216-4376-4f13-9b0f-78da3e628934"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("327fb175-cec3-434f-bb2f-f1e5c8bd3a32"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3756c080-287b-4af7-811c-692f64aeb2f5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("396588f0-a0d8-4914-bed1-2bc53e969eee"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("49383ed4-2787-4cc9-adb7-12cee8d0367e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("49a352f7-330b-43ff-90ba-ed8adec9a2cc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4bfed839-4aec-46bc-bc87-00fdfa748ef9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4f2be819-05fc-4f80-a1a8-a44fa20cb993"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("525f7706-4383-4381-ae59-2ff438c9ed5b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5f22f55c-9984-4807-baa6-bcafd9bebedf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("627dba16-250d-4319-a421-a642f94f74ac"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("641294be-5457-4ebb-9a75-ebd011532d13"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6977fd1d-eecf-4e5a-b1ac-f36a0a99d3a3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6a6501a4-08de-48a1-8296-a179f5870803"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6bdf6923-be76-4d36-a71a-76747c1d7e25"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("72af7d7a-c249-4d1b-aa62-ccbd29c91729"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7718637b-bb5b-46cd-94ca-d3720759cea4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7b7fd4db-42c2-4062-91f3-76c800f5946e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7bc02f15-727c-4346-885b-117c22a25ad4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7d53755a-3107-4823-920a-b9a1dc954582"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("86042c3d-a918-40da-b343-e865628b8b4b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8a052ea6-28b1-47b9-83a1-d15c2304b8a2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8bc1b5fe-ac50-4238-8054-0a11a2608129"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8e66339d-1ebd-49c4-b8c5-a26a86f8fdd7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a7afc408-8adb-47cf-a609-6e0f2461c982"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a9316480-566b-4f0d-bbdb-4de8beef616b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b344c3e8-bc98-4953-bf9d-ddc2c80c1eab"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b6784b94-edef-48b7-9f49-e9d66d98d8b0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b6f719b4-2880-47dc-bda8-3e1f91240138"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c1fdada5-fd58-414d-9bc6-945cc8fafe63"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c7a5a7a2-8bb5-4655-baef-b198a13a1431"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cd3fd7b2-1af7-4ad7-b934-059abe070177"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d71ca8bc-e5b8-4be8-9493-4a8f9e9d873d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("de89fe9e-fa78-4e6f-a61d-0680065bf3f9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("df7944d7-35be-41ff-bd9c-8419973f2bab"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e2a02b7f-b17a-4e0d-917c-24fd3893c4ad"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("efc5c79a-c193-41c3-bfd8-c08cf0021ce4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f2b9027e-b7ba-4564-a0f4-3b55be5af1e4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f62b2461-0011-4ece-b6f6-36bb388e77a2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fb91a4af-a8d8-45cc-8d7f-08d6e11ab868"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ff8e9b2a-f08f-4075-8364-db8e07530e68"));

            migrationBuilder.DropColumn(
                name: "MenteeId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Feedbacks");

            migrationBuilder.AddColumn<Guid>(
                name: "FeedbackId",
                table: "MenteeApplications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reply",
                table: "Feedbacks",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FeedbackId",
                table: "MenteeApplications");

            migrationBuilder.DropColumn(
                name: "Reply",
                table: "Feedbacks");

            migrationBuilder.AddColumn<Guid>(
                name: "MenteeId",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MentorId",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("63804588-b07a-4cc9-b5a4-5ec27a9e1af8"), "When would you like to reach that goal?" },
                    { new Guid("a2945086-f99c-4812-8f76-9a0129bcbe03"), "Write a message to Mentor" },
                    { new Guid("ef9897d1-873a-4022-9eab-264d1560d30f"), "What best describes the goal of your mentorship?" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("0a052113-73a3-49e7-8a83-01313ee83c4a"), "Strategic Planning" },
                    { new Guid("0c1ec588-2478-4519-92a4-49770a0a51e6"), "Supply Chain Management" },
                    { new Guid("1311047e-9637-4467-bcb3-24f0396618d7"), "Time Management" },
                    { new Guid("20591672-1956-4265-a107-d6c5219a4ab7"), "Public Relations" },
                    { new Guid("24334669-3bc5-4415-9d1a-dafa65ccedba"), "Cybersecurity" },
                    { new Guid("25c19b46-cf55-4242-a339-82913b5c67c6"), "Software Development" },
                    { new Guid("2ff5163f-8c5e-478d-a2ea-0b9864f9a85c"), "Adaptability" },
                    { new Guid("32577216-4376-4f13-9b0f-78da3e628934"), "Web Development" },
                    { new Guid("327fb175-cec3-434f-bb2f-f1e5c8bd3a32"), "Communication" },
                    { new Guid("3756c080-287b-4af7-811c-692f64aeb2f5"), "Data Analysis" },
                    { new Guid("396588f0-a0d8-4914-bed1-2bc53e969eee"), "Risk Management" },
                    { new Guid("49383ed4-2787-4cc9-adb7-12cee8d0367e"), "Mobile Development" },
                    { new Guid("49a352f7-330b-43ff-90ba-ed8adec9a2cc"), "Negotiation" },
                    { new Guid("4bfed839-4aec-46bc-bc87-00fdfa748ef9"), "Creativity" },
                    { new Guid("4f2be819-05fc-4f80-a1a8-a44fa20cb993"), "Network Administration" },
                    { new Guid("525f7706-4383-4381-ae59-2ff438c9ed5b"), "Customer Service" },
                    { new Guid("5f22f55c-9984-4807-baa6-bcafd9bebedf"), "Database Management" },
                    { new Guid("627dba16-250d-4319-a421-a642f94f74ac"), "Problem Solving" },
                    { new Guid("641294be-5457-4ebb-9a75-ebd011532d13"), "Team Leadership" },
                    { new Guid("6977fd1d-eecf-4e5a-b1ac-f36a0a99d3a3"), "Financial Analysis" },
                    { new Guid("6a6501a4-08de-48a1-8296-a179f5870803"), "Project Management" },
                    { new Guid("6bdf6923-be76-4d36-a71a-76747c1d7e25"), "SEM (Search Engine Marketing)" },
                    { new Guid("72af7d7a-c249-4d1b-aa62-ccbd29c91729"), "Emotional Intelligence" },
                    { new Guid("7718637b-bb5b-46cd-94ca-d3720759cea4"), "Digital Marketing" },
                    { new Guid("7b7fd4db-42c2-4062-91f3-76c800f5946e"), "Work Ethic" },
                    { new Guid("7bc02f15-727c-4346-885b-117c22a25ad4"), "Blockchain" },
                    { new Guid("7d53755a-3107-4823-920a-b9a1dc954582"), "Market Research" },
                    { new Guid("86042c3d-a918-40da-b343-e865628b8b4b"), "Collaboration" },
                    { new Guid("8a052ea6-28b1-47b9-83a1-d15c2304b8a2"), "Cloud Computing" },
                    { new Guid("8bc1b5fe-ac50-4238-8054-0a11a2608129"), "Artificial Intelligence" },
                    { new Guid("8e66339d-1ebd-49c4-b8c5-a26a86f8fdd7"), "DevOps" },
                    { new Guid("a7afc408-8adb-47cf-a609-6e0f2461c982"), "Machine Learning" },
                    { new Guid("a9316480-566b-4f0d-bbdb-4de8beef616b"), "Business Analysis" },
                    { new Guid("b344c3e8-bc98-4953-bf9d-ddc2c80c1eab"), "SEO (Search Engine Optimization)" },
                    { new Guid("b6784b94-edef-48b7-9f49-e9d66d98d8b0"), "Content Marketing" },
                    { new Guid("b6f719b4-2880-47dc-bda8-3e1f91240138"), "Email Marketing" },
                    { new Guid("c1fdada5-fd58-414d-9bc6-945cc8fafe63"), "Interpersonal Skills" },
                    { new Guid("c7a5a7a2-8bb5-4655-baef-b198a13a1431"), "Business Strategy" },
                    { new Guid("cd3fd7b2-1af7-4ad7-b934-059abe070177"), "IT Support" },
                    { new Guid("d71ca8bc-e5b8-4be8-9493-4a8f9e9d873d"), "Operations Management" },
                    { new Guid("de89fe9e-fa78-4e6f-a61d-0680065bf3f9"), "Brand Management" },
                    { new Guid("df7944d7-35be-41ff-bd9c-8419973f2bab"), "Conflict Resolution" },
                    { new Guid("e2a02b7f-b17a-4e0d-917c-24fd3893c4ad"), "Social Media Marketing" },
                    { new Guid("efc5c79a-c193-41c3-bfd8-c08cf0021ce4"), "Product Management" },
                    { new Guid("f2b9027e-b7ba-4564-a0f4-3b55be5af1e4"), "Sales" },
                    { new Guid("f62b2461-0011-4ece-b6f6-36bb388e77a2"), "Graphic Design" },
                    { new Guid("fb91a4af-a8d8-45cc-8d7f-08d6e11ab868"), "Critical Thinking" },
                    { new Guid("ff8e9b2a-f08f-4075-8364-db8e07530e68"), "Entrepreneurship" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_MenteeId",
                table: "Feedbacks",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_MentorId",
                table: "Feedbacks",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_AspNetUsers_MenteeId",
                table: "Feedbacks",
                column: "MenteeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_AspNetUsers_MentorId",
                table: "Feedbacks",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

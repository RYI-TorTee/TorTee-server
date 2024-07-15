using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SaveOrderCodeOfPaymentToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "OrderCode",
                table: "MenteeApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("06f21192-89fd-4268-86fb-50b3acf74bd4"), "Write a message to Mentor" },
                    { new Guid("219e217a-d39e-4ce3-bbe1-a42155e08dc6"), "What best describes the goal of your mentorship?" },
                    { new Guid("d48c368b-8e56-406d-a256-86f4f2565c53"), "When would you like to reach that goal?" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("0493d13f-a2e6-44df-a813-5ec2859bf6e4"), "Email Marketing" },
                    { new Guid("0544eeef-c5c4-457b-9517-3de80d6b71a8"), "Collaboration" },
                    { new Guid("0848deee-8e54-4b76-a913-b0395e9f5572"), "Cybersecurity" },
                    { new Guid("0ce685a7-b24c-4ef8-9127-c438406bb744"), "Project Management" },
                    { new Guid("0e124843-2a49-4c8c-8a0f-4db5d353ca85"), "Brand Management" },
                    { new Guid("18167518-b1de-4c45-bc23-dc8a094eee8d"), "Mobile Development" },
                    { new Guid("18625b9a-5e66-4dec-9ff1-c78aab8f0f1d"), "Strategic Planning" },
                    { new Guid("1970ac49-06db-4853-a38b-ad0a40856e8d"), "Operations Management" },
                    { new Guid("1993505d-c822-4392-b72a-ff40688dd673"), "Customer Service" },
                    { new Guid("1b421d7c-dbe7-4c5e-acc1-bf02dd56438f"), "Communication" },
                    { new Guid("22125c2a-d011-4361-85d3-a055536724e0"), "DevOps" },
                    { new Guid("26297944-a37f-4f6e-9495-9ef34dcf795f"), "Web Development" },
                    { new Guid("326ed27e-ed02-40ea-8582-a8b195b95b1b"), "Content Marketing" },
                    { new Guid("3305178e-d1dc-4fce-9bb2-72ccad5f66d8"), "Work Ethic" },
                    { new Guid("34a8ed3f-d4d3-44c7-b0be-d9bbb2ae1d0e"), "Digital Marketing" },
                    { new Guid("377c6c17-a99f-41ab-9cf7-265260abda5f"), "Business Analysis" },
                    { new Guid("3c782336-d9cd-4a8b-8fbe-b4559ac9acc8"), "Adaptability" },
                    { new Guid("41f83963-b68c-407f-bc63-bacaadf94116"), "Creativity" },
                    { new Guid("42a84a06-e992-4ca6-9ddf-43b95a56c371"), "SEM (Search Engine Marketing)" },
                    { new Guid("436cd31e-b822-4515-8c02-88e8e9c02bd0"), "SEO (Search Engine Optimization)" },
                    { new Guid("4e0e11a0-cea6-4737-b9fa-889224ed7897"), "Financial Analysis" },
                    { new Guid("510bee0b-6ae2-4481-99b6-f5ed0cd17272"), "Market Research" },
                    { new Guid("5ecfc77c-37a9-4e23-b52c-9a23a6f38a03"), "Negotiation" },
                    { new Guid("6e39f87a-0d68-4cb4-88d1-470c67064e5b"), "Team Leadership" },
                    { new Guid("72ade5b0-b911-430e-9526-7d6e4a3ad758"), "Critical Thinking" },
                    { new Guid("72c141a5-b4a9-4296-a3b1-1c6dcd5064b7"), "Software Development" },
                    { new Guid("7d9e635d-fd63-4af2-a3e0-bc56be1582c4"), "Sales" },
                    { new Guid("7e108e11-e395-4784-b3dc-6fb9b754905b"), "Problem Solving" },
                    { new Guid("8d3bc614-b249-4e9a-9023-53afcac9d5a8"), "Blockchain" },
                    { new Guid("9385d796-c145-4307-a422-23c5a2c25c46"), "Emotional Intelligence" },
                    { new Guid("a292f829-6aee-4c92-8614-652b48c48b66"), "Risk Management" },
                    { new Guid("a34aaae6-b255-4d67-aa52-35e98a7ab9b6"), "IT Support" },
                    { new Guid("a8628e62-8605-4fea-af48-9215834b69c8"), "Data Analysis" },
                    { new Guid("a95a666c-41f4-4bce-ac0f-c90e322d29fb"), "Database Management" },
                    { new Guid("acb6f003-643d-41a4-8f26-8977f5127d0f"), "Conflict Resolution" },
                    { new Guid("ace8ba9b-47b6-4d1d-acbc-038bc587c34e"), "Time Management" },
                    { new Guid("acf119cf-b230-4208-802f-4f62c8f7c77b"), "Supply Chain Management" },
                    { new Guid("b52df08d-5b64-42de-b0d6-5cf073df38e3"), "Interpersonal Skills" },
                    { new Guid("c3071259-a815-4bf2-b188-69d3d2bb163f"), "Product Management" },
                    { new Guid("c377dff7-3ce4-43ae-b49d-ede3eafe5b11"), "Graphic Design" },
                    { new Guid("ce9698aa-dbd8-483d-848d-13aca7195dbe"), "Public Relations" },
                    { new Guid("d85b63e4-71a4-4ea7-9a88-e972790cf7f2"), "Business Strategy" },
                    { new Guid("dbadcb41-80d3-4eeb-9e74-81f31354b655"), "Cloud Computing" },
                    { new Guid("e2019b16-722a-44df-bb77-41cb47401511"), "Social Media Marketing" },
                    { new Guid("e8a137d1-14f3-4445-9f14-507e2cfa9caa"), "Network Administration" },
                    { new Guid("eea37ca5-5664-49fd-b5ec-6ae80bfee508"), "Entrepreneurship" },
                    { new Guid("f403d3db-79be-443b-be5b-1caae100f135"), "Artificial Intelligence" },
                    { new Guid("fcf03cb5-3f0a-483e-8cce-51d2b0dd4085"), "Machine Learning" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("06f21192-89fd-4268-86fb-50b3acf74bd4"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("219e217a-d39e-4ce3-bbe1-a42155e08dc6"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("d48c368b-8e56-406d-a256-86f4f2565c53"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0493d13f-a2e6-44df-a813-5ec2859bf6e4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0544eeef-c5c4-457b-9517-3de80d6b71a8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0848deee-8e54-4b76-a913-b0395e9f5572"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0ce685a7-b24c-4ef8-9127-c438406bb744"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0e124843-2a49-4c8c-8a0f-4db5d353ca85"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("18167518-b1de-4c45-bc23-dc8a094eee8d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("18625b9a-5e66-4dec-9ff1-c78aab8f0f1d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1970ac49-06db-4853-a38b-ad0a40856e8d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1993505d-c822-4392-b72a-ff40688dd673"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1b421d7c-dbe7-4c5e-acc1-bf02dd56438f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("22125c2a-d011-4361-85d3-a055536724e0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("26297944-a37f-4f6e-9495-9ef34dcf795f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("326ed27e-ed02-40ea-8582-a8b195b95b1b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3305178e-d1dc-4fce-9bb2-72ccad5f66d8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("34a8ed3f-d4d3-44c7-b0be-d9bbb2ae1d0e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("377c6c17-a99f-41ab-9cf7-265260abda5f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3c782336-d9cd-4a8b-8fbe-b4559ac9acc8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("41f83963-b68c-407f-bc63-bacaadf94116"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("42a84a06-e992-4ca6-9ddf-43b95a56c371"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("436cd31e-b822-4515-8c02-88e8e9c02bd0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4e0e11a0-cea6-4737-b9fa-889224ed7897"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("510bee0b-6ae2-4481-99b6-f5ed0cd17272"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5ecfc77c-37a9-4e23-b52c-9a23a6f38a03"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6e39f87a-0d68-4cb4-88d1-470c67064e5b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("72ade5b0-b911-430e-9526-7d6e4a3ad758"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("72c141a5-b4a9-4296-a3b1-1c6dcd5064b7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7d9e635d-fd63-4af2-a3e0-bc56be1582c4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7e108e11-e395-4784-b3dc-6fb9b754905b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8d3bc614-b249-4e9a-9023-53afcac9d5a8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9385d796-c145-4307-a422-23c5a2c25c46"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a292f829-6aee-4c92-8614-652b48c48b66"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a34aaae6-b255-4d67-aa52-35e98a7ab9b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a8628e62-8605-4fea-af48-9215834b69c8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a95a666c-41f4-4bce-ac0f-c90e322d29fb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("acb6f003-643d-41a4-8f26-8977f5127d0f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ace8ba9b-47b6-4d1d-acbc-038bc587c34e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("acf119cf-b230-4208-802f-4f62c8f7c77b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b52df08d-5b64-42de-b0d6-5cf073df38e3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c3071259-a815-4bf2-b188-69d3d2bb163f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c377dff7-3ce4-43ae-b49d-ede3eafe5b11"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ce9698aa-dbd8-483d-848d-13aca7195dbe"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d85b63e4-71a4-4ea7-9a88-e972790cf7f2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("dbadcb41-80d3-4eeb-9e74-81f31354b655"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e2019b16-722a-44df-bb77-41cb47401511"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e8a137d1-14f3-4445-9f14-507e2cfa9caa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eea37ca5-5664-49fd-b5ec-6ae80bfee508"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f403d3db-79be-443b-be5b-1caae100f135"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fcf03cb5-3f0a-483e-8cce-51d2b0dd4085"));

            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "MenteeApplications");

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
        }
    }
}

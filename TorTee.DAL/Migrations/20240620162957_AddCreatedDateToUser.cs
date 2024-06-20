using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedDateToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("08674402-f177-43f4-83c4-dbcaa66e1f7c"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("20c47693-bae1-47c1-b707-f94a04af0582"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("fe0ebb61-12b3-4fb8-99f9-8e5caf5c3301"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("04999a8d-5543-4f8d-a116-d8a4eb60de8f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("060a6a24-2999-4db6-8ba5-1967370f3fe0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("08eface8-59b8-4e1f-b7e9-ab3749469f57"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0cc9fb20-172c-45a5-95c4-dc553ae5ba0c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0e4422d6-84a7-4327-94ab-4fde64389a3d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("103f77c8-7280-4812-a0a4-ae110bfc8a12"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("16dce83d-00df-4583-99a4-cfad499c6560"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1bb626b6-ae6d-499b-8e9b-f56bcbeefed2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1ca78eb9-3b77-4622-9880-a1ec1631d92d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("200d4540-27d2-47aa-ad90-42ba3ac2c804"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("261bce89-ffe7-46b0-8dc7-3bd6cd9ab0a6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2a3c741b-1e25-4ad8-8b31-1747fb12cac1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2b22a17d-3e1f-43ba-bd95-c022900effd7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3153f1dc-6400-4ac3-849d-f0602cbee025"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3b7616fe-577b-461c-afba-6d80f0ae1092"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3fc4035f-0b2c-4451-add8-12fa6cdd5992"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3fcd5ac1-fff8-40ac-a780-cbda6d4307c1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("428828fa-e3a3-4ac8-ac5e-c995355d0580"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4ad44c76-2726-40ad-ac92-15c1a19aaba0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4c1c7f10-c676-462a-9adb-58869d7cb64a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4ca31c64-55a8-4d50-bc77-c97dce4d98df"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5f188639-d28b-4f48-84d1-484653cd0cc0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("63569316-eeb5-48b2-a2c8-3f608fc0434e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("73ee3624-c90a-4759-855f-39131740a386"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("81338730-d088-43b7-bdec-93234b1c22db"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("85bcf89c-3b7f-4648-b104-e39ec40c61a7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8961c7aa-5769-48fc-bef1-696757d7e05c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8d041a7c-3496-4e8c-9e33-d1b4ef8bd365"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8ea60a9e-9d02-4974-a9cf-cf9d0d4750cb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8f75f053-2cca-4cb7-91f2-88c966609ffd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("926efd49-0ec7-48eb-a8b1-eea9b10e4be5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("927a1c6d-8c1f-482a-87f9-0cbdadd18bb9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a2a15503-5fdb-4b77-8904-575c5f7caff4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a69ea62e-bcd4-40f1-af9e-e67f5c2ad1f1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b2df286b-bae3-4ebd-94d8-8ec5c06b0033"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b315a800-0782-48c7-906a-bb6126e38797"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b6320eb7-5373-469c-8371-61f366e3febd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ba5a2a00-f91a-42be-9eb9-65854907e67d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cc2fbe38-61e3-47fe-badf-58a92be72db1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cefddcfe-eca1-49b0-acdb-71abbf33f999"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d454c908-e9c3-4a5b-83ad-2e81ecfae67e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e154df7d-f44b-4c0e-a4bf-db4e5eed8216"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e39935e3-3f79-47c6-b5e2-2e9ece19291e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e5e1075a-71eb-49ca-a327-24cb3f3c451e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ea0900ad-927a-4add-9ecd-872b650a9bae"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ec07ffc9-54c9-4fd5-b0e8-b109b8516f1b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fb9a2293-ceab-4ed4-8b06-2b4d66aa652e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fe86c6d9-e17b-4bc7-ae22-d254b062ee80"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("0c3ba8f5-b11e-453c-a0e5-d6d24ca7ccae"), "Write a message to Mentor" },
                    { new Guid("0f85cab3-6cb2-4ad7-abed-51a55f66b573"), "What best describes the goal of your mentorship?" },
                    { new Guid("507945e8-53dc-4599-b209-f9e3c3dce7c3"), "When would you like to reach that goal?" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("007345af-9128-4500-9bba-4730a5aa3373"), "Critical Thinking" },
                    { new Guid("0944463a-cf1f-4551-ab64-5bfa3989a334"), "Time Management" },
                    { new Guid("125c125f-d0f3-4155-ab56-e4898903f79b"), "Adaptability" },
                    { new Guid("1678ed08-fd4a-49e8-b39c-d3fe10427ad1"), "Machine Learning" },
                    { new Guid("1aa60744-671a-413b-9b05-b0079d7de0fe"), "Conflict Resolution" },
                    { new Guid("2f28cfe4-3cb4-46b9-b5c6-efe5ebfc397d"), "Market Research" },
                    { new Guid("316ab57c-278f-4bde-8eee-daf33893e9df"), "Risk Management" },
                    { new Guid("35953401-171c-4a5c-b65f-a6645798974d"), "Work Ethic" },
                    { new Guid("3ca95a18-06e3-4715-a712-76a1f5313a0a"), "Blockchain" },
                    { new Guid("4deca1ab-4679-421c-b948-0acbc57b9fbe"), "Emotional Intelligence" },
                    { new Guid("55f2d4a7-a1c0-4357-b174-fc62b9bf0ac6"), "Data Analysis" },
                    { new Guid("5c212e74-ba52-4045-94d7-093bc3c7a065"), "Social Media Marketing" },
                    { new Guid("7173477c-d9f7-4295-83e4-a49d7a91d98f"), "Problem Solving" },
                    { new Guid("74c94471-a90d-4cbb-89c8-26f76e9eb1da"), "Business Analysis" },
                    { new Guid("772e6615-d790-430f-9551-d30abab1bb82"), "Interpersonal Skills" },
                    { new Guid("7dd9f4dd-48f6-4fa0-a345-51b2376a7e46"), "Negotiation" },
                    { new Guid("80983a65-6b92-48dc-a42e-040d9edaf652"), "Communication" },
                    { new Guid("884d852c-af3f-41c0-8890-cd08d449f99b"), "Collaboration" },
                    { new Guid("8d116581-703e-488f-8fe7-e78efbf58bc7"), "Supply Chain Management" },
                    { new Guid("8ef99ab8-a3d5-4560-b584-21e175c7e33f"), "SEM (Search Engine Marketing)" },
                    { new Guid("913e3d2b-8946-4ca0-861e-639232892250"), "Creativity" },
                    { new Guid("9d37c243-c31b-4db0-a58b-050185a03638"), "DevOps" },
                    { new Guid("9f19f072-69cd-4b3e-a37f-8f7d95b79a74"), "Cloud Computing" },
                    { new Guid("a4788496-ae42-453c-b14e-f8632c2e1d0e"), "Business Strategy" },
                    { new Guid("a52b786d-a59d-45f7-8299-1868737328ac"), "Database Management" },
                    { new Guid("b57d3f03-7674-43e4-9b80-53a1d127d931"), "Team Leadership" },
                    { new Guid("b815e683-897f-4cf0-81d1-f0a6350e0e2e"), "Product Management" },
                    { new Guid("b9ceee0e-90a8-4bbd-8bcd-b92a3078e173"), "Graphic Design" },
                    { new Guid("bfeb9b13-38ba-4938-9a88-ebe34d02365e"), "Network Administration" },
                    { new Guid("c034923f-131f-4d7c-9f23-11193f6150bd"), "Sales" },
                    { new Guid("c04f3df7-7344-4471-9769-f5ee89365096"), "Email Marketing" },
                    { new Guid("c1b5467a-51d8-4de0-a739-62b239b4f22a"), "Mobile Development" },
                    { new Guid("d02dbbcb-d46a-4031-8507-1dcecf3f12f4"), "Strategic Planning" },
                    { new Guid("d258af73-48a9-4339-aa7b-9399f31c8306"), "IT Support" },
                    { new Guid("d339362c-8808-46ed-8062-72952a03c7bf"), "Cybersecurity" },
                    { new Guid("dc83e261-1aa5-4a56-827e-4a1222fa384b"), "Web Development" },
                    { new Guid("dd182674-a0b6-4bb5-81d9-665205175858"), "Project Management" },
                    { new Guid("e0f7c2a0-ffcb-4ab1-a0ef-52afc7a1c8ef"), "Public Relations" },
                    { new Guid("e50ca9de-2274-4d6a-8593-265d871a667d"), "SEO (Search Engine Optimization)" },
                    { new Guid("e764bbf9-7868-444a-8cba-0662f9f3f431"), "Customer Service" },
                    { new Guid("ebc9d2e7-fd96-4ed0-9681-51d2d89cd990"), "Operations Management" },
                    { new Guid("ee99c0cd-9e61-4d49-a8cd-4045f86a925e"), "Artificial Intelligence" },
                    { new Guid("f1ca153e-152b-4442-9fc3-973fa37b5880"), "Brand Management" },
                    { new Guid("f32160a6-2b1e-45e4-ab2f-961b0230421e"), "Entrepreneurship" },
                    { new Guid("f3b24c30-758a-49bd-b82b-26a275cb0aca"), "Software Development" },
                    { new Guid("f6510b51-fc15-41ae-b79d-4ba13196a0c7"), "Content Marketing" },
                    { new Guid("f78f25f6-1d7d-474b-81cb-f6468f5adc7e"), "Financial Analysis" },
                    { new Guid("fbcbd389-d92e-404d-9a80-24b86270f879"), "Digital Marketing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("0c3ba8f5-b11e-453c-a0e5-d6d24ca7ccae"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("0f85cab3-6cb2-4ad7-abed-51a55f66b573"));

            migrationBuilder.DeleteData(
                table: "ApplicationQuestion",
                keyColumn: "Id",
                keyValue: new Guid("507945e8-53dc-4599-b209-f9e3c3dce7c3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("007345af-9128-4500-9bba-4730a5aa3373"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0944463a-cf1f-4551-ab64-5bfa3989a334"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("125c125f-d0f3-4155-ab56-e4898903f79b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1678ed08-fd4a-49e8-b39c-d3fe10427ad1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1aa60744-671a-413b-9b05-b0079d7de0fe"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2f28cfe4-3cb4-46b9-b5c6-efe5ebfc397d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("316ab57c-278f-4bde-8eee-daf33893e9df"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("35953401-171c-4a5c-b65f-a6645798974d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3ca95a18-06e3-4715-a712-76a1f5313a0a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4deca1ab-4679-421c-b948-0acbc57b9fbe"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("55f2d4a7-a1c0-4357-b174-fc62b9bf0ac6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5c212e74-ba52-4045-94d7-093bc3c7a065"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7173477c-d9f7-4295-83e4-a49d7a91d98f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("74c94471-a90d-4cbb-89c8-26f76e9eb1da"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("772e6615-d790-430f-9551-d30abab1bb82"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7dd9f4dd-48f6-4fa0-a345-51b2376a7e46"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("80983a65-6b92-48dc-a42e-040d9edaf652"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("884d852c-af3f-41c0-8890-cd08d449f99b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8d116581-703e-488f-8fe7-e78efbf58bc7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8ef99ab8-a3d5-4560-b584-21e175c7e33f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("913e3d2b-8946-4ca0-861e-639232892250"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9d37c243-c31b-4db0-a58b-050185a03638"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9f19f072-69cd-4b3e-a37f-8f7d95b79a74"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a4788496-ae42-453c-b14e-f8632c2e1d0e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a52b786d-a59d-45f7-8299-1868737328ac"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b57d3f03-7674-43e4-9b80-53a1d127d931"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b815e683-897f-4cf0-81d1-f0a6350e0e2e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b9ceee0e-90a8-4bbd-8bcd-b92a3078e173"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bfeb9b13-38ba-4938-9a88-ebe34d02365e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c034923f-131f-4d7c-9f23-11193f6150bd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c04f3df7-7344-4471-9769-f5ee89365096"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c1b5467a-51d8-4de0-a739-62b239b4f22a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d02dbbcb-d46a-4031-8507-1dcecf3f12f4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d258af73-48a9-4339-aa7b-9399f31c8306"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d339362c-8808-46ed-8062-72952a03c7bf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("dc83e261-1aa5-4a56-827e-4a1222fa384b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("dd182674-a0b6-4bb5-81d9-665205175858"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e0f7c2a0-ffcb-4ab1-a0ef-52afc7a1c8ef"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e50ca9de-2274-4d6a-8593-265d871a667d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e764bbf9-7868-444a-8cba-0662f9f3f431"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ebc9d2e7-fd96-4ed0-9681-51d2d89cd990"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ee99c0cd-9e61-4d49-a8cd-4045f86a925e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f1ca153e-152b-4442-9fc3-973fa37b5880"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f32160a6-2b1e-45e4-ab2f-961b0230421e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f3b24c30-758a-49bd-b82b-26a275cb0aca"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f6510b51-fc15-41ae-b79d-4ba13196a0c7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f78f25f6-1d7d-474b-81cb-f6468f5adc7e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fbcbd389-d92e-404d-9a80-24b86270f879"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "ApplicationQuestion",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { new Guid("08674402-f177-43f4-83c4-dbcaa66e1f7c"), "Write a message to Mentor" },
                    { new Guid("20c47693-bae1-47c1-b707-f94a04af0582"), "What best describes the goal of your mentorship?" },
                    { new Guid("fe0ebb61-12b3-4fb8-99f9-8e5caf5c3301"), "When would you like to reach that goal?" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { new Guid("04999a8d-5543-4f8d-a116-d8a4eb60de8f"), "Database Management" },
                    { new Guid("060a6a24-2999-4db6-8ba5-1967370f3fe0"), "Customer Service" },
                    { new Guid("08eface8-59b8-4e1f-b7e9-ab3749469f57"), "Critical Thinking" },
                    { new Guid("0cc9fb20-172c-45a5-95c4-dc553ae5ba0c"), "Collaboration" },
                    { new Guid("0e4422d6-84a7-4327-94ab-4fde64389a3d"), "Sales" },
                    { new Guid("103f77c8-7280-4812-a0a4-ae110bfc8a12"), "Creativity" },
                    { new Guid("16dce83d-00df-4583-99a4-cfad499c6560"), "Software Development" },
                    { new Guid("1bb626b6-ae6d-499b-8e9b-f56bcbeefed2"), "Data Analysis" },
                    { new Guid("1ca78eb9-3b77-4622-9880-a1ec1631d92d"), "Artificial Intelligence" },
                    { new Guid("200d4540-27d2-47aa-ad90-42ba3ac2c804"), "Strategic Planning" },
                    { new Guid("261bce89-ffe7-46b0-8dc7-3bd6cd9ab0a6"), "Blockchain" },
                    { new Guid("2a3c741b-1e25-4ad8-8b31-1747fb12cac1"), "Communication" },
                    { new Guid("2b22a17d-3e1f-43ba-bd95-c022900effd7"), "Business Strategy" },
                    { new Guid("3153f1dc-6400-4ac3-849d-f0602cbee025"), "Problem Solving" },
                    { new Guid("3b7616fe-577b-461c-afba-6d80f0ae1092"), "Machine Learning" },
                    { new Guid("3fc4035f-0b2c-4451-add8-12fa6cdd5992"), "Operations Management" },
                    { new Guid("3fcd5ac1-fff8-40ac-a780-cbda6d4307c1"), "Web Development" },
                    { new Guid("428828fa-e3a3-4ac8-ac5e-c995355d0580"), "Interpersonal Skills" },
                    { new Guid("4ad44c76-2726-40ad-ac92-15c1a19aaba0"), "SEO (Search Engine Optimization)" },
                    { new Guid("4c1c7f10-c676-462a-9adb-58869d7cb64a"), "Mobile Development" },
                    { new Guid("4ca31c64-55a8-4d50-bc77-c97dce4d98df"), "Work Ethic" },
                    { new Guid("5f188639-d28b-4f48-84d1-484653cd0cc0"), "Social Media Marketing" },
                    { new Guid("63569316-eeb5-48b2-a2c8-3f608fc0434e"), "DevOps" },
                    { new Guid("73ee3624-c90a-4759-855f-39131740a386"), "Cloud Computing" },
                    { new Guid("81338730-d088-43b7-bdec-93234b1c22db"), "Emotional Intelligence" },
                    { new Guid("85bcf89c-3b7f-4648-b104-e39ec40c61a7"), "Product Management" },
                    { new Guid("8961c7aa-5769-48fc-bef1-696757d7e05c"), "Content Marketing" },
                    { new Guid("8d041a7c-3496-4e8c-9e33-d1b4ef8bd365"), "Public Relations" },
                    { new Guid("8ea60a9e-9d02-4974-a9cf-cf9d0d4750cb"), "Adaptability" },
                    { new Guid("8f75f053-2cca-4cb7-91f2-88c966609ffd"), "Market Research" },
                    { new Guid("926efd49-0ec7-48eb-a8b1-eea9b10e4be5"), "Network Administration" },
                    { new Guid("927a1c6d-8c1f-482a-87f9-0cbdadd18bb9"), "Negotiation" },
                    { new Guid("a2a15503-5fdb-4b77-8904-575c5f7caff4"), "Brand Management" },
                    { new Guid("a69ea62e-bcd4-40f1-af9e-e67f5c2ad1f1"), "SEM (Search Engine Marketing)" },
                    { new Guid("b2df286b-bae3-4ebd-94d8-8ec5c06b0033"), "Entrepreneurship" },
                    { new Guid("b315a800-0782-48c7-906a-bb6126e38797"), "IT Support" },
                    { new Guid("b6320eb7-5373-469c-8371-61f366e3febd"), "Supply Chain Management" },
                    { new Guid("ba5a2a00-f91a-42be-9eb9-65854907e67d"), "Team Leadership" },
                    { new Guid("cc2fbe38-61e3-47fe-badf-58a92be72db1"), "Project Management" },
                    { new Guid("cefddcfe-eca1-49b0-acdb-71abbf33f999"), "Graphic Design" },
                    { new Guid("d454c908-e9c3-4a5b-83ad-2e81ecfae67e"), "Financial Analysis" },
                    { new Guid("e154df7d-f44b-4c0e-a4bf-db4e5eed8216"), "Business Analysis" },
                    { new Guid("e39935e3-3f79-47c6-b5e2-2e9ece19291e"), "Cybersecurity" },
                    { new Guid("e5e1075a-71eb-49ca-a327-24cb3f3c451e"), "Email Marketing" },
                    { new Guid("ea0900ad-927a-4add-9ecd-872b650a9bae"), "Digital Marketing" },
                    { new Guid("ec07ffc9-54c9-4fd5-b0e8-b109b8516f1b"), "Risk Management" },
                    { new Guid("fb9a2293-ceab-4ed4-8b06-2b4d66aa652e"), "Conflict Resolution" },
                    { new Guid("fe86c6d9-e17b-4bc7-ae22-d254b062ee80"), "Time Management" }
                });
        }
    }
}

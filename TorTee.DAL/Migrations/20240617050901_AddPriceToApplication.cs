using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "MenteeApplications",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MenteeApplications");

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
        }
    }
}

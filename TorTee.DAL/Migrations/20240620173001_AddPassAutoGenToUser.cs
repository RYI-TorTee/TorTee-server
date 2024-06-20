using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TorTee.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddPassAutoGenToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PassAutoGenerate",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "PassAutoGenerate",
                table: "AspNetUsers");

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
    }
}

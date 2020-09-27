using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Application.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "LastName", "Password", "UserId", "Username" },
                values: new object[,]
                {
                    { new Guid("417ce6e2-e563-43ce-8dfc-7d54e032b83e"), "TempEmail 1 @hotmail.com", " FirstName 1 ", false, " LastName 1 ", "! 1 ! Password", 1, "Username 1 " },
                    { new Guid("18a5433a-6d02-46e9-bddd-3c34ef4816b3"), "TempEmail 28 @hotmail.com", " FirstName 28 ", false, " LastName 28 ", "! 28 ! Password", 28, "Username 28 " },
                    { new Guid("f150fcd0-8582-43e3-8646-331c011d7368"), "TempEmail 29 @hotmail.com", " FirstName 29 ", false, " LastName 29 ", "! 29 ! Password", 29, "Username 29 " },
                    { new Guid("e939d6e6-47f7-405f-9602-4551c370d215"), "TempEmail 30 @hotmail.com", " FirstName 30 ", false, " LastName 30 ", "! 30 ! Password", 30, "Username 30 " },
                    { new Guid("d191aba7-827a-4c48-b4df-7e71ee26826e"), "TempEmail 31 @hotmail.com", " FirstName 31 ", false, " LastName 31 ", "! 31 ! Password", 31, "Username 31 " },
                    { new Guid("49022534-4320-44af-a40c-eaf0b5a48a34"), "TempEmail 32 @hotmail.com", " FirstName 32 ", false, " LastName 32 ", "! 32 ! Password", 32, "Username 32 " },
                    { new Guid("ae7a85c6-1845-4c45-a89c-5c5887a31e47"), "TempEmail 33 @hotmail.com", " FirstName 33 ", false, " LastName 33 ", "! 33 ! Password", 33, "Username 33 " },
                    { new Guid("0262d37d-9124-46e5-a7c0-cd812e664f72"), "TempEmail 34 @hotmail.com", " FirstName 34 ", false, " LastName 34 ", "! 34 ! Password", 34, "Username 34 " },
                    { new Guid("e87b8d27-0ef7-41fb-b815-a248087c84c6"), "TempEmail 35 @hotmail.com", " FirstName 35 ", false, " LastName 35 ", "! 35 ! Password", 35, "Username 35 " },
                    { new Guid("81de4ed0-fa61-4fde-a9c5-077ac2c6f9e3"), "TempEmail 36 @hotmail.com", " FirstName 36 ", false, " LastName 36 ", "! 36 ! Password", 36, "Username 36 " },
                    { new Guid("b16fbe2b-adf9-425d-82ea-773650526604"), "TempEmail 37 @hotmail.com", " FirstName 37 ", false, " LastName 37 ", "! 37 ! Password", 37, "Username 37 " },
                    { new Guid("7568d273-d856-45de-b0f0-854a3e0d0af7"), "TempEmail 38 @hotmail.com", " FirstName 38 ", false, " LastName 38 ", "! 38 ! Password", 38, "Username 38 " },
                    { new Guid("d0a67dfb-a0c1-4189-be40-3ce12fc93295"), "TempEmail 39 @hotmail.com", " FirstName 39 ", false, " LastName 39 ", "! 39 ! Password", 39, "Username 39 " },
                    { new Guid("126d12f6-5ff3-4978-98ba-2a27c287d1cf"), "TempEmail 40 @hotmail.com", " FirstName 40 ", false, " LastName 40 ", "! 40 ! Password", 40, "Username 40 " },
                    { new Guid("869dc515-666a-4557-82c8-56d8b93b4546"), "TempEmail 41 @hotmail.com", " FirstName 41 ", false, " LastName 41 ", "! 41 ! Password", 41, "Username 41 " },
                    { new Guid("4b825af9-b9ce-4cf8-96d4-22834c0692f9"), "TempEmail 42 @hotmail.com", " FirstName 42 ", false, " LastName 42 ", "! 42 ! Password", 42, "Username 42 " },
                    { new Guid("b0189d88-0a98-4fce-b631-b5e4e4206765"), "TempEmail 43 @hotmail.com", " FirstName 43 ", false, " LastName 43 ", "! 43 ! Password", 43, "Username 43 " },
                    { new Guid("ba093501-3f30-435e-81b6-456e177fb2eb"), "TempEmail 44 @hotmail.com", " FirstName 44 ", false, " LastName 44 ", "! 44 ! Password", 44, "Username 44 " },
                    { new Guid("e2b05840-7bb4-4699-9713-5438c2dd0909"), "TempEmail 45 @hotmail.com", " FirstName 45 ", false, " LastName 45 ", "! 45 ! Password", 45, "Username 45 " },
                    { new Guid("2409f541-e972-4e0b-8857-99656410d33c"), "TempEmail 46 @hotmail.com", " FirstName 46 ", false, " LastName 46 ", "! 46 ! Password", 46, "Username 46 " },
                    { new Guid("559d455f-27a0-432f-bb1b-82a36847b51d"), "TempEmail 47 @hotmail.com", " FirstName 47 ", false, " LastName 47 ", "! 47 ! Password", 47, "Username 47 " },
                    { new Guid("f498973a-e29b-4809-95ff-681510d65dec"), "TempEmail 48 @hotmail.com", " FirstName 48 ", false, " LastName 48 ", "! 48 ! Password", 48, "Username 48 " },
                    { new Guid("4314c135-84f6-460d-a1a2-9d1360fa40c0"), "TempEmail 27 @hotmail.com", " FirstName 27 ", false, " LastName 27 ", "! 27 ! Password", 27, "Username 27 " },
                    { new Guid("6ea4f61e-2921-42bd-a3e2-823741dd2770"), "TempEmail 26 @hotmail.com", " FirstName 26 ", false, " LastName 26 ", "! 26 ! Password", 26, "Username 26 " },
                    { new Guid("3e8bf9ed-99b2-41dd-a3ca-b9ce49865f76"), "TempEmail 25 @hotmail.com", " FirstName 25 ", false, " LastName 25 ", "! 25 ! Password", 25, "Username 25 " },
                    { new Guid("0715b3b3-83b9-4769-8352-9fa64a0c7b26"), "TempEmail 24 @hotmail.com", " FirstName 24 ", false, " LastName 24 ", "! 24 ! Password", 24, "Username 24 " },
                    { new Guid("d49c366f-4e10-4dd2-8662-d3f935f888af"), "TempEmail 2 @hotmail.com", " FirstName 2 ", false, " LastName 2 ", "! 2 ! Password", 2, "Username 2 " },
                    { new Guid("07380cb6-6c13-419c-9e69-c603c8f6079e"), "TempEmail 3 @hotmail.com", " FirstName 3 ", false, " LastName 3 ", "! 3 ! Password", 3, "Username 3 " },
                    { new Guid("8a43ba80-19a5-4c17-938a-30905a327cae"), "TempEmail 4 @hotmail.com", " FirstName 4 ", false, " LastName 4 ", "! 4 ! Password", 4, "Username 4 " },
                    { new Guid("4126e767-de14-449a-9384-d43627203f3e"), "TempEmail 5 @hotmail.com", " FirstName 5 ", false, " LastName 5 ", "! 5 ! Password", 5, "Username 5 " },
                    { new Guid("667c8991-ba18-4c0f-be1f-95e0d9ffb468"), "TempEmail 6 @hotmail.com", " FirstName 6 ", false, " LastName 6 ", "! 6 ! Password", 6, "Username 6 " },
                    { new Guid("db61264f-5c8d-4fa6-b8d9-44fd803516e1"), "TempEmail 7 @hotmail.com", " FirstName 7 ", false, " LastName 7 ", "! 7 ! Password", 7, "Username 7 " },
                    { new Guid("0085a643-3561-4ca5-b8fe-c08ad52686f0"), "TempEmail 8 @hotmail.com", " FirstName 8 ", false, " LastName 8 ", "! 8 ! Password", 8, "Username 8 " },
                    { new Guid("74e03aec-e790-4826-b237-023ffc114201"), "TempEmail 9 @hotmail.com", " FirstName 9 ", false, " LastName 9 ", "! 9 ! Password", 9, "Username 9 " },
                    { new Guid("241398fe-62b3-47a2-a0d9-c85bba3665ec"), "TempEmail 10 @hotmail.com", " FirstName 10 ", false, " LastName 10 ", "! 10 ! Password", 10, "Username 10 " },
                    { new Guid("0979160c-95c3-401a-ac29-8c1c36a0cdb7"), "TempEmail 11 @hotmail.com", " FirstName 11 ", false, " LastName 11 ", "! 11 ! Password", 11, "Username 11 " },
                    { new Guid("d30dc3e2-601a-4761-8d9b-f7ef2e85af9a"), "TempEmail 49 @hotmail.com", " FirstName 49 ", false, " LastName 49 ", "! 49 ! Password", 49, "Username 49 " },
                    { new Guid("a2625a33-65b7-4d29-9a64-f5c6f6c2a4ae"), "TempEmail 12 @hotmail.com", " FirstName 12 ", false, " LastName 12 ", "! 12 ! Password", 12, "Username 12 " },
                    { new Guid("f79a2c4d-904b-4410-b6ce-5e5ea9a3e0c2"), "TempEmail 14 @hotmail.com", " FirstName 14 ", false, " LastName 14 ", "! 14 ! Password", 14, "Username 14 " },
                    { new Guid("d51d2b52-2598-4f1a-ad80-4f24141ea571"), "TempEmail 15 @hotmail.com", " FirstName 15 ", false, " LastName 15 ", "! 15 ! Password", 15, "Username 15 " },
                    { new Guid("b06563d4-3663-4108-9ac7-08af1c080bc0"), "TempEmail 16 @hotmail.com", " FirstName 16 ", false, " LastName 16 ", "! 16 ! Password", 16, "Username 16 " },
                    { new Guid("33bec53b-6b25-4335-af6f-9b031e959e33"), "TempEmail 17 @hotmail.com", " FirstName 17 ", false, " LastName 17 ", "! 17 ! Password", 17, "Username 17 " },
                    { new Guid("7d555476-18cd-42b4-908f-048830eaf412"), "TempEmail 18 @hotmail.com", " FirstName 18 ", false, " LastName 18 ", "! 18 ! Password", 18, "Username 18 " },
                    { new Guid("dc6548a9-b9f2-4add-93d3-68ae6d260bed"), "TempEmail 19 @hotmail.com", " FirstName 19 ", false, " LastName 19 ", "! 19 ! Password", 19, "Username 19 " },
                    { new Guid("64256e3b-ddc9-4cd0-9fa7-3701d8a770d9"), "TempEmail 20 @hotmail.com", " FirstName 20 ", false, " LastName 20 ", "! 20 ! Password", 20, "Username 20 " },
                    { new Guid("4fbe3f6f-f17f-467f-902e-8bc8bd4b2560"), "TempEmail 21 @hotmail.com", " FirstName 21 ", false, " LastName 21 ", "! 21 ! Password", 21, "Username 21 " },
                    { new Guid("e49988b1-be4e-4c0b-b641-4de06f515931"), "TempEmail 22 @hotmail.com", " FirstName 22 ", false, " LastName 22 ", "! 22 ! Password", 22, "Username 22 " },
                    { new Guid("f5ca4584-c666-4154-a5c4-485fc28c06fc"), "TempEmail 23 @hotmail.com", " FirstName 23 ", false, " LastName 23 ", "! 23 ! Password", 23, "Username 23 " },
                    { new Guid("b08ad8ed-11a2-40d6-9234-e46053019335"), "TempEmail 13 @hotmail.com", " FirstName 13 ", false, " LastName 13 ", "! 13 ! Password", 13, "Username 13 " },
                    { new Guid("8f5d8b3d-26b7-4536-b44a-32b0181f2b82"), "TempEmail 50 @hotmail.com", " FirstName 50 ", false, " LastName 50 ", "! 50 ! Password", 50, "Username 50 " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

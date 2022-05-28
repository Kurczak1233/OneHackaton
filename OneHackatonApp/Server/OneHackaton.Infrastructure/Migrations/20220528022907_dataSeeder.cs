using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneHackaton.Infrastructure.Migrations
{
    public partial class dataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Cavatina" },
                    { 8, "RockSoft" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Development team" },
                    { 3, "QA team" }
                });

            migrationBuilder.InsertData(
                table: "TimeLines",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 5, 28, 4, 29, 6, 831, DateTimeKind.Local).AddTicks(682) },
                    { 5, new DateTime(2022, 5, 28, 4, 29, 6, 831, DateTimeKind.Local).AddTicks(692) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "NickName" },
                values: new object[,]
                {
                    { 3, "User@User.com", "Userek" },
                    { 4, "Marcin@User.com", "Marcin" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 3, "MichalDev", 2 },
                    { 4, "JakubDev", 2 },
                    { 5, "MikoDev", 2 },
                    { 6, "MaksDev", 2 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 6, "HealthCare Application", 2 },
                    { 7, "Media Application", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserItems",
                columns: new[] { "Id", "Credentials", "Date", "Description", "Email", "Name", "TimeLineId", "UserId" },
                values: new object[,]
                {
                    { 3, "User", new DateTimeOffset(new DateTime(2022, 5, 28, 4, 29, 6, 831, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", "dev@rocksoft.com", "Raports", 4, 3 },
                    { 4, "User", new DateTimeOffset(new DateTime(2022, 5, 30, 4, 29, 6, 831, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", "dev@rocksoft.com", "Raports", 4, 3 },
                    { 5, "User", new DateTimeOffset(new DateTime(2022, 5, 31, 4, 29, 6, 831, DateTimeKind.Unspecified).AddTicks(772), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", "dev@rocksoft.com", "Raports", 4, 3 },
                    { 6, "User", new DateTimeOffset(new DateTime(2022, 6, 2, 4, 29, 6, 831, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", "dev@pitney.com", "Raports", 5, 4 },
                    { 7, "User", new DateTimeOffset(new DateTime(2022, 6, 3, 4, 29, 6, 831, DateTimeKind.Unspecified).AddTicks(777), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", "dev@pitney.com", "Raports", 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "DeveloperItems",
                columns: new[] { "Id", "Credentials", "Date", "Description", "DeveloperId", "Email", "Name", "TimeLineId" },
                values: new object[] { 3, "Dev", new DateTimeOffset(new DateTime(2022, 5, 28, 4, 29, 6, 830, DateTimeKind.Unspecified).AddTicks(8077), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", 4, "dev@rocksoft.com", "DevItem", 4 });

            migrationBuilder.InsertData(
                table: "DeveloperItems",
                columns: new[] { "Id", "Credentials", "Date", "Description", "DeveloperId", "Email", "Name", "TimeLineId" },
                values: new object[] { 4, "Dev", new DateTimeOffset(new DateTime(2022, 5, 30, 4, 29, 6, 830, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 2, 0, 0, 0)), "Whatever it takes", 5, "dev@rocksoft.com", "DevItem", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DeleteData(
                table: "DeveloperItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeveloperItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeLines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeLines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

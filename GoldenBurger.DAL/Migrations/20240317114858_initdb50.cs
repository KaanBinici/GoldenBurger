using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenBurger.DAL.Migrations
{
    public partial class initdb50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Baskets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "200b8aab-1845-4612-a6b8-cfec2c65db5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userRoleId",
                column: "ConcurrencyStamp",
                value: "40ec9151-7859-4f14-86e5-88ca640a4037");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adminUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87792249-6f22-4a57-b50d-7c892916d2ca", "AQAAAAEAACcQAAAAEEFKM4VHW+Mj0Pswv7r1FbURZA7UvJquC7hJDS0aVpx4s4cpVkM2c2nzep6dJlLhow==" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 526, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 515, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 519, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 510, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7083), 5.5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7100), 7.5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7102), 6.0 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7105), 6.0 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7107), 10.0 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7111), 12.0 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 507, DateTimeKind.Local).AddTicks(4252));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "ff1f3dbf-d6c3-4327-936a-ef6beb5bab0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userRoleId",
                column: "ConcurrencyStamp",
                value: "0cd29a3b-bc02-4609-8a21-e25f1c4ec581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adminUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b0e6dfa-2b81-4088-96aa-79641d5aea45", "AQAAAAEAACcQAAAAEIg6sUvWwIsK8aeEnqeaafLQaoZo/6cjwI8k7dGw59hYRoNRRowJh5IVyGC4vSzLiw==" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7340), 2.5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7365), 1.5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7368), 1.25 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7370), 1.25 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7372), 1.5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7376), 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(246));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenBurger.DAL.Migrations
{
    public partial class inidb100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "f9f94258-4ff8-4498-b07a-d3bf0de34108");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userRoleId",
                column: "ConcurrencyStamp",
                value: "5ac86957-f79d-4d95-9456-bd233f8a2a9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adminUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38ab9198-c387-49a9-9960-7ff9dbafe389", "AQAAAAEAACcQAAAAEHnRSm7wwu5jyAOeXP8kFnecog9FysHpDYwO5c732o4JVKNvMQH4lVy9kijBH/o8zA==" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 129, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 119, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 122, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 116, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 128, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 9, 5, 4, 113, DateTimeKind.Local).AddTicks(8535));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "cb1c3423-4d23-448e-96f6-923acf75032b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userRoleId",
                column: "ConcurrencyStamp",
                value: "613ab6f2-4df7-4efb-8ed0-8fbb0975850a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adminUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67fd970e-cb14-4961-956d-751b7d8c263a", "AQAAAAEAACcQAAAAEM1uW5k4zG/VtNSRS7pNBtkehTETrOtWu0CMwK7zOrn2iRA6lQ32VRzNsyFt+dupHQ==" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 731, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 734, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 740, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 0, 29, 4, 725, DateTimeKind.Local).AddTicks(294));
        }
    }
}

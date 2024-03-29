using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenBurger.DAL.Migrations
{
    public partial class initdb250 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "0b4f9fc4-f25d-42d1-be8d-10d711dc8f85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userRoleId",
                column: "ConcurrencyStamp",
                value: "93ccae6a-338f-46d9-95cf-9f19c06fce59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adminUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8752647a-4e32-4c30-bcaf-ecd68db61414", "AQAAAAEAACcQAAAAEDowS1OwhP8SSTHP/hyj1GyYUL8Bio/JdgjVEFM8uPpsQF3gmzL5eW/y7kgkhRjXqw==" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 99, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Chips",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 89, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 92, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 85, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 98, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 15, 11, 59, 82, DateTimeKind.Local).AddTicks(5955));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

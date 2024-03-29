using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenBurger.DAL.Migrations
{
    public partial class initdb55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Baskets",
                type: "bit",
                nullable: true);

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
                columns: new[] { "CreatedDate", "Visible" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 29, 4, 727, DateTimeKind.Local).AddTicks(2484), false });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Baskets");

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
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 17, 14, 48, 57, 525, DateTimeKind.Local).AddTicks(7111));

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
    }
}

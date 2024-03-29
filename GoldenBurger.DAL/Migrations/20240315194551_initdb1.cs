using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenBurger.DAL.Migrations
{
    public partial class initdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SepetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraProductName = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Extras_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menus_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Burgers_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Burgers_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chips",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChipsType = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chips", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chips_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chips_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Drinks_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drinks_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredients_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingredients_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burgers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adminRoleId", "ff1f3dbf-d6c3-4327-936a-ef6beb5bab0c", "admin", "ADMIN" },
                    { "userRoleId", "0cd29a3b-bc02-4609-8a21-e25f1c4ec581", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "adminUserId", 0, "1b0e6dfa-2b81-4088-96aa-79641d5aea45", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEIg6sUvWwIsK8aeEnqeaafLQaoZo/6cjwI8k7dGw59hYRoNRRowJh5IVyGC4vSzLiw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "SepetAdi", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5608), null, "ilkSepet", 0, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "adminRoleId", "adminUserId" });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "ID", "BasketId", "Count", "CreatedDate", "DeletedDate", "ExtraProductName", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5182), null, 3, "Çikolatalı Cookie", "MenusPictures\\cikolatali-cookie.png", 18.0, 0, null, true },
                    { 2, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5209), null, 3, "Sufle", "MenusPictures\\sufle.png", 22.0, 0, null, true },
                    { 3, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5212), null, 3, "Vişneli Tatlı", "MenusPictures\\visneli-tatli.png", 28.0, 0, null, true },
                    { 4, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5215), null, 3, "Elmalı Tatlı", "MenusPictures\\elmali-tatli.png", 25.0, 0, null, true },
                    { 5, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5217), null, 3, "Mini Sundea", "MenusPictures\\mini-sundae.png", 20.0, 0, null, true },
                    { 6, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5220), null, 6, "Mini Acı Sos", "MenusPictures\\mini-aci-sos.png", 8.0, 0, null, true },
                    { 7, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5263), null, 6, "Mini Ranch", "MenusPictures\\mini-ranch.png", 6.0, 0, null, true },
                    { 8, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5267), null, 6, "Mini Ketçap", "MenusPictures\\mini-ketcap.png", 5.0, 0, null, true },
                    { 9, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5269), null, 6, "Mini Mayonez", "MenusPictures\\mini-mayonez.png", 5.0, 0, null, true },
                    { 10, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5272), null, 6, "Mini Bbq", "MenusPictures\\mini-bbq.png", 6.0, 0, null, true },
                    { 11, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5274), null, 6, "Mini Ballı Hardal", "MenusPictures\\mini-balli-hardal-1.png", 9.0, 0, null, true },
                    { 12, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 471, DateTimeKind.Local).AddTicks(5277), null, 6, "Mini Buffalo", "MenusPictures\\mini-buffalo-1.png", 8.0, 0, null, true }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "BasketId", "Count", "CreatedDate", "DeletedDate", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(180), null, "Big King Jr. Menü", "MenusPictures\\big-king-jr-menu.png", 219.0, 0, null, true },
                    { 2, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(200), null, "SteakHouse Burger Menü", "MenusPictures\\bk-steakhouse-burger-menu.png", 229.0, 0, null, true },
                    { 3, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(203), null, "Cheese Burger Menü", "MenusPictures\\cheeseburger-menu.png", 200.0, 0, null, true },
                    { 4, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(205), null, "Double Big King Menü", "MenusPictures\\double-big-king-menu.png", 240.0, 0, null, true },
                    { 5, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(208), null, "Double Cheeseburger Menü", "MenusPictures\\double-cheeseburger-menu.png", 235.0, 0, null, true },
                    { 6, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(212), null, "Double King Chicken Menü", "MenusPictures\\double-king-chicken-menu.png", 199.0, 0, null, true },
                    { 7, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(214), null, "Double Köfte Burger Menü", "MenusPictures\\double-kofteburger-menu.png", 235.0, 0, null, true },
                    { 8, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(216), null, "Double Whopper Jr. Menü", "MenusPictures\\double-whopper-jr-menu.png", 249.0, 0, null, true },
                    { 9, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(218), null, "Double Whopper Menü", "MenusPictures\\double-whopper-menu.png", 219.0, 0, null, true },
                    { 10, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(221), null, "Etli Barbekü Deluxe Burger Menü", "MenusPictures\\etli-barbeku-deluxe-burger-menu.png", 269.0, 0, null, true },
                    { 11, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(223), null, "King Beef Burger Menü", "MenusPictures\\king-beef-burger-menu.png", 280.0, 0, null, true },
                    { 12, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(225), null, "King Chicken Menü", "MenusPictures\\king-chicken-menu.png", 209.0, 0, null, true },
                    { 13, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(227), null, "Köfte Burger Menü", "MenusPictures\\kofteburger-menu.png", 216.0, 0, null, true },
                    { 14, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(229), null, "Mega Double Cheeseburger Menü", "MenusPictures\\mega-double-cheeseburger-menu.png", 230.0, 0, null, true },
                    { 15, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(231), null, "Plant Based Whopper Menü", "MenusPictures\\plant-based-whopper-menu.png", 250.0, 0, null, true },
                    { 16, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(234), null, "Rodeo Whopper Menü", "MenusPictures\\rodeo-whopper-menu.png", 269.0, 0, null, true },
                    { 17, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(236), null, "Tavuklu Barbekü Brioche Menü", "MenusPictures\\tavuklu-barbeku-brioche-menu.png", 215.0, 0, null, true },
                    { 18, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(239), null, "Texas SmokeHouse Burger Menü", "MenusPictures\\texas-smokehouse-burger-menu.png", 255.0, 0, null, true },
                    { 19, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(241), null, "Triple Whopper Menü", "MenusPictures\\triple-whopper-menu.png", 299.0, 0, null, true },
                    { 20, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(243), null, "Trüflü King Beef Burger Menü", "MenusPictures\\truflu-king-beef-burger-menu.png", 310.0, 0, null, true },
                    { 21, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(245), null, "Whopper Jr. Menü", "MenusPictures\\whopper-jr-menu.png", 268.0, 0, null, true },
                    { 22, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 469, DateTimeKind.Local).AddTicks(246), null, "Whopper Menü", "MenusPictures\\whopper-menu.png", 236.0, 0, null, true }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "ID", "BasketId", "Count", "CreatedDate", "DeletedDate", "MenuId", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(887), null, 1, "Big King Jr.", "MenusPictures\\big-king-jr-menu.png", 189.0, 0, null, true },
                    { 2, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(941), null, 2, "SteakHouse Burger", "MenusPictures\\bk-steakhouse-burger-menu.png", 169.0, 0, null, true },
                    { 3, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(944), null, 3, "Cheese Burger", "MenusPictures\\cheeseburger-menu.png", 145.0, 0, null, true },
                    { 4, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(947), null, 4, "Double Big King", "MenusPictures\\double-big-king-menu.png", 120.0, 0, null, true },
                    { 5, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(949), null, 5, "Double Cheeseburger", "MenusPictures\\double-cheeseburger-menu.png", 109.0, 0, null, true },
                    { 6, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(953), null, 6, "Double King Chicken", "MenusPictures\\double-king-chicken-menu.png", 119.0, 0, null, true },
                    { 7, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(956), null, 7, "Double Köfte Burger", "MenusPictures\\double-kofteburger-menu.png", 129.0, 0, null, true },
                    { 8, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(958), null, 8, "Double Whopper Jr.", "MenusPictures\\double-whopper-jr-menu.png", 135.0, 0, null, true },
                    { 9, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(961), null, 9, "Double Whopper", "MenusPictures\\double-whopper-menu.png", 155.0, 0, null, true },
                    { 10, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(964), null, 10, "Etli Barbekü Deluxe Burger", "MenusPictures\\etli-barbeku-deluxe-burger-menu.png", 169.0, 0, null, true },
                    { 11, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(967), null, 11, "King Beef Burger", "MenusPictures\\king-beef-burger-menu.png", 159.0, 0, null, true },
                    { 12, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(969), null, 12, "King Chicken", "MenusPictures\\king-chicken-menu.png", 99.0, 0, null, true },
                    { 13, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(971), null, 13, "Köfte Burger", "MenusPictures\\kofteburger-menu.png", 119.0, 0, null, true },
                    { 14, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(974), null, 14, "Mega Double Cheeseburger", "MenusPictures\\mega-double-cheeseburger-menu.png", 149.0, 0, null, true },
                    { 15, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(976), null, 15, "Plant Based Whopper", "MenusPictures\\plant-based-whopper-menu.png", 129.0, 0, null, true },
                    { 16, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(978), null, 16, "Rodeo Whopper", "MenusPictures\\rodeo-whopper-menu.png", 134.0, 0, null, true },
                    { 17, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(980), null, 17, "Tavuklu Barbekü Brioche", "MenusPictures\\tavuklu-barbeku-brioche-menu.png", 115.0, 0, null, true },
                    { 18, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(984), null, 18, "Texas SmokeHouse Burger", "MenusPictures\\texas-smokehouse-burger-menu.png", 150.0, 0, null, true },
                    { 19, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(986), null, 19, "Triple Whopper", "MenusPictures\\triple-whopper-menu.png", 145.0, 0, null, true },
                    { 20, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(988), null, 20, "Trüflü King Beef Burger", "MenusPictures\\truflu-king-beef-burger-menu.png", 135.0, 0, null, true },
                    { 21, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(991), null, 21, "Whopper Jr.", "MenusPictures\\whopper-jr-menu.png", 99.0, 0, null, true },
                    { 22, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 484, DateTimeKind.Local).AddTicks(993), null, 22, "Whopper", "MenusPictures\\whopper-menu.png", 100.0, 0, null, true }
                });

            migrationBuilder.InsertData(
                table: "Chips",
                columns: new[] { "ID", "BasketId", "ChipsType", "Count", "CreatedDate", "DeletedDate", "MenuId", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(140), null, 1, "Patates", "MenusPictures\\tirtikli-patates.png", 34.0, 0, null, true },
                    { 2, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(159), null, 2, "Patates", "MenusPictures\\patates.png", 32.0, 0, null, true },
                    { 3, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(162), null, 3, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 4, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(165), null, 4, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 5, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(167), null, 5, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 6, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(172), null, 6, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 7, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(174), null, 7, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 8, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(176), null, 8, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 9, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(178), null, 9, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 10, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(181), null, 10, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 11, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(183), null, 11, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 12, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(185), null, 12, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 13, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(188), null, 13, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 14, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(190), null, 14, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 15, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(192), null, 15, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 16, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(194), null, 16, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 17, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(196), null, 17, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 18, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(199), null, 18, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 19, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(201), null, 19, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 20, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(204), null, 20, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Chips",
                columns: new[] { "ID", "BasketId", "ChipsType", "Count", "CreatedDate", "DeletedDate", "MenuId", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 21, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(206), null, 21, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false },
                    { 22, 1, 0, 0, new DateTime(2024, 3, 15, 22, 45, 51, 475, DateTimeKind.Local).AddTicks(208), null, 22, "Patates", "MenusPictures\\patates.png", 25.0, 0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "BasketId", "Count", "CreatedDate", "DeletedDate", "MenuId", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(675), null, 1, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, true },
                    { 2, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(693), null, 2, "Coca Cola Light", "MenusPictures\\coca-cola-light.png", 23.0, 0, null, true },
                    { 3, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(696), null, 3, "Coca Cola Zero Sugar", "MenusPictures\\coca-cola-zero-sugar.png", 23.0, 0, null, true },
                    { 4, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(698), null, 4, "Fuse Tea", "MenusPictures\\fuse-tea.png", 20.0, 0, null, true },
                    { 5, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(700), null, 5, "Fanta", "MenusPictures\\fanta.png", 22.0, 0, null, true },
                    { 6, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(704), null, 6, "Sprite", "MenusPictures\\sprite.png", 24.0, 0, null, true },
                    { 7, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(707), null, 7, "Ayran 300 ml", "MenusPictures\\ayran-300-ml.png", 30.0, 0, null, true },
                    { 8, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(709), null, 8, "Ayran 195 ml", "MenusPictures\\ayran-195-ml.png", 20.0, 0, null, true },
                    { 9, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(711), null, 9, "Elma Suyu", "MenusPictures\\elma-suyu.png", 16.0, 0, null, true },
                    { 10, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(714), null, 10, "Cappy Atom", "MenusPictures\\cappy-atom-200-ml.png", 18.0, 0, null, true },
                    { 11, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(716), null, 11, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 12, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(718), null, 12, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 13, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(721), null, 13, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 14, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(723), null, 14, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 15, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(765), null, 15, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 16, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(769), null, 16, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 17, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(771), null, 17, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 18, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(774), null, 18, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 19, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(776), null, 19, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 20, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(778), null, 20, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 21, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(780), null, 21, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false },
                    { 22, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 478, DateTimeKind.Local).AddTicks(782), null, 22, "Coca Cola", "MenusPictures\\coca-cola.png", 25.0, 0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "BasketId", "BurgerId", "Count", "CreatedDate", "DeletedDate", "Name", "PhotoPath", "Price", "Status", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 1, 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7340), null, "Turşu", null, 2.5, 0, null, true },
                    { 2, 1, 2, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7365), null, "Domates", null, 1.5, 0, null, true },
                    { 3, 1, 3, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7368), null, "Ketçap", null, 1.25, 0, null, true },
                    { 4, 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7370), null, "Mayonez", null, 1.25, 0, null, true },
                    { 5, 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7372), null, "Hardal", null, 1.5, 0, null, true },
                    { 6, 1, 1, 0, new DateTime(2024, 3, 15, 22, 45, 51, 483, DateTimeKind.Local).AddTicks(7376), null, "Marul", null, 2.2000000000000002, 0, null, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Burgers_BasketId",
                table: "Burgers",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Burgers_MenuId",
                table: "Burgers",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Chips_BasketId",
                table: "Chips",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Chips_MenuId",
                table: "Chips",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_BasketId",
                table: "Drinks",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MenuId",
                table: "Drinks",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_BasketId",
                table: "Extras",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_BasketId",
                table: "Ingredients",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_BurgerId",
                table: "Ingredients",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_BasketId",
                table: "Menus",
                column: "BasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Chips");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Baskets");
        }
    }
}

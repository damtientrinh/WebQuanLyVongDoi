using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQuanLyTaiSan.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3086), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3091), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3102), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3104), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3107), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3110), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3113), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3541), new TimeSpan(0, 7, 0, 0, 0)), "SN-703E0F69" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3547), new TimeSpan(0, 7, 0, 0, 0)), "SN-863F97B6" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 7, 0, 0, 0)), "SN-8E6E491A" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 7, 0, 0, 0)), "SN-2BE3723B" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 7, 0, 0, 0)), "SN-12A2B4B5" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 7, 0, 0, 0)), "SN-1053F970" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 7, 0, 0, 0)), "SN-4855BF4F" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 7, 0, 0, 0)), "SN-AFF9BB4E" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 7, 0, 0, 0)), "SN-D7628F9D" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), "SN-55950A14" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 7, 0, 0, 0)), "SN-ADA3A3CE" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 7, 0, 0, 0)), "SN-5AE453F9" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 7, 0, 0, 0)), "SN-180D197C" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 7, 0, 0, 0)), "SN-211EBD86" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 7, 0, 0, 0)), "SN-9B3E867A" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 7, 0, 0, 0)), "SN-43FCB1E5" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 7, 0, 0, 0)), "SN-60ACF3CD" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 7, 0, 0, 0)), "SN-2E83835C" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 7, 0, 0, 0)), "SN-F447C8B2" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 7, 0, 0, 0)), "SN-0E9D8D03" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3246), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 30, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3253), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 20, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 10, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 28, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 18, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3271), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 8, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3275), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 19, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 9, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3296), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 30, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 20, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3304), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 10, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 30, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3313), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 20, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3318), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 10, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 31, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3326), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 21, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 11, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3335), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 1, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 9, 21, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2834), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2846), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2855), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2896), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 8, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 7, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3798), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 6, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 5, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3804), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 4, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 3, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 2, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 4, 1, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 31, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 30, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3825), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 29, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3827), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 28, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 27, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 26, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 25, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3839), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 24, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 23, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 22, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3849), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 21, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 9, 12, 15, 41, 312, DateTimeKind.Unspecified).AddTicks(3852), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 20, 12, 15, 41, 312, DateTimeKind.Local).AddTicks(3850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9002), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9005), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9008), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9021), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9026), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9044), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9072), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 7, 0, 0, 0)), "SN-878F36BE" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 7, 0, 0, 0)), "SN-3AD3254B" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(216), new TimeSpan(0, 7, 0, 0, 0)), "SN-AEA2F8DB" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 7, 0, 0, 0)), "SN-0A819956" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 7, 0, 0, 0)), "SN-9CF86FE0" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 7, 0, 0, 0)), "SN-D576322D" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(326), new TimeSpan(0, 7, 0, 0, 0)), "SN-CB5D58F3" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 7, 0, 0, 0)), "SN-C966B277" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(338), new TimeSpan(0, 7, 0, 0, 0)), "SN-822CD38D" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(351), new TimeSpan(0, 7, 0, 0, 0)), "SN-FEEB0575" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 7, 0, 0, 0)), "SN-7FEE89CE" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), "SN-961E54B6" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 7, 0, 0, 0)), "SN-79CD9D0A" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(412), new TimeSpan(0, 7, 0, 0, 0)), "SN-9BEE5B80" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(422), new TimeSpan(0, 7, 0, 0, 0)), "SN-2F490BE0" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 7, 0, 0, 0)), "SN-F77D9F9E" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(439), new TimeSpan(0, 7, 0, 0, 0)), "SN-0BDEBC4E" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(450), new TimeSpan(0, 7, 0, 0, 0)), "SN-AA68E10C" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 7, 0, 0, 0)), "SN-6710CDCD" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 7, 0, 0, 0)), "SN-B79B5D3B" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 22, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 12, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 2, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 20, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 10, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 31, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9291), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 21, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 11, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9314), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 1, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9323), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 22, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9329), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 12, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9335), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 2, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9341), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 22, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9346), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 12, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 2, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9360), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 23, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 13, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9384), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 3, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 9, 23, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9402), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 9, 13, 16, 6, 13, 807, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8075), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8090), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8102), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8105), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8126), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8136), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(575), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 31, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 30, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 29, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(601), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 28, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 27, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 26, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 25, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1203), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 24, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 23, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 22, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1217), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 21, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 20, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 19, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1229), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 18, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1233), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 17, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 16, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 15, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1247), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 14, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1252), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 13, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 808, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 12, 16, 6, 13, 808, DateTimeKind.Local).AddTicks(1254) });
        }
    }
}

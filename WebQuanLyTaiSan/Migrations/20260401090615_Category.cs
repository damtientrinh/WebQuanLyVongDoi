using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQuanLyTaiSan.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9002), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9005), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9008), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9021), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9026), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9044), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryType", "CreatedAt" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2026, 4, 1, 16, 6, 13, 807, DateTimeKind.Unspecified).AddTicks(9072), new TimeSpan(0, 7, 0, 0, 0)) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(128), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(132), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(172), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(179), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(195), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 7, 0, 0, 0)), "SN-5FB53F7E" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 7, 0, 0, 0)), "SN-6031CF50" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 7, 0, 0, 0)), "SN-939E9E19" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(624), new TimeSpan(0, 7, 0, 0, 0)), "SN-99AEC86A" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 7, 0, 0, 0)), "SN-32361A6F" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 7, 0, 0, 0)), "SN-C9AB4CC1" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 7, 0, 0, 0)), "SN-391D0AF4" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 7, 0, 0, 0)), "SN-7662EC6B" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 7, 0, 0, 0)), "SN-BFE7A507" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(666), new TimeSpan(0, 7, 0, 0, 0)), "SN-4EA2168A" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 7, 0, 0, 0)), "SN-5DC54975" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 7, 0, 0, 0)), "SN-68F0AF2F" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 7, 0, 0, 0)), "SN-803AF167" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 7, 0, 0, 0)), "SN-C1D206E0" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 7, 0, 0, 0)), "SN-23C3FBC9" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 7, 0, 0, 0)), "SN-AB072D8C" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 7, 0, 0, 0)), "SN-6FD1D701" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 7, 0, 0, 0)), "SN-B02DCBD6" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 7, 0, 0, 0)), "SN-6CC79410" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "SerialNumber" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 7, 0, 0, 0)), "SN-2DAB79F4" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(302), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 20, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(311), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 2, 10, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 21, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 11, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(346), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 1, 1, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(353), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(358), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 12, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(371), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 11, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(412), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 10, 3, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(416), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 9, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PurchaseDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2025, 9, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9758), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9812), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9858), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9880), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9899), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9905), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 31, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(844), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 30, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 29, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 28, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 27, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 26, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 25, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 24, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(875), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 21, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(878), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 20, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 19, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 18, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(888), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 17, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(891), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 16, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 15, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 14, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "MaintenanceLogs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "RepairDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2026, 3, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(965) });
        }
    }
}

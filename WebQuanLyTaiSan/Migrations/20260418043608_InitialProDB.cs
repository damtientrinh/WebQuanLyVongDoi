using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebQuanLyTaiSan.Migrations
{
    /// <inheritdoc />
    public partial class InitialProDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Group = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeptCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ManagerName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    EmployeeCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PurchasePrice = table.Column<double>(type: "REAL", nullable: false),
                    WarrantyMonths = table.Column<int>(type: "INTEGER", nullable: false),
                    Supplier = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Packaging = table.Column<int>(type: "INTEGER", nullable: false),
                    Accessories = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Specifications = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WarrantyMonths = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Components_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RepairDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Cost = table.Column<double>(type: "REAL", nullable: false),
                    ServiceProvider = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceLogs_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Group", "Icon", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 1", 0, null, false, "Máy tính để bàn", null, null },
                    { 2, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6233), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 2", 0, null, false, "Linh kiện rời", null, null },
                    { 3, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6238), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 3", 0, null, false, "Thiết bị mạng", null, null },
                    { 4, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 4", 0, null, false, "Laptop", null, null },
                    { 5, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 5", 0, null, false, "Máy in", null, null },
                    { 6, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6261), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 6", 0, null, false, "Máy chiếu", null, null },
                    { 7, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6266), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 7", 0, null, false, "Server", null, null },
                    { 8, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6272), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 8", 0, null, false, "Thiết bị lưu trữ", null, null },
                    { 9, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 9", 0, null, false, "Thiết bị loại 9", null, null },
                    { 10, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 10", 0, null, false, "Thiết bị loại 10", null, null },
                    { 11, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6295), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 11", 0, null, false, "Thiết bị loại 11", null, null },
                    { 12, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 12", 0, null, false, "Thiết bị loại 12", null, null },
                    { 13, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 13", 0, null, false, "Thiết bị loại 13", null, null },
                    { 14, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6316), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 14", 0, null, false, "Thiết bị loại 14", null, null },
                    { 15, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6322), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 15", 0, null, false, "Thiết bị loại 15", null, null },
                    { 16, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 16", 0, null, false, "Thiết bị loại 16", null, null },
                    { 17, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 17", 0, null, false, "Thiết bị loại 17", null, null },
                    { 18, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6342), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 18", 0, null, false, "Thiết bị loại 18", null, null },
                    { 19, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 19", 0, null, false, "Thiết bị loại 19", null, null },
                    { 20, "", new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 20", 0, null, false, "Thiết bị loại 20", null, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeptCode", "IsDeleted", "Location", "ManagerName", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "CNTT", false, "Tầng 2 - Nhà B", null, "Khoa CNTT", null, null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DT", false, "Tầng 3 - Nhà C", null, "Phòng Đào tạo", null, null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "HC", false, "Tầng 4 - Nhà D", null, "Phòng Hành chính", null, null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5232), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "KH", false, "Tầng 5 - Nhà A", null, "Phòng Kế hoạch", null, null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TTTN", false, "Tầng 1 - Nhà B", null, "Trung tâm Thí nghiệm", null, null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DIEN", false, "Tầng 2 - Nhà C", null, "Khoa Điện", null, null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "CK", false, "Tầng 3 - Nhà D", null, "Khoa Cơ khí", null, null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TVU", false, "Tầng 4 - Nhà A", null, "Phòng Tài vụ", null, null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TV", false, "Tầng 5 - Nhà B", null, "Thư viện", null, null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "BV", false, "Tầng 1 - Nhà C", null, "Phòng Bảo vệ", null, null },
                    { 11, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT11", false, "Tầng 2 - Nhà D", null, "Phòng chức năng 11", null, null },
                    { 12, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT12", false, "Tầng 3 - Nhà A", null, "Phòng chức năng 12", null, null },
                    { 13, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5376), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT13", false, "Tầng 4 - Nhà B", null, "Phòng chức năng 13", null, null },
                    { 14, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5384), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT14", false, "Tầng 5 - Nhà C", null, "Phòng chức năng 14", null, null },
                    { 15, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5443), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT15", false, "Tầng 1 - Nhà D", null, "Phòng chức năng 15", null, null },
                    { 16, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT16", false, "Tầng 2 - Nhà A", null, "Phòng chức năng 16", null, null },
                    { 17, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT17", false, "Tầng 3 - Nhà B", null, "Phòng chức năng 17", null, null },
                    { 18, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5521), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT18", false, "Tầng 4 - Nhà C", null, "Phòng chức năng 18", null, null },
                    { 19, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5529), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT19", false, "Tầng 5 - Nhà D", null, "Phòng chức năng 19", null, null },
                    { 20, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DEPT20", false, "Tầng 1 - Nhà A", null, "Phòng chức năng 20", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "FullName", "IsActive", "IsDeleted", "Password", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(3485), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "admin@epu.edu.vn", "Administrator", true, false, "$2a$11$xMbJTLJoH82XWAXkuaFk3.aaW9IGvUyrNXgxmp9S0Lnc5KAbTsEV.", "Admin", null, null });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "Price", "PurchaseDate", "SerialNumber", "Specifications", "Status", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 3, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 800000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7041), "SN-D30F036F", null, "Trong kho", null, null, 0 },
                    { 6, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 1100000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7063), "SN-5DD7D60E", null, "Trong kho", null, null, 0 },
                    { 9, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7117), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 1400000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7108), "SN-74901126", null, "Trong kho", null, null, 0 },
                    { 12, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 1700000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7154), "SN-BB779E5F", null, "Trong kho", null, null, 0 },
                    { 15, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 2000000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7176), "SN-DC37ED2B", null, "Trong kho", null, null, 0 },
                    { 18, 2, null, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 2300000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7206), "SN-27A03514", null, "Trong kho", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DepartmentId", "Email", "EmployeeCode", "FullName", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, "nv1@epu.edu.vn", "NV001", "Nhân viên 1", false, null, null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, "nv2@epu.edu.vn", "NV002", "Nhân viên 2", false, null, null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6007), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, "nv3@epu.edu.vn", "NV003", "Nhân viên 3", false, null, null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, "nv4@epu.edu.vn", "NV004", "Nhân viên 4", false, null, null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 6, "nv5@epu.edu.vn", "NV005", "Nhân viên 5", false, null, null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 7, "nv6@epu.edu.vn", "NV006", "Nhân viên 6", false, null, null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 8, "nv7@epu.edu.vn", "NV007", "Nhân viên 7", false, null, null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 9, "nv8@epu.edu.vn", "NV008", "Nhân viên 8", false, null, null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 10, "nv9@epu.edu.vn", "NV009", "Nhân viên 9", false, null, null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 1, "nv10@epu.edu.vn", "NV010", "Nhân viên 10", false, null, null },
                    { 11, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6073), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, "nv11@epu.edu.vn", "NV011", "Nhân viên 11", false, null, null },
                    { 12, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6082), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, "nv12@epu.edu.vn", "NV012", "Nhân viên 12", false, null, null },
                    { 13, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, "nv13@epu.edu.vn", "NV013", "Nhân viên 13", false, null, null },
                    { 14, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6098), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, "nv14@epu.edu.vn", "NV014", "Nhân viên 14", false, null, null },
                    { 15, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 6, "nv15@epu.edu.vn", "NV015", "Nhân viên 15", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Accessories", "AssetCode", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DepartmentId", "EmployeeId", "IsDeleted", "Name", "Packaging", "PurchaseDate", "PurchasePrice", "Status", "Supplier", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 1, null, "EPU-PC-001", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, 2, false, "HP ProDesk Gen 1", 0, new DateTime(2026, 4, 8, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6563), 10500000.0, "Bảo trì", null, null, null, 24 },
                    { 2, null, "EPU-PC-002", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, 3, false, "Lenovo ThinkCentre Gen 2", 0, new DateTime(2026, 3, 29, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6586), 11000000.0, "Trong kho", null, null, null, 24 },
                    { 3, null, "EPU-PC-003", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, 4, false, "MacBook Air Gen 3", 0, new DateTime(2026, 3, 19, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6594), 11500000.0, "Hỏng", null, null, null, 24 },
                    { 4, null, "EPU-PC-004", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6603), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, 5, false, "Asus ExpertCenter Gen 4", 0, new DateTime(2026, 3, 9, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6602), 12000000.0, "Đang dùng", null, null, null, 24 },
                    { 5, null, "EPU-PC-005", 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 6, 6, false, "Dell Optiplex Gen 5", 0, new DateTime(2026, 2, 27, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6609), 12500000.0, "Bảo trì", null, null, null, 24 },
                    { 6, null, "EPU-PC-006", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6618), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 7, 7, false, "HP ProDesk Gen 6", 0, new DateTime(2026, 2, 17, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6617), 13000000.0, "Trong kho", null, null, null, 24 },
                    { 7, null, "EPU-PC-007", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6627), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 8, 8, false, "Lenovo ThinkCentre Gen 7", 0, new DateTime(2026, 2, 7, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6626), 13500000.0, "Hỏng", null, null, null, 24 },
                    { 8, null, "EPU-PC-008", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 9, 9, false, "MacBook Air Gen 8", 0, new DateTime(2026, 1, 28, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6635), 14000000.0, "Đang dùng", null, null, null, 24 },
                    { 9, null, "EPU-PC-009", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 10, 10, false, "Asus ExpertCenter Gen 9", 0, new DateTime(2026, 1, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6644), 14500000.0, "Bảo trì", null, null, null, 24 },
                    { 10, null, "EPU-PC-010", 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 11, 11, false, "Dell Optiplex Gen 10", 0, new DateTime(2026, 1, 8, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6653), 15000000.0, "Trong kho", null, null, null, 24 },
                    { 11, null, "EPU-PC-011", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 12, 12, false, "HP ProDesk Gen 11", 0, new DateTime(2025, 12, 29, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6661), 15500000.0, "Hỏng", null, null, null, 24 },
                    { 12, null, "EPU-PC-012", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 13, 13, false, "Lenovo ThinkCentre Gen 12", 0, new DateTime(2025, 12, 19, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6670), 16000000.0, "Đang dùng", null, null, null, 24 },
                    { 13, null, "EPU-PC-013", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 14, 14, false, "MacBook Air Gen 13", 0, new DateTime(2025, 12, 9, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6678), 16500000.0, "Bảo trì", null, null, null, 24 },
                    { 14, null, "EPU-PC-014", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 15, 15, false, "Asus ExpertCenter Gen 14", 0, new DateTime(2025, 11, 29, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6697), 17000000.0, "Trong kho", null, null, null, 24 },
                    { 15, null, "EPU-PC-015", 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 16, 1, false, "Dell Optiplex Gen 15", 0, new DateTime(2025, 11, 19, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6721), 17500000.0, "Hỏng", null, null, null, 24 },
                    { 16, null, "EPU-PC-016", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 17, 2, false, "HP ProDesk Gen 16", 0, new DateTime(2025, 11, 9, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6746), 18000000.0, "Đang dùng", null, null, null, 24 },
                    { 17, null, "EPU-PC-017", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 18, 3, false, "Lenovo ThinkCentre Gen 17", 0, new DateTime(2025, 10, 30, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6755), 18500000.0, "Bảo trì", null, null, null, 24 },
                    { 18, null, "EPU-PC-018", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 19, 4, false, "MacBook Air Gen 18", 0, new DateTime(2025, 10, 20, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6765), 19000000.0, "Trong kho", null, null, null, 24 },
                    { 19, null, "EPU-PC-019", 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6775), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 20, 5, false, "Asus ExpertCenter Gen 19", 0, new DateTime(2025, 10, 10, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6774), 19500000.0, "Hỏng", null, null, null, 24 },
                    { 20, null, "EPU-PC-020", 4, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 1, 6, false, "Dell Optiplex Gen 20", 0, new DateTime(2025, 9, 30, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6783), 20000000.0, "Đang dùng", null, null, null, 24 }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "Price", "PurchaseDate", "SerialNumber", "Specifications", "Status", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7031), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 600000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(6851), "SN-C65969F0", null, "Đang sử dụng", null, null, 0 },
                    { 2, 2, 3, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7040), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 700000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7034), "SN-6BA34F51", null, "Đang sử dụng", null, null, 0 },
                    { 4, 2, 5, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 900000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7048), "SN-B6FADB4C", null, "Đang sử dụng", null, null, 0 },
                    { 5, 2, 6, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 1000000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7055), "SN-7B308E3B", null, "Đang sử dụng", null, null, 0 },
                    { 7, 2, 8, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7083), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 1200000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7077), "SN-42CC93E6", null, "Đang sử dụng", null, null, 0 },
                    { 8, 2, 9, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 1300000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7085), "SN-1216987A", null, "Đang sử dụng", null, null, 0 },
                    { 10, 2, 11, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 1500000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7119), "SN-6A25268C", null, "Đang sử dụng", null, null, 0 },
                    { 11, 2, 12, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 1600000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7142), "SN-7692865D", null, "Đang sử dụng", null, null, 0 },
                    { 13, 2, 14, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 1800000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7162), "SN-1758DEB5", null, "Đang sử dụng", null, null, 0 },
                    { 14, 2, 15, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 1900000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7169), "SN-291BE856", null, "Đang sử dụng", null, null, 0 },
                    { 16, 2, 17, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 2100000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7189), "SN-B9145DD2", null, "Đang sử dụng", null, null, 0 },
                    { 17, 2, 18, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 2200000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7196), "SN-3DAAE00B", null, "Đang sử dụng", null, null, 0 },
                    { 19, 2, 20, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7218), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 2400000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7213), "SN-1DFE57FA", null, "Đang sử dụng", null, null, 0 },
                    { 20, 2, 1, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7225), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 2500000.0, new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7220), "SN-8E009254", null, "Đang sử dụng", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceLogs",
                columns: new[] { "Id", "ComputerId", "Cost", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "ImageUrl", "IsDeleted", "RepairDate", "ServiceProvider", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 2, 150000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 1", null, false, new DateTime(2026, 4, 17, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7279), null, "Hoàn thành", null, null },
                    { 2, 3, 200000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7297), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 2", null, false, new DateTime(2026, 4, 16, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7294), null, "Hoàn thành", null, null },
                    { 3, 4, 250000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 3", null, false, new DateTime(2026, 4, 15, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7300), null, "Hoàn thành", null, null },
                    { 4, 5, 300000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7308), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 4", null, false, new DateTime(2026, 4, 14, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7306), null, "Hoàn thành", null, null },
                    { 5, 6, 350000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7315), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 5", null, false, new DateTime(2026, 4, 13, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7311), null, "Hoàn thành", null, null },
                    { 6, 7, 400000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 6", null, false, new DateTime(2026, 4, 12, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7318), null, "Hoàn thành", null, null },
                    { 7, 8, 450000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7326), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 7", null, false, new DateTime(2026, 4, 11, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7324), null, "Hoàn thành", null, null },
                    { 8, 9, 500000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 8", null, false, new DateTime(2026, 4, 10, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7329), null, "Hoàn thành", null, null },
                    { 9, 10, 550000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 9", null, false, new DateTime(2026, 4, 9, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7335), null, "Hoàn thành", null, null },
                    { 10, 11, 600000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7368), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 10", null, false, new DateTime(2026, 4, 8, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7341), null, "Hoàn thành", null, null },
                    { 11, 12, 650000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 11", null, false, new DateTime(2026, 4, 7, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7371), null, "Hoàn thành", null, null },
                    { 12, 13, 700000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 12", null, false, new DateTime(2026, 4, 6, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7378), null, "Hoàn thành", null, null },
                    { 13, 14, 750000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7386), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 13", null, false, new DateTime(2026, 4, 5, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7384), null, "Hoàn thành", null, null },
                    { 14, 15, 800000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7391), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 14", null, false, new DateTime(2026, 4, 4, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7389), null, "Hoàn thành", null, null },
                    { 15, 16, 850000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 15", null, false, new DateTime(2026, 4, 3, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7394), null, "Hoàn thành", null, null },
                    { 16, 17, 900000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 16", null, false, new DateTime(2026, 4, 2, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7400), null, "Hoàn thành", null, null },
                    { 17, 18, 950000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 17", null, false, new DateTime(2026, 4, 1, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7405), null, "Hoàn thành", null, null },
                    { 18, 19, 1000000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 18", null, false, new DateTime(2026, 3, 31, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7411), null, "Hoàn thành", null, null },
                    { 19, 20, 1050000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 19", null, false, new DateTime(2026, 3, 30, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7417), null, "Hoàn thành", null, null },
                    { 20, 1, 1100000.0, new DateTimeOffset(new DateTime(2026, 4, 18, 11, 36, 4, 314, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 20", null, false, new DateTime(2026, 3, 29, 11, 36, 4, 314, DateTimeKind.Local).AddTicks(7422), null, "Hoàn thành", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_CategoryId",
                table: "Components",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComputerId",
                table: "Components",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_CategoryId",
                table: "Computers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_DepartmentId",
                table: "Computers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_EmployeeId",
                table: "Computers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceLogs_ComputerId",
                table: "MaintenanceLogs",
                column: "ComputerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "MaintenanceLogs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

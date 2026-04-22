using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebQuanLyTaiSan.Migrations
{
    /// <inheritdoc />
    public partial class InitialProSystem : Migration
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
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    EmployeeCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
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
                    { 1, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 1", 0, null, false, "Máy tính để bàn", null, null },
                    { 2, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 2", 0, null, false, "Linh kiện rời", null, null },
                    { 3, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 3", 0, null, false, "Thiết bị mạng", null, null },
                    { 4, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 4", 0, null, false, "Laptop", null, null },
                    { 5, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6929), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 5", 0, null, false, "Máy in", null, null },
                    { 6, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 6", 0, null, false, "Máy chiếu", null, null },
                    { 7, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 7", 0, null, false, "Server", null, null },
                    { 8, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 8", 0, null, false, "Thiết bị lưu trữ", null, null },
                    { 9, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 9", 0, null, false, "Thiết bị loại 9", null, null },
                    { 10, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7016), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 10", 0, null, false, "Thiết bị loại 10", null, null },
                    { 11, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 11", 0, null, false, "Thiết bị loại 11", null, null },
                    { 12, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 12", 0, null, false, "Thiết bị loại 12", null, null },
                    { 13, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7040), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 13", 0, null, false, "Thiết bị loại 13", null, null },
                    { 14, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 14", 0, null, false, "Thiết bị loại 14", null, null },
                    { 15, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 15", 0, null, false, "Thiết bị loại 15", null, null },
                    { 16, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 16", 0, null, false, "Thiết bị loại 16", null, null },
                    { 17, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 17", 0, null, false, "Thiết bị loại 17", null, null },
                    { 18, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7083), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 18", 0, null, false, "Thiết bị loại 18", null, null },
                    { 19, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 19", 0, null, false, "Thiết bị loại 19", null, null },
                    { 20, "", new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Mô tả cho danh mục 20", 0, null, false, "Thiết bị loại 20", null, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeptCode", "IsDeleted", "Location", "ManagerName", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "CNTT", false, "Tầng 2 - Nhà B", null, "Khoa CNTT", null, null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DT", false, "Tầng 3 - Nhà C", null, "Phòng Đào tạo", null, null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "HC", false, "Tầng 4 - Nhà D", null, "Phòng Hành chính", null, null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "KH", false, "Tầng 5 - Nhà A", null, "Phòng Kế hoạch", null, null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TTTN", false, "Tầng 1 - Nhà B", null, "Trung tâm Thí nghiệm", null, null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5578), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "DIEN", false, "Tầng 2 - Nhà C", null, "Khoa Điện", null, null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5586), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "CK", false, "Tầng 3 - Nhà D", null, "Khoa Cơ khí", null, null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TVU", false, "Tầng 4 - Nhà A", null, "Phòng Tài vụ", null, null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5599), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "TV", false, "Tầng 5 - Nhà B", null, "Thư viện", null, null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(5608), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "BV", false, "Tầng 1 - Nhà C", null, "Phòng Bảo vệ", null, null }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "Price", "PurchaseDate", "SerialNumber", "Specifications", "Status", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 3, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 800000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7985), "SN-5D45B2A7", null, "Trong kho", null, null, 0 },
                    { 6, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 1100000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8034), "SN-8A328301", null, "Trong kho", null, null, 0 },
                    { 9, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 1400000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8075), "SN-61FE6B1B", null, "Trong kho", null, null, 0 },
                    { 12, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8133), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 1700000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8126), "SN-2A5F00CB", null, "Trong kho", null, null, 0 },
                    { 15, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8216), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 2000000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8202), "SN-1704F11C", null, "Trong kho", null, null, 0 },
                    { 18, 2, null, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 2300000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8239), "SN-AFFC1AD2", null, "Trong kho", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DepartmentId", "Email", "EmployeeCode", "FullName", "IsActive", "IsDeleted", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6259), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 1, "nv1@epu.edu.vn", "NV001", "Nguyễn Văn Admin", true, false, "0987654301", null, null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, "nv2@epu.edu.vn", "NV002", "Nhân viên 2", true, false, "0987654302", null, null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, "nv3@epu.edu.vn", "NV003", "Nhân viên 3", true, false, "0987654303", null, null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, "nv4@epu.edu.vn", "NV004", "Nhân viên 4", true, false, "0987654304", null, null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, "nv5@epu.edu.vn", "NV005", "Nhân viên 5", true, false, "0987654305", null, null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 6, "nv6@epu.edu.vn", "NV006", "Nhân viên 6", true, false, "0987654306", null, null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6514), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 7, "nv7@epu.edu.vn", "NV007", "Nhân viên 7", true, false, "0987654307", null, null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6526), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 8, "nv8@epu.edu.vn", "NV008", "Nhân viên 8", true, false, "0987654308", null, null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 9, "nv9@epu.edu.vn", "NV009", "Nhân viên 9", true, false, "0987654309", null, null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6578), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 10, "nv10@epu.edu.vn", "NV010", "Nhân viên 10", true, false, "0987654310", null, null },
                    { 11, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 1, "nv11@epu.edu.vn", "NV011", "Nhân viên 11", true, false, "0987654311", null, null },
                    { 12, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6629), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, "nv12@epu.edu.vn", "NV012", "Nhân viên 12", true, false, "0987654312", null, null },
                    { 13, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, "nv13@epu.edu.vn", "NV013", "Nhân viên 13", true, false, "0987654313", null, null },
                    { 14, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6653), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, "nv14@epu.edu.vn", "NV014", "Nhân viên 14", true, false, "0987654314", null, null },
                    { 15, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(6688), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, "nv15@epu.edu.vn", "NV015", "Nhân viên 15", true, false, "0987654315", null, null }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Accessories", "AssetCode", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DepartmentId", "EmployeeId", "IsDeleted", "Name", "Packaging", "PurchaseDate", "PurchasePrice", "Status", "Supplier", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 1, null, "EPU-PC-001", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 2, 2, false, "HP ProDesk Gen 1", 0, new DateTime(2026, 4, 11, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7301), 10500000.0, "Bảo trì", null, null, null, 24 },
                    { 2, null, "EPU-PC-002", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7340), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 3, 3, false, "Lenovo ThinkCentre Gen 2", 0, new DateTime(2026, 4, 1, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7338), 11000000.0, "Trong kho", null, null, null, 24 },
                    { 3, null, "EPU-PC-003", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 4, 4, false, "MacBook Air Gen 3", 0, new DateTime(2026, 3, 22, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7400), 11500000.0, "Hỏng", null, null, null, 24 },
                    { 4, null, "EPU-PC-004", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7415), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 5, 5, false, "Asus ExpertCenter Gen 4", 0, new DateTime(2026, 3, 12, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7413), 12000000.0, "Đang dùng", null, null, null, 24 },
                    { 5, null, "EPU-PC-005", 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 6, 6, false, "Dell Optiplex Gen 5", 0, new DateTime(2026, 3, 2, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7426), 12500000.0, "Bảo trì", null, null, null, 24 },
                    { 6, null, "EPU-PC-006", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 7, 7, false, "HP ProDesk Gen 6", 0, new DateTime(2026, 2, 20, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7440), 13000000.0, "Trong kho", null, null, null, 24 },
                    { 7, null, "EPU-PC-007", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 8, 8, false, "Lenovo ThinkCentre Gen 7", 0, new DateTime(2026, 2, 10, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7453), 13500000.0, "Hỏng", null, null, null, 24 },
                    { 8, null, "EPU-PC-008", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 9, 9, false, "MacBook Air Gen 8", 0, new DateTime(2026, 1, 31, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7467), 14000000.0, "Đang dùng", null, null, null, 24 },
                    { 9, null, "EPU-PC-009", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 10, 10, false, "Asus ExpertCenter Gen 9", 0, new DateTime(2026, 1, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7487), 14500000.0, "Bảo trì", null, null, null, 24 },
                    { 10, null, "EPU-PC-010", 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7503), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 11, 11, false, "Dell Optiplex Gen 10", 0, new DateTime(2026, 1, 11, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7501), 15000000.0, "Trong kho", null, null, null, 24 },
                    { 11, null, "EPU-PC-011", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 12, 12, false, "HP ProDesk Gen 11", 0, new DateTime(2026, 1, 1, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7514), 15500000.0, "Hỏng", null, null, null, 24 },
                    { 12, null, "EPU-PC-012", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 13, 13, false, "Lenovo ThinkCentre Gen 12", 0, new DateTime(2025, 12, 22, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7527), 16000000.0, "Đang dùng", null, null, null, 24 },
                    { 13, null, "EPU-PC-013", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 14, 14, false, "MacBook Air Gen 13", 0, new DateTime(2025, 12, 12, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7539), 16500000.0, "Bảo trì", null, null, null, 24 },
                    { 14, null, "EPU-PC-014", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 15, 15, false, "Asus ExpertCenter Gen 14", 0, new DateTime(2025, 12, 2, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7552), 17000000.0, "Trong kho", null, null, null, 24 },
                    { 15, null, "EPU-PC-015", 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 16, 1, false, "Dell Optiplex Gen 15", 0, new DateTime(2025, 11, 22, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7572), 17500000.0, "Hỏng", null, null, null, 24 },
                    { 16, null, "EPU-PC-016", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 17, 2, false, "HP ProDesk Gen 16", 0, new DateTime(2025, 11, 12, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7598), 18000000.0, "Đang dùng", null, null, null, 24 },
                    { 17, null, "EPU-PC-017", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 18, 3, false, "Lenovo ThinkCentre Gen 17", 0, new DateTime(2025, 11, 2, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7611), 18500000.0, "Bảo trì", null, null, null, 24 },
                    { 18, null, "EPU-PC-018", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 19, 4, false, "MacBook Air Gen 18", 0, new DateTime(2025, 10, 23, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7672), 19000000.0, "Trong kho", null, null, null, 24 },
                    { 19, null, "EPU-PC-019", 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 20, 5, false, "Asus ExpertCenter Gen 19", 0, new DateTime(2025, 10, 13, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7685), 19500000.0, "Hỏng", null, null, null, 24 },
                    { 20, null, "EPU-PC-020", 4, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, 1, 6, false, "Dell Optiplex Gen 20", 0, new DateTime(2025, 10, 3, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7698), 20000000.0, "Đang dùng", null, null, null, 24 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "EmployeeId", "IsActive", "IsDeleted", "PasswordHash", "Role", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "admin@epu.edu.vn", 1, true, false, "$2a$11$mwAlHo1UJDvGGx0W4fTuwuBT3YJ4aM5vDQ2iIpfjZQaCy9zt4HJU.", "Admin", null, null, "admin" });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "Price", "PurchaseDate", "SerialNumber", "Specifications", "Status", "UpdatedAt", "UpdatedBy", "WarrantyMonths" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 600000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7814), "SN-4E70DF4D", null, "Đang sử dụng", null, null, 0 },
                    { 2, 2, 3, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(7983), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 700000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7975), "SN-05D2D444", null, "Đang sử dụng", null, null, 0 },
                    { 4, 2, 5, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8004), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 900000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(7996), "SN-CF8521AF", null, "Đang sử dụng", null, null, 0 },
                    { 5, 2, 6, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 1000000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8007), "SN-014E054E", null, "Đang sử dụng", null, null, 0 },
                    { 7, 2, 8, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8062), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 1200000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8044), "SN-27DEFC90", null, "Đang sử dụng", null, null, 0 },
                    { 8, 2, 9, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8073), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 1300000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8064), "SN-4993AF7B", null, "Đang sử dụng", null, null, 0 },
                    { 10, 2, 11, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8115), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 1500000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8085), "SN-E61092AB", null, "Đang sử dụng", null, null, 0 },
                    { 11, 2, 12, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 1600000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8117), "SN-C378A063", null, "Đang sử dụng", null, null, 0 },
                    { 13, 2, 14, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "VGA GTX 1650", 1800000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8135), "SN-B49FBDD2", null, "Đang sử dụng", null, null, 0 },
                    { 14, 2, 15, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 1900000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8191), "SN-67793E24", null, "Đang sử dụng", null, null, 0 },
                    { 16, 2, 17, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "SSD Samsung 256GB", 2100000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8218), "SN-093FA831", null, "Đang sử dụng", null, null, 0 },
                    { 17, 2, 18, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "CPU Intel i5", 2200000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8228), "SN-E3E5A0BE", null, "Đang sử dụng", null, null, 0 },
                    { 19, 2, 20, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "Nguồn Cooler Master", 2400000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8248), "SN-20A90F4F", null, "Đang sử dụng", null, null, 0 },
                    { 20, 2, 1, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, false, "RAM Kington 8GB", 2500000.0, new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8257), "SN-AD088685", null, "Đang sử dụng", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceLogs",
                columns: new[] { "Id", "ComputerId", "Cost", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "ImageUrl", "IsDeleted", "RepairDate", "ServiceProvider", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 2, 150000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8379), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 1", null, false, new DateTime(2026, 4, 20, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8369), null, "Hoàn thành", null, null },
                    { 2, 3, 200000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 2", null, false, new DateTime(2026, 4, 19, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8388), null, "Hoàn thành", null, null },
                    { 3, 4, 250000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 3", null, false, new DateTime(2026, 4, 18, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8397), null, "Hoàn thành", null, null },
                    { 4, 5, 300000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8408), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 4", null, false, new DateTime(2026, 4, 17, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8405), null, "Hoàn thành", null, null },
                    { 5, 6, 350000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8416), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 5", null, false, new DateTime(2026, 4, 16, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8413), null, "Hoàn thành", null, null },
                    { 6, 7, 400000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8425), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 6", null, false, new DateTime(2026, 4, 15, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8422), null, "Hoàn thành", null, null },
                    { 7, 8, 450000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8433), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 7", null, false, new DateTime(2026, 4, 14, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8429), null, "Hoàn thành", null, null },
                    { 8, 9, 500000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 8", null, false, new DateTime(2026, 4, 13, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8437), null, "Hoàn thành", null, null },
                    { 9, 10, 550000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 9", null, false, new DateTime(2026, 4, 12, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8445), null, "Hoàn thành", null, null },
                    { 10, 11, 600000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8466), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 10", null, false, new DateTime(2026, 4, 11, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8454), null, "Hoàn thành", null, null },
                    { 11, 12, 650000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8475), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 11", null, false, new DateTime(2026, 4, 10, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8471), null, "Hoàn thành", null, null },
                    { 12, 13, 700000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8569), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 12", null, false, new DateTime(2026, 4, 9, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8479), null, "Hoàn thành", null, null },
                    { 13, 14, 750000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 13", null, false, new DateTime(2026, 4, 8, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8573), null, "Hoàn thành", null, null },
                    { 14, 15, 800000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 14", null, false, new DateTime(2026, 4, 7, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8582), null, "Hoàn thành", null, null },
                    { 15, 16, 850000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 15", null, false, new DateTime(2026, 4, 6, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8590), null, "Hoàn thành", null, null },
                    { 16, 17, 900000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8602), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 16", null, false, new DateTime(2026, 4, 5, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8598), null, "Hoàn thành", null, null },
                    { 17, 18, 950000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 17", null, false, new DateTime(2026, 4, 4, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8606), null, "Hoàn thành", null, null },
                    { 18, 19, 1000000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8619), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 18", null, false, new DateTime(2026, 4, 3, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8615), null, "Hoàn thành", null, null },
                    { 19, 20, 1050000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8627), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 19", null, false, new DateTime(2026, 4, 2, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8623), null, "Hoàn thành", null, null },
                    { 20, 1, 1100000.0, new DateTimeOffset(new DateTime(2026, 4, 21, 15, 3, 27, 442, DateTimeKind.Unspecified).AddTicks(8635), new TimeSpan(0, 7, 0, 0, 0)), null, null, null, "Bảo trì định kỳ lần thứ 20", null, false, new DateTime(2026, 4, 1, 15, 3, 27, 442, DateTimeKind.Local).AddTicks(8631), null, "Hoàn thành", null, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");
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

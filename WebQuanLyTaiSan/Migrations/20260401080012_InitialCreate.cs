using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebQuanLyTaiSan.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
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
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
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
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
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
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 1", false, "Máy tính để bàn", null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 2", false, "Linh kiện rời", null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 3", false, "Thiết bị mạng", null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 4", false, "Laptop", null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 5", false, "Máy in", null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 6", false, "Máy chiếu", null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 7", false, "Server", null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 8", false, "Thiết bị lưu trữ", null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(128), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 9", false, "Thiết bị loại 9", null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(132), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 10", false, "Thiết bị loại 10", null },
                    { 11, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 11", false, "Thiết bị loại 11", null },
                    { 12, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(172), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 12", false, "Thiết bị loại 12", null },
                    { 13, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 13", false, "Thiết bị loại 13", null },
                    { 14, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 14", false, "Thiết bị loại 14", null },
                    { 15, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(179), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 15", false, "Thiết bị loại 15", null },
                    { 16, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 16", false, "Thiết bị loại 16", null },
                    { 17, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 17", false, "Thiết bị loại 17", null },
                    { 18, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 18", false, "Thiết bị loại 18", null },
                    { 19, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(192), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 19", false, "Thiết bị loại 19", null },
                    { 20, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(195), new TimeSpan(0, 7, 0, 0, 0)), null, "Mô tả cho danh mục 20", false, "Thiết bị loại 20", null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Location", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9758), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 2 - Nhà B", "Khoa CNTT", null },
                    { 2, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 3 - Nhà C", "Phòng Đào tạo", null },
                    { 3, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 4 - Nhà D", "Phòng Hành chính", null },
                    { 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9812), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 5 - Nhà A", "Phòng Kế hoạch", null },
                    { 5, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 1 - Nhà B", "Trung tâm Thí nghiệm", null },
                    { 6, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9858), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 2 - Nhà C", "Khoa Điện", null },
                    { 7, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 3 - Nhà D", "Khoa Cơ khí", null },
                    { 8, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 4 - Nhà A", "Phòng Tài vụ", null },
                    { 9, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 5 - Nhà B", "Thư viện", null },
                    { 10, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 1 - Nhà C", "Phòng Bảo vệ", null },
                    { 11, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 2 - Nhà D", "Phòng chức năng 11", null },
                    { 12, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9880), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 3 - Nhà A", "Phòng chức năng 12", null },
                    { 13, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 4 - Nhà B", "Phòng chức năng 13", null },
                    { 14, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 5 - Nhà C", "Phòng chức năng 14", null },
                    { 15, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 1 - Nhà D", "Phòng chức năng 15", null },
                    { 16, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 2 - Nhà A", "Phòng chức năng 16", null },
                    { 17, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 3 - Nhà B", "Phòng chức năng 17", null },
                    { 18, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9899), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 4 - Nhà C", "Phòng chức năng 18", null },
                    { 19, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 5 - Nhà D", "Phòng chức năng 19", null },
                    { 20, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 234, DateTimeKind.Unspecified).AddTicks(9905), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Tầng 1 - Nhà A", "Phòng chức năng 20", null }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "Price", "SerialNumber", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 7, 0, 0, 0)), null, false, "VGA GTX 1650", 800000.0, "SN-939E9E19", "Trong kho", null },
                    { 6, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 7, 0, 0, 0)), null, false, "SSD Samsung 256GB", 1100000.0, "SN-C9AB4CC1", "Trong kho", null },
                    { 9, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Nguồn Cooler Master", 1400000.0, "SN-BFE7A507", "Trong kho", null },
                    { 12, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 7, 0, 0, 0)), null, false, "CPU Intel i5", 1700000.0, "SN-68F0AF2F", "Trong kho", null },
                    { 15, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 7, 0, 0, 0)), null, false, "RAM Kington 8GB", 2000000.0, "SN-23C3FBC9", "Trong kho", null },
                    { 18, 2, null, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 7, 0, 0, 0)), null, false, "VGA GTX 1650", 2300000.0, "SN-B02DCBD6", "Trong kho", null }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "AssetCode", "CategoryId", "CreatedAt", "DeletedAt", "DepartmentId", "IsDeleted", "Name", "PurchaseDate", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "EPU-PC-001", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 7, 0, 0, 0)), null, 2, false, "HP ProDesk Gen 1", new DateTime(2026, 3, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(280), "Bảo trì", null },
                    { 2, "EPU-PC-002", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 7, 0, 0, 0)), null, 3, false, "Lenovo ThinkCentre Gen 2", new DateTime(2026, 3, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(297), "Trong kho", null },
                    { 3, "EPU-PC-003", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(302), new TimeSpan(0, 7, 0, 0, 0)), null, 4, false, "MacBook Air Gen 3", new DateTime(2026, 3, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(302), "Hỏng", null },
                    { 4, "EPU-PC-004", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 7, 0, 0, 0)), null, 5, false, "Asus ExpertCenter Gen 4", new DateTime(2026, 2, 20, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(306), "Đang dùng", null },
                    { 5, "EPU-PC-005", 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(311), new TimeSpan(0, 7, 0, 0, 0)), null, 6, false, "Dell Optiplex Gen 5", new DateTime(2026, 2, 10, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(311), "Bảo trì", null },
                    { 6, "EPU-PC-006", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 7, 0, 0, 0)), null, 7, false, "HP ProDesk Gen 6", new DateTime(2026, 1, 31, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(316), "Trong kho", null },
                    { 7, "EPU-PC-007", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 7, 0, 0, 0)), null, 8, false, "Lenovo ThinkCentre Gen 7", new DateTime(2026, 1, 21, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(321), "Hỏng", null },
                    { 8, "EPU-PC-008", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 7, 0, 0, 0)), null, 9, false, "MacBook Air Gen 8", new DateTime(2026, 1, 11, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(341), "Đang dùng", null },
                    { 9, "EPU-PC-009", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(346), new TimeSpan(0, 7, 0, 0, 0)), null, 10, false, "Asus ExpertCenter Gen 9", new DateTime(2026, 1, 1, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(346), "Bảo trì", null },
                    { 10, "EPU-PC-010", 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(353), new TimeSpan(0, 7, 0, 0, 0)), null, 11, false, "Dell Optiplex Gen 10", new DateTime(2025, 12, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(352), "Trong kho", null },
                    { 11, "EPU-PC-011", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(358), new TimeSpan(0, 7, 0, 0, 0)), null, 12, false, "HP ProDesk Gen 11", new DateTime(2025, 12, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(357), "Hỏng", null },
                    { 12, "EPU-PC-012", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 7, 0, 0, 0)), null, 13, false, "Lenovo ThinkCentre Gen 12", new DateTime(2025, 12, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(361), "Đang dùng", null },
                    { 13, "EPU-PC-013", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 7, 0, 0, 0)), null, 14, false, "MacBook Air Gen 13", new DateTime(2025, 11, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(366), "Bảo trì", null },
                    { 14, "EPU-PC-014", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(371), new TimeSpan(0, 7, 0, 0, 0)), null, 15, false, "Asus ExpertCenter Gen 14", new DateTime(2025, 11, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(370), "Trong kho", null },
                    { 15, "EPU-PC-015", 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, 7, 0, 0, 0)), null, 16, false, "Dell Optiplex Gen 15", new DateTime(2025, 11, 2, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(396), "Hỏng", null },
                    { 16, "EPU-PC-016", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 7, 0, 0, 0)), null, 17, false, "HP ProDesk Gen 16", new DateTime(2025, 10, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(400), "Đang dùng", null },
                    { 17, "EPU-PC-017", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, 7, 0, 0, 0)), null, 18, false, "Lenovo ThinkCentre Gen 17", new DateTime(2025, 10, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(405), "Bảo trì", null },
                    { 18, "EPU-PC-018", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(412), new TimeSpan(0, 7, 0, 0, 0)), null, 19, false, "MacBook Air Gen 18", new DateTime(2025, 10, 3, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(411), "Trong kho", null },
                    { 19, "EPU-PC-019", 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(416), new TimeSpan(0, 7, 0, 0, 0)), null, 20, false, "Asus ExpertCenter Gen 19", new DateTime(2025, 9, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(415), "Hỏng", null },
                    { 20, "EPU-PC-020", 4, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 7, 0, 0, 0)), null, 1, false, "Dell Optiplex Gen 20", new DateTime(2025, 9, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(420), "Đang dùng", null }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "CategoryId", "ComputerId", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "Price", "SerialNumber", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 7, 0, 0, 0)), null, false, "SSD Samsung 256GB", 600000.0, "SN-5FB53F7E", "Đang sử dụng", null },
                    { 2, 2, 3, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 7, 0, 0, 0)), null, false, "CPU Intel i5", 700000.0, "SN-6031CF50", "Đang sử dụng", null },
                    { 4, 2, 5, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(624), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Nguồn Cooler Master", 900000.0, "SN-99AEC86A", "Đang sử dụng", null },
                    { 5, 2, 6, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 7, 0, 0, 0)), null, false, "RAM Kington 8GB", 1000000.0, "SN-32361A6F", "Đang sử dụng", null },
                    { 7, 2, 8, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 7, 0, 0, 0)), null, false, "CPU Intel i5", 1200000.0, "SN-391D0AF4", "Đang sử dụng", null },
                    { 8, 2, 9, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 7, 0, 0, 0)), null, false, "VGA GTX 1650", 1300000.0, "SN-7662EC6B", "Đang sử dụng", null },
                    { 10, 2, 11, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(666), new TimeSpan(0, 7, 0, 0, 0)), null, false, "RAM Kington 8GB", 1500000.0, "SN-4EA2168A", "Đang sử dụng", null },
                    { 11, 2, 12, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 7, 0, 0, 0)), null, false, "SSD Samsung 256GB", 1600000.0, "SN-5DC54975", "Đang sử dụng", null },
                    { 13, 2, 14, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 7, 0, 0, 0)), null, false, "VGA GTX 1650", 1800000.0, "SN-803AF167", "Đang sử dụng", null },
                    { 14, 2, 15, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Nguồn Cooler Master", 1900000.0, "SN-C1D206E0", "Đang sử dụng", null },
                    { 16, 2, 17, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 7, 0, 0, 0)), null, false, "SSD Samsung 256GB", 2100000.0, "SN-AB072D8C", "Đang sử dụng", null },
                    { 17, 2, 18, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 7, 0, 0, 0)), null, false, "CPU Intel i5", 2200000.0, "SN-6FD1D701", "Đang sử dụng", null },
                    { 19, 2, 20, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 7, 0, 0, 0)), null, false, "Nguồn Cooler Master", 2400000.0, "SN-6CC79410", "Đang sử dụng", null },
                    { 20, 2, 1, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 7, 0, 0, 0)), null, false, "RAM Kington 8GB", 2500000.0, "SN-2DAB79F4", "Đang sử dụng", null }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceLogs",
                columns: new[] { "Id", "ComputerId", "Cost", "CreatedAt", "DeletedAt", "Description", "ImageUrl", "IsDeleted", "RepairDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, 150000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 1", null, false, new DateTime(2026, 3, 31, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(831), null },
                    { 2, 3, 200000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(844), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 2", null, false, new DateTime(2026, 3, 30, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(842), null },
                    { 3, 4, 250000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 3", null, false, new DateTime(2026, 3, 29, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(846), null },
                    { 4, 5, 300000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 4", null, false, new DateTime(2026, 3, 28, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(849), null },
                    { 5, 6, 350000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 5", null, false, new DateTime(2026, 3, 27, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(852), null },
                    { 6, 7, 400000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 6", null, false, new DateTime(2026, 3, 26, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(856), null },
                    { 7, 8, 450000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 7", null, false, new DateTime(2026, 3, 25, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(860), null },
                    { 8, 9, 500000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 8", null, false, new DateTime(2026, 3, 24, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(862), null },
                    { 9, 10, 550000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 9", null, false, new DateTime(2026, 3, 23, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(865), null },
                    { 10, 11, 600000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 10", null, false, new DateTime(2026, 3, 22, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(869), null },
                    { 11, 12, 650000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(875), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 11", null, false, new DateTime(2026, 3, 21, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(873), null },
                    { 12, 13, 700000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(878), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 12", null, false, new DateTime(2026, 3, 20, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(876), null },
                    { 13, 14, 750000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 13", null, false, new DateTime(2026, 3, 19, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(879), null },
                    { 14, 15, 800000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 14", null, false, new DateTime(2026, 3, 18, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(883), null },
                    { 15, 16, 850000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(888), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 15", null, false, new DateTime(2026, 3, 17, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(886), null },
                    { 16, 17, 900000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(891), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 16", null, false, new DateTime(2026, 3, 16, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(890), null },
                    { 17, 18, 950000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 17", null, false, new DateTime(2026, 3, 15, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(893), null },
                    { 18, 19, 1000000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 18", null, false, new DateTime(2026, 3, 14, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(957), null },
                    { 19, 20, 1050000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 19", null, false, new DateTime(2026, 3, 13, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(962), null },
                    { 20, 1, 1100000.0, new DateTimeOffset(new DateTime(2026, 4, 1, 15, 0, 11, 235, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 7, 0, 0, 0)), null, "Bảo trì định kỳ lần thứ 20", null, false, new DateTime(2026, 3, 12, 15, 0, 11, 235, DateTimeKind.Local).AddTicks(965), null }
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
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

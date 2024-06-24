using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class menutanimlamasi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menuler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QueryStrings = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Css = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menuler_Menuler_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menuler",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 369, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 369, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 369, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 369, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.InsertData(
                table: "Menuler",
                columns: new[] { "Id", "ActionName", "Area", "Class", "ControllerName", "CreateDate", "Css", "Description", "Name", "OrderNo", "ParentId", "ParentMenuId", "QueryStrings" },
                values: new object[,]
                {
                    { 1, "", "", null, "", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5073), null, "Urun Yonetimi", "Urun Yonetimi", null, null, null, null },
                    { 2, "Index", "Admin", null, "Urun", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5096), null, "Urunler", "Urunler", null, 1, null, null },
                    { 3, "Index", "Admin", null, "Kategori", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5102), null, "Kategoriler", "Kategoriler", null, 1, null, null },
                    { 4, "KategoriYonet", "Admin", null, "Urun", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5106), null, "Urunlere Kategori Ekle", "Urunlere Kategori Ekleme", null, 1, null, null },
                    { 5, "UrunYonet", "Admin", null, "Kategori", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5111), null, "Kategorilere Urun Ekle", "Kategorilere Urun Ekleme", null, 1, null, null },
                    { 6, "", "", null, "", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5117), null, "Tedarikciler", "Tedarikciler", null, null, null, null },
                    { 7, "Index", "Admin", null, "Tedarikci", new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5121), null, "Tedarikciler", "Tedarikciler", null, 6, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 372, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 372, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 372, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.CreateIndex(
                name: "IX_Menuler_ParentMenuId",
                table: "Menuler",
                column: "ParentMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menuler");

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6616));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class urunfoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Users",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UrunFotolari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DataFiles = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunFotolari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrunFotolari_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.CreateIndex(
                name: "IX_UrunFotolari_Name",
                table: "UrunFotolari",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_UrunFotolari_UrunId",
                table: "UrunFotolari",
                column: "UrunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrunFotolari");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Users");

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

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 13, 14, 9, 13, 371, DateTimeKind.Local).AddTicks(5121));

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
        }
    }
}

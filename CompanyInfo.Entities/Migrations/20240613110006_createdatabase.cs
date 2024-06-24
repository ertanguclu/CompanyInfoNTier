using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Adet = table.Column<double>(type: "float", nullable: true),
                    NegatifStokCalis = table.Column<bool>(type: "bit", nullable: false),
                    BirimId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Birimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    KullanicilarId = table.Column<int>(type: "int", nullable: false),
                    RollerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.KullanicilarId, x.RollerId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roller_RollerId",
                        column: x => x.RollerId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategoriUrun",
                columns: table => new
                {
                    KategorilerId = table.Column<int>(type: "int", nullable: false),
                    UrunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriUrun", x => new { x.KategorilerId, x.UrunlerId });
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TedarikciUrun",
                columns: table => new
                {
                    TedarikcilerId = table.Column<int>(type: "int", nullable: false),
                    UrunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TedarikciUrun", x => new { x.TedarikcilerId, x.UrunlerId });
                    table.ForeignKey(
                        name: "FK_TedarikciUrun_Tedarikciler_TedarikcilerId",
                        column: x => x.TedarikcilerId,
                        principalTable: "Tedarikciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TedarikciUrun_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Birimler",
                columns: new[] { "Id", "BirimAdi", "CreateDate" },
                values: new object[,]
                {
                    { 1, "Adet", new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7568) },
                    { 2, "Cm", new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7570) },
                    { 3, "Gram", new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7572) },
                    { 4, "Miligram", new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7574) }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklama", "CreateDate", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(735), "Gida" },
                    { 2, null, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(738), "Tekstil" },
                    { 3, null, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(739), "Eletronik" },
                    { 4, null, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(741), "Otomotiv" }
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "CreateDate", "RoleAdi" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3600), "Admin" },
                    { 2, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3606), "User" },
                    { 3, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3607), "Satis" }
                });

            migrationBuilder.InsertData(
                table: "Tedarikciler",
                columns: new[] { "Id", "CreateDate", "SirketAdi", "VergiNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6612), "Abc", "123" },
                    { 2, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6615), "Asd", "456" },
                    { 3, new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6616), "Qwe", "7789" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Birimler_BirimAdi",
                table: "Birimler",
                column: "BirimAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KategoriUrun_UrunlerId",
                table: "KategoriUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_RollerId",
                table: "RoleUser",
                column: "RollerId");

            migrationBuilder.CreateIndex(
                name: "IX_Roller_RoleAdi",
                table: "Roller",
                column: "RoleAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikciler_VergiNo",
                table: "Tedarikciler",
                column: "VergiNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TedarikciUrun_UrunlerId",
                table: "TedarikciUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BirimId",
                table: "Urunler",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UrunKodu",
                table: "Urunler",
                column: "UrunKodu",
                unique: true,
                filter: "[UrunKodu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gsm",
                table: "Users",
                column: "Gsm",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriUrun");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "TedarikciUrun");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Birimler");
        }
    }
}

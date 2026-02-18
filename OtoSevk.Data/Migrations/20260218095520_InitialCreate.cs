using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoSevk.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiseGelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AracSorunu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServisUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServistenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YapilanIslemler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarantiKapsamindaMi = table.Column<bool>(type: "bit", nullable: true),
                    AracPlaka = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KasaTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suruculer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SurucuAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RolId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suruculer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaId = table.Column<int>(type: "int", nullable: false),
                    AracPlaka = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Modeli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KasaTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelYili = table.Column<int>(type: "int", nullable: false),
                    GorevdeMi = table.Column<bool>(type: "bit", nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Araclar_Markalar_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AracKomutanilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracKomutanilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracKomutanilar_Araclar_AracId",
                        column: x => x.AracId,
                        principalTable: "Araclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sevkler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    AracPlaka = table.Column<int>(type: "int", nullable: false),
                    SurucuId = table.Column<int>(type: "int", nullable: false),
                    SevkTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SevkSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SevkDonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SevkDonusSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SevkNedeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevkYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracKomutaniID = table.Column<int>(type: "int", nullable: false),
                    AracKomutaniAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracKomutaniSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracKomutaniTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YapilanKM = table.Column<int>(type: "int", nullable: false),
                    YolcuAdedi = table.Column<int>(type: "int", nullable: false),
                    NotlarTasinanYuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CikisTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklamalar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sevkler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sevkler_AracKomutanilar_AracKomutaniID",
                        column: x => x.AracKomutaniID,
                        principalTable: "AracKomutanilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sevkler_Araclar_AracId",
                        column: x => x.AracId,
                        principalTable: "Araclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "Adi" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Suruculer",
                columns: new[] { "Id", "Adi", "AktifMi", "EklenmeTarihi", "Email", "RolId", "Sifre", "Soyadi", "SurucuAdi", "Telefon" },
                values: new object[] { 1, "Admin", true, new DateTime(2026, 2, 18, 12, 55, 19, 730, DateTimeKind.Local).AddTicks(2838), "admin@OtoSevk.tc", 1, "123456", "admin", "admin", "850" });

            migrationBuilder.CreateIndex(
                name: "IX_AracKomutanilar_AracId",
                table: "AracKomutanilar",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_MarkaId",
                table: "Araclar",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sevkler_AracId",
                table: "Sevkler",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Sevkler_AracKomutaniID",
                table: "Sevkler",
                column: "AracKomutaniID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Servisler");

            migrationBuilder.DropTable(
                name: "Sevkler");

            migrationBuilder.DropTable(
                name: "Suruculer");

            migrationBuilder.DropTable(
                name: "AracKomutanilar");

            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "Markalar");
        }
    }
}

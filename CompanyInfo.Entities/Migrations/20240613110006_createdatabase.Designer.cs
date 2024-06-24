﻿// <auto-generated />
using System;
using CompanyInfo.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240613110006_createdatabase")]
    partial class createdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirimAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BirimAdi")
                        .IsUnique();

                    b.ToTable("Birimler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirimAdi = "Adet",
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7568)
                        },
                        new
                        {
                            Id = 2,
                            BirimAdi = "Cm",
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7570)
                        },
                        new
                        {
                            Id = 3,
                            BirimAdi = "Gram",
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7572)
                        },
                        new
                        {
                            Id = 4,
                            BirimAdi = "Miligram",
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 86, DateTimeKind.Local).AddTicks(7574)
                        });
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriAdi")
                        .IsUnique();

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(735),
                            KategoriAdi = "Gida"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(738),
                            KategoriAdi = "Tekstil"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(739),
                            KategoriAdi = "Eletronik"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(741),
                            KategoriAdi = "Otomotiv"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleAdi")
                        .IsUnique();

                    b.ToTable("Roller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3600),
                            RoleAdi = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3606),
                            RoleAdi = "User"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(3607),
                            RoleAdi = "Satis"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("VergiNo")
                        .IsUnique();

                    b.ToTable("Tedarikciler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6612),
                            SirketAdi = "Abc",
                            VergiNo = "123"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6615),
                            SirketAdi = "Asd",
                            VergiNo = "456"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 13, 14, 0, 6, 87, DateTimeKind.Local).AddTicks(6616),
                            SirketAdi = "Qwe",
                            VergiNo = "7789"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Adet")
                        .HasColumnType("float");

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Fiyat")
                        .HasColumnType("float");

                    b.Property<bool>("NegatifStokCalis")
                        .HasColumnType("bit");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrunKodu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("UrunKodu")
                        .IsUnique()
                        .HasFilter("[UrunKodu] IS NOT NULL");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Gsm")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("KategoriUrun");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<int>("RollerId")
                        .HasColumnType("int");

                    b.HasKey("KullanicilarId", "RollerId");

                    b.HasIndex("RollerId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("TedarikciUrun", b =>
                {
                    b.Property<int>("TedarikcilerId")
                        .HasColumnType("int");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("TedarikcilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("TedarikciUrun");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Urun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Birim", "Birim")
                        .WithMany("Urunler")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("KullanicilarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RollerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TedarikciUrun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Tedarikci", null)
                        .WithMany()
                        .HasForeignKey("TedarikcilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Birim", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}

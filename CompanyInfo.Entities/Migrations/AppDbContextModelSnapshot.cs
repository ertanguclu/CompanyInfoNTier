﻿// <auto-generated />
using System;
using CompanyInfo.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3955)
                        },
                        new
                        {
                            Id = 2,
                            BirimAdi = "Cm",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3957)
                        },
                        new
                        {
                            Id = 3,
                            BirimAdi = "Gram",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3959)
                        },
                        new
                        {
                            Id = 4,
                            BirimAdi = "Miligram",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(3960)
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
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7224),
                            KategoriAdi = "Gida"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7227),
                            KategoriAdi = "Tekstil"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7228),
                            KategoriAdi = "Eletronik"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 840, DateTimeKind.Local).AddTicks(7230),
                            KategoriAdi = "Otomotiv"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Area")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Class")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ControllerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Css")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OrderNo")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentMenuId")
                        .HasColumnType("int");

                    b.Property<string>("QueryStrings")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("ParentMenuId");

                    b.ToTable("Menuler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActionName = "",
                            Area = "",
                            ControllerName = "",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(234),
                            Description = "Urun Yonetimi",
                            Name = "Urun Yonetimi"
                        },
                        new
                        {
                            Id = 2,
                            ActionName = "Index",
                            Area = "Admin",
                            ControllerName = "Urun",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(259),
                            Description = "Urunler",
                            Name = "Urunler",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActionName = "Index",
                            Area = "Admin",
                            ControllerName = "Kategori",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(264),
                            Description = "Kategoriler",
                            Name = "Kategoriler",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 4,
                            ActionName = "KategoriYonet",
                            Area = "Admin",
                            ControllerName = "Urun",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(268),
                            Description = "Urunlere Kategori Ekle",
                            Name = "Urunlere Kategori Ekleme",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 5,
                            ActionName = "UrunYonet",
                            Area = "Admin",
                            ControllerName = "Kategori",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(272),
                            Description = "Kategorilere Urun Ekle",
                            Name = "Kategorilere Urun Ekleme",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 6,
                            ActionName = "",
                            Area = "",
                            ControllerName = "",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(279),
                            Description = "Tedarikciler",
                            Name = "Tedarikciler"
                        },
                        new
                        {
                            Id = 7,
                            ActionName = "Index",
                            Area = "Admin",
                            ControllerName = "Tedarikci",
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(284),
                            Description = "Tedarikciler",
                            Name = "Tedarikciler",
                            ParentId = 6
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
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3220),
                            RoleAdi = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3226),
                            RoleAdi = "User"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(3227),
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
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6487),
                            SirketAdi = "Abc",
                            VergiNo = "123"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6490),
                            SirketAdi = "Asd",
                            VergiNo = "456"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 6, 14, 15, 32, 34, 841, DateTimeKind.Local).AddTicks(6492),
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

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.UrunFoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("DataFiles")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FilePath")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FileType")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("UrunId");

                    b.ToTable("UrunFotolari");
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

                    b.Property<string>("ImagePath")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

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

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Menu", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Menu", "ParentMenu")
                        .WithMany("Menuler")
                        .HasForeignKey("ParentMenuId");

                    b.Navigation("ParentMenu");
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

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.UrunFoto", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Urun", "Urun")
                        .WithMany("Fotograflar")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
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

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Menu", b =>
                {
                    b.Navigation("Menuler");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Urun", b =>
                {
                    b.Navigation("Fotograflar");
                });
#pragma warning restore 612, 618
        }
    }
}

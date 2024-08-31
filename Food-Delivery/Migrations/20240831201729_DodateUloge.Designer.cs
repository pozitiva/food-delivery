﻿// <auto-generated />
using System;
using DostavaHrane.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DostavaHrane.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240831201729_DodateUloge")]
    partial class DodateUloge
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DostavaHrane.Entiteti.Adresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusterijaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MusterijaId");

                    b.ToTable("Adrese");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Dostavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrojDostava")
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dostavljaci");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Jelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RestoranId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SlikaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipJela")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RestoranId");

                    b.ToTable("Jela");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Narudzbina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdresaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumNarudzbine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DostavljacId")
                        .HasColumnType("int");

                    b.Property<string>("MusterijaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestoranId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UkupnaCena")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.HasIndex("DostavljacId");

                    b.HasIndex("MusterijaId");

                    b.HasIndex("RestoranId");

                    b.ToTable("Narudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.StavkaNarudzbine", b =>
                {
                    b.Property<int>("JeloId")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbinaId")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.HasKey("JeloId", "NarudzbinaId");

                    b.HasIndex("NarudzbinaId");

                    b.ToTable("StavkeNarudzbina");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "musterija-uloga",
                            Name = "Musterija",
                            NormalizedName = "MUSTERIJA"
                        },
                        new
                        {
                            Id = "restoran-uloga",
                            Name = "Restoran",
                            NormalizedName = "RESTORAN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Musterija", b =>
                {
                    b.HasBaseType("DostavaHrane.Entiteti.Korisnik");

                    b.ToTable("Musterije", (string)null);
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Restoran", b =>
                {
                    b.HasBaseType("DostavaHrane.Entiteti.Korisnik");

                    b.Property<string>("RadnoVreme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Restorani", (string)null);
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Adresa", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Musterija", "Musterija")
                        .WithMany("Adrese")
                        .HasForeignKey("MusterijaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Musterija");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Jelo", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Restoran", "Restoran")
                        .WithMany("Jela")
                        .HasForeignKey("RestoranId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Narudzbina", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Adresa", "Adresa")
                        .WithMany("Narudzbine")
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DostavaHrane.Entiteti.Dostavljac", "Dostavljac")
                        .WithMany("Narudzbine")
                        .HasForeignKey("DostavljacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DostavaHrane.Entiteti.Musterija", "Musterija")
                        .WithMany("Narudzbine")
                        .HasForeignKey("MusterijaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DostavaHrane.Entiteti.Restoran", "Restoran")
                        .WithMany("Narudzbine")
                        .HasForeignKey("RestoranId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adresa");

                    b.Navigation("Dostavljac");

                    b.Navigation("Musterija");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.StavkaNarudzbine", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Jelo", "Jelo")
                        .WithMany("StavkeNarudzbine")
                        .HasForeignKey("JeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DostavaHrane.Entiteti.Narudzbina", "Narudzbina")
                        .WithMany("StavkeNarudzbine")
                        .HasForeignKey("NarudzbinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jelo");

                    b.Navigation("Narudzbina");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Musterija", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("DostavaHrane.Entiteti.Musterija", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Restoran", b =>
                {
                    b.HasOne("DostavaHrane.Entiteti.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("DostavaHrane.Entiteti.Restoran", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Adresa", b =>
                {
                    b.Navigation("Narudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Dostavljac", b =>
                {
                    b.Navigation("Narudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Jelo", b =>
                {
                    b.Navigation("StavkeNarudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Narudzbina", b =>
                {
                    b.Navigation("StavkeNarudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Musterija", b =>
                {
                    b.Navigation("Adrese");

                    b.Navigation("Narudzbine");
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Restoran", b =>
                {
                    b.Navigation("Jela");

                    b.Navigation("Narudzbine");
                });
#pragma warning restore 612, 618
        }
    }
}
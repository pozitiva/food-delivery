﻿// <auto-generated />
using System;
using DostavaHrane.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DostavaHrane.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("MusterijaId")
                        .HasColumnType("int");

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

                    b.Property<int>("RestoranId")
                        .HasColumnType("int");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnici", (string)null);

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

                    b.Property<int>("MusterijaId")
                        .HasColumnType("int");

                    b.Property<int>("RestoranId")
                        .HasColumnType("int");

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

            modelBuilder.Entity("DostavaHrane.Entiteti.Musterija", b =>
                {
                    b.HasBaseType("DostavaHrane.Entiteti.Korisnik");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("SifraHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SifraSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VerifikacioniToken")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Musterije", (string)null);
                });

            modelBuilder.Entity("DostavaHrane.Entiteti.Restoran", b =>
                {
                    b.HasBaseType("DostavaHrane.Entiteti.Korisnik");

                    b.Property<string>("RadnoVreme")
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

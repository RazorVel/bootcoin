﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bootcoin.Data;

#nullable disable

namespace bootcoin.Migrations
{
    [DbContext(typeof(BootcoinDbContext))]
    partial class BootcoinDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bootcoin.Models.Domain.Profile", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FunFact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zodiac")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.TransactionDetail", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BalanceAfter")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.ToTable("TransactionDetails");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.TransactionHeader", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SourceId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TargetId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionId");

                    b.HasIndex("SourceId");

                    b.HasIndex("TargetId");

                    b.ToTable("TransactionHeaders");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.Profile", b =>
                {
                    b.HasOne("bootcoin.Models.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.TransactionDetail", b =>
                {
                    b.HasOne("bootcoin.Models.Domain.TransactionHeader", "TransactionHeader")
                        .WithMany()
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionHeader");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.TransactionHeader", b =>
                {
                    b.HasOne("bootcoin.Models.Domain.User", "Source")
                        .WithMany("sourceTransaction")
                        .HasForeignKey("SourceId")
                        .IsRequired();

                    b.HasOne("bootcoin.Models.Domain.User", "Target")
                        .WithMany("targetTransaction")
                        .HasForeignKey("TargetId")
                        .IsRequired();

                    b.Navigation("Source");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("bootcoin.Models.Domain.User", b =>
                {
                    b.Navigation("sourceTransaction");

                    b.Navigation("targetTransaction");
                });
#pragma warning restore 612, 618
        }
    }
}

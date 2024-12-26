﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Noodles.Models;

#nullable disable

namespace Noodles.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241226223315_hello6")]
    partial class hello6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Noodles.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDateUTC")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateUTC = new DateTime(2024, 12, 26, 22, 33, 15, 192, DateTimeKind.Utc).AddTicks(8320),
                            Email = "noname@hotmail.com",
                            Message = "真的好细好细好细啊",
                            Name = "阿莱克斯"
                        },
                        new
                        {
                            Id = 2,
                            CreateDateUTC = new DateTime(2024, 12, 26, 22, 33, 15, 192, DateTimeKind.Utc).AddTicks(8320),
                            Email = "noname@hotmail.com",
                            Message = "还是挺细的",
                            Name = "莱克斯"
                        },
                        new
                        {
                            Id = 3,
                            CreateDateUTC = new DateTime(2024, 12, 26, 22, 33, 15, 192, DateTimeKind.Utc).AddTicks(8320),
                            Email = "noname@hotmail.com",
                            Message = "比细的粗点，比二细细点",
                            Name = "克斯"
                        },
                        new
                        {
                            Id = 4,
                            CreateDateUTC = new DateTime(2024, 12, 26, 22, 33, 15, 192, DateTimeKind.Utc).AddTicks(8330),
                            Email = "noname@hotmail.com",
                            Message = "粗的才有嚼劲",
                            Name = "克斯"
                        });
                });

            modelBuilder.Entity("Noodles.Models.Noodle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HResult")
                        .HasColumnType("int");

                    b.Property<string>("HelpLink")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Noodles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HResult = -2146233088,
                            ImageUrl = "/images/毛细.png",
                            IsInStock = false,
                            LongDescription = "真的好细好细好细啊",
                            Name = "毛细",
                            Price = 12m,
                            ShortDescription = "如发丝般细"
                        },
                        new
                        {
                            Id = 2,
                            HResult = -2146233088,
                            ImageUrl = "/images/细.png",
                            IsInStock = false,
                            LongDescription = "还是挺细的",
                            Name = "细",
                            Price = 10m,
                            ShortDescription = "普通细"
                        },
                        new
                        {
                            Id = 3,
                            HResult = -2146233088,
                            ImageUrl = "/images/三细.png",
                            IsInStock = false,
                            LongDescription = "比细的粗点，比二细细点",
                            Name = "三细",
                            Price = 11m,
                            ShortDescription = "有点粗了"
                        },
                        new
                        {
                            Id = 4,
                            HResult = -2146233088,
                            ImageUrl = "/images/二细.png",
                            IsInStock = false,
                            LongDescription = "粗的才有嚼劲",
                            Name = "二细",
                            Price = 10m,
                            ShortDescription = "粗了"
                        },
                        new
                        {
                            Id = 5,
                            HResult = -2146233088,
                            ImageUrl = "/images/二柱子.png",
                            IsInStock = false,
                            LongDescription = "粗得快咬不动了",
                            Name = "二柱子",
                            Price = 11m,
                            ShortDescription = "太粗了"
                        },
                        new
                        {
                            Id = 6,
                            HResult = -2146233088,
                            ImageUrl = "/images/韭叶子.png",
                            IsInStock = false,
                            LongDescription = "韭猜叶一样宽",
                            Name = "韭叶子",
                            Price = 12m,
                            ShortDescription = "扁的"
                        },
                        new
                        {
                            Id = 7,
                            HResult = -2146233088,
                            ImageUrl = "/images/薄宽.png",
                            IsInStock = false,
                            LongDescription = "比韭叶宽一点，比大宽窄一点",
                            Name = "薄宽",
                            Price = 11m,
                            ShortDescription = "开始宽了"
                        },
                        new
                        {
                            Id = 8,
                            HResult = -2146233088,
                            ImageUrl = "/images/大宽.png",
                            IsInStock = false,
                            LongDescription = "比嘴还宽了",
                            Name = "大宽",
                            Price = 10m,
                            ShortDescription = "裤带面"
                        },
                        new
                        {
                            Id = 9,
                            HResult = -2146233088,
                            ImageUrl = "/images/荞麦棱子.png",
                            IsInStock = false,
                            LongDescription = "好像知道师傅怎么拉出来的",
                            Name = "荞麦棱子",
                            Price = 15m,
                            ShortDescription = "立方体的"
                        },
                        new
                        {
                            Id = 10,
                            HResult = -2146233088,
                            ImageUrl = "/images/一窝丝.png",
                            IsInStock = false,
                            LongDescription = "我也没吃过",
                            Name = "一窝丝",
                            Price = 15m,
                            ShortDescription = "这是啥"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using AnuitexTraining.DataAccessLayer.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnuitexTraining.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dc0d8920-1d35-46be-8fc6-174da8c3470a",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            FirstName = "Vladislav",
                            LastName = "Goncharuk",
                            LockoutEnabled = false,
                            PhoneNumber = "+380935538212",
                            PhoneNumberConfirmed = true,
                            TwoFactorEnabled = false,
                            UserName = "vladiator"
                        },
                        new
                        {
                            Id = 2L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34302700-6e80-4a40-88bd-fe655a9d6f31",
                            Email = "user@example.com",
                            EmailConfirmed = true,
                            FirstName = "Valerij",
                            LastName = "Jmishenko",
                            LockoutEnabled = false,
                            PhoneNumber = "+380503487621",
                            PhoneNumberConfirmed = true,
                            TwoFactorEnabled = false,
                            UserName = "valerajmih"
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 925, DateTimeKind.Local).AddTicks(7109),
                            IsRemoved = false,
                            Name = "Jmih V.A."
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(2632),
                            IsRemoved = false,
                            Name = "Drozdov G.L."
                        },
                        new
                        {
                            Id = 3L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(2682),
                            IsRemoved = false,
                            Name = "Teodorov V.V."
                        },
                        new
                        {
                            Id = 4L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(2687),
                            IsRemoved = false,
                            Name = "Kovalenko S.A."
                        },
                        new
                        {
                            Id = 5L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(2690),
                            IsRemoved = false,
                            Name = "Gorin O.V."
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.AuthorInPrintingEdition", b =>
                {
                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("PrintingEditionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("AuthorId", "PrintingEditionId");

                    b.HasIndex("PrintingEditionId");

                    b.ToTable("AuthorInPrintingEditions");

                    b.HasData(
                        new
                        {
                            AuthorId = 1L,
                            PrintingEditionId = 1L,
                            Date = new DateTime(2008, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = 2L,
                            PrintingEditionId = 2L,
                            Date = new DateTime(2010, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = 3L,
                            PrintingEditionId = 3L,
                            Date = new DateTime(2016, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = 4L,
                            PrintingEditionId = 4L,
                            Date = new DateTime(2002, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = 5L,
                            PrintingEditionId = 5L,
                            Date = new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<long>("PaymentId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 929, DateTimeKind.Local).AddTicks(5337),
                            Date = new DateTime(2020, 8, 14, 12, 11, 51, 929, DateTimeKind.Local).AddTicks(5354),
                            Description = "Nothing special",
                            IsRemoved = false,
                            PaymentId = 1L,
                            Status = 1,
                            UserId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 929, DateTimeKind.Local).AddTicks(7002),
                            Date = new DateTime(2020, 8, 14, 12, 11, 51, 929, DateTimeKind.Local).AddTicks(7016),
                            Description = "And here is nothing special",
                            IsRemoved = false,
                            PaymentId = 2L,
                            Status = 2,
                            UserId = 2L
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<double>("Count")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("PrintingEditionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PrintingEditionId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 2,
                            Count = 2000.0,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 929, DateTimeKind.Local).AddTicks(7456),
                            Currency = 6,
                            IsRemoved = false,
                            OrderId = 1L,
                            PrintingEditionId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 7,
                            Count = 7000.0,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 930, DateTimeKind.Local).AddTicks(425),
                            Currency = 6,
                            IsRemoved = false,
                            OrderId = 2L,
                            PrintingEditionId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 4,
                            Count = 80.0,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 930, DateTimeKind.Local).AddTicks(487),
                            Currency = 2,
                            IsRemoved = false,
                            OrderId = 1L,
                            PrintingEditionId = 2L
                        },
                        new
                        {
                            Id = 4L,
                            Amount = 10,
                            Count = 500.0,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 930, DateTimeKind.Local).AddTicks(492),
                            Currency = 2,
                            IsRemoved = false,
                            OrderId = 1L,
                            PrintingEditionId = 4L
                        },
                        new
                        {
                            Id = 5L,
                            Amount = 6,
                            Count = 420.0,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 930, DateTimeKind.Local).AddTicks(495),
                            Currency = 1,
                            IsRemoved = false,
                            OrderId = 1L,
                            PrintingEditionId = 5L
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<long>("TransactionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(6746),
                            IsRemoved = false,
                            TransactionId = 21847238958L
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(7215),
                            IsRemoved = false,
                            TransactionId = 57976548678L
                        });
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.PrintingEdition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PrintingEditions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(3180),
                            Currency = 6,
                            Description = "Neurotechnologies",
                            IsRemoved = false,
                            Price = 1000.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(4527),
                            Currency = 2,
                            Description = "C# Starter",
                            IsRemoved = false,
                            Price = 20.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 3L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(4619),
                            Currency = 1,
                            Description = "ASP.NET MVC 5",
                            IsRemoved = false,
                            Price = 100.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 4L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(4624),
                            Currency = 2,
                            Description = "How it works",
                            IsRemoved = false,
                            Price = 50.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreationDate = new DateTime(2020, 8, 14, 12, 11, 51, 928, DateTimeKind.Local).AddTicks(4627),
                            Currency = 1,
                            Description = "Angular 9",
                            IsRemoved = false,
                            Price = 70.0,
                            Type = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "dab3248a-d084-46cb-8a17-d5bcdcb80746",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            ConcurrencyStamp = "5ec8f356-fc36-4eff-898e-2cb3d173a306",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            UserId = 2L,
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.AuthorInPrintingEdition", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.PrintingEdition", "PrintingEdition")
                        .WithMany()
                        .HasForeignKey("PrintingEditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.Order", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.OrderItem", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.PrintingEdition", "PrintingEdition")
                        .WithMany()
                        .HasForeignKey("PrintingEditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("AnuitexTraining.DataAccessLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

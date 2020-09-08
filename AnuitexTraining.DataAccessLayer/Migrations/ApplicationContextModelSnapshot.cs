﻿// <auto-generated />

using System;
using AnuitexTraining.DataAccessLayer.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AnuitexTraining.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    internal class ApplicationContextModelSnapshot : ModelSnapshot
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
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsBlocked")
                    .HasColumnType("bit");

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
                        ConcurrencyStamp = "beae8a3d-6016-4c46-b746-8a301bbba2fa",
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(1610),
                        Email = "vladiator@xitroo.com",
                        EmailConfirmed = true,
                        FirstName = "Vladislav",
                        IsBlocked = false,
                        LastName = "Goncharuk",
                        LockoutEnabled = false,
                        NormalizedEmail = "VLADIATOR@XITROO.COM",
                        NormalizedUserName = "VLADIATOR",
                        PasswordHash =
                            "AQAAAAEAACcQAAAAEKHk3sTABbsMTgCaH81KcsHXbNSfveaBeQYBbLM8tOS5EKut5YWZcDbh7uCXUARPmQ==",
                        PhoneNumberConfirmed = false,
                        SecurityStamp = "UD6OIMX72OWACSZNP6QXRDB6AK5UAQWK",
                        TwoFactorEnabled = false,
                        UserName = "vladiator"
                    },
                    new
                    {
                        Id = 2L,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "4734878e-90f7-4970-88c1-baf58e73f94f",
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(1704),
                        Email = "valera@xitroo.com",
                        EmailConfirmed = true,
                        FirstName = "Valerij",
                        IsBlocked = false,
                        LastName = "Jmishenko",
                        LockoutEnabled = false,
                        NormalizedEmail = "VALERA@XITROO.COM",
                        NormalizedUserName = "VALERAJMIH",
                        PasswordHash =
                            "AQAAAAEAACcQAAAAELXM6ETOnIrNLqiksYqOZZ1tKbsO/TLM1hKXn9FCvapFZEcWYLcYxvK9rxxxDSQCSA==",
                        PhoneNumberConfirmed = false,
                        SecurityStamp = "P5IWCILRLNALOGOW77G2WLTUREFC7BZG",
                        TwoFactorEnabled = false,
                        UserName = "valerajmih"
                    });
            });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.Author", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(6816),
                        IsRemoved = false,
                        Name = "Jmih V.A."
                    },
                    new
                    {
                        Id = 2L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(7309),
                        IsRemoved = false,
                        Name = "Drozdov G.L."
                    },
                    new
                    {
                        Id = 3L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(7317),
                        IsRemoved = false,
                        Name = "Teodorov V.V."
                    },
                    new
                    {
                        Id = 4L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(7319),
                        IsRemoved = false,
                        Name = "Kovalenko S.A."
                    },
                    new
                    {
                        Id = 5L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(7321),
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
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(6603),
                        Date = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(6607),
                        Description = "Nothing special",
                        IsRemoved = false,
                        PaymentId = 1L,
                        Status = 1,
                        UserId = 2L
                    },
                    new
                    {
                        Id = 2L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(9263),
                        Date = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(9264),
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
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<double>("Amount")
                    .HasColumnType("float");

                b.Property<int>("Count")
                    .HasColumnType("int");

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
                        Amount = 2000.0,
                        Count = 2,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 312, DateTimeKind.Utc).AddTicks(9783),
                        Currency = 6,
                        IsRemoved = false,
                        OrderId = 1L,
                        PrintingEditionId = 1L
                    },
                    new
                    {
                        Id = 2L,
                        Amount = 7000.0,
                        Count = 7,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 313, DateTimeKind.Utc).AddTicks(2879),
                        Currency = 6,
                        IsRemoved = false,
                        OrderId = 2L,
                        PrintingEditionId = 1L
                    },
                    new
                    {
                        Id = 3L,
                        Amount = 80.0,
                        Count = 4,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 313, DateTimeKind.Utc).AddTicks(2962),
                        Currency = 2,
                        IsRemoved = false,
                        OrderId = 1L,
                        PrintingEditionId = 2L
                    },
                    new
                    {
                        Id = 4L,
                        Amount = 500.0,
                        Count = 10,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 313, DateTimeKind.Utc).AddTicks(2965),
                        Currency = 2,
                        IsRemoved = false,
                        OrderId = 1L,
                        PrintingEditionId = 4L
                    },
                    new
                    {
                        Id = 5L,
                        Amount = 420.0,
                        Count = 6,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 313, DateTimeKind.Utc).AddTicks(2967),
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
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsRemoved")
                    .HasColumnType("bit");

                b.Property<string>("TransactionId")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Payments");

                b.HasData(
                    new
                    {
                        Id = 1L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(4094),
                        IsRemoved = false,
                        TransactionId = "21847238958"
                    },
                    new
                    {
                        Id = 2L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(4543),
                        IsRemoved = false,
                        TransactionId = ""
                    });
            });

            modelBuilder.Entity("AnuitexTraining.DataAccessLayer.Entities.PrintingEdition", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 310, DateTimeKind.Utc).AddTicks(7734),
                        Currency = 6,
                        Description = "Neurotechnologies",
                        IsRemoved = false,
                        Price = 1000.0,
                        Title = "Neurotechnologies",
                        Type = 3
                    },
                    new
                    {
                        Id = 2L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(1672),
                        Currency = 2,
                        Description = "C# Starter",
                        IsRemoved = false,
                        Price = 20.0,
                        Title = "C# Starter",
                        Type = 1
                    },
                    new
                    {
                        Id = 3L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(1741),
                        Currency = 1,
                        Description = "ASP.NET MVC 5",
                        IsRemoved = false,
                        Price = 100.0,
                        Title = "ASP.NET MVC 5",
                        Type = 1
                    },
                    new
                    {
                        Id = 4L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(1744),
                        Currency = 2,
                        Description = "How it works",
                        IsRemoved = false,
                        Price = 50.0,
                        Title = "How it works",
                        Type = 2
                    },
                    new
                    {
                        Id = 5L,
                        CreationDate = new DateTime(2020, 9, 2, 14, 26, 47, 311, DateTimeKind.Utc).AddTicks(1749),
                        Currency = 1,
                        Description = "Angular 9",
                        IsRemoved = false,
                        Price = 70.0,
                        Title = "Angular 9",
                        Type = 1
                    });
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
                        ConcurrencyStamp = "f91f0bcb-0397-47c2-8fe5-0f30591adae8",
                        Name = "Admin"
                    },
                    new
                    {
                        Id = 2L,
                        ConcurrencyStamp = "8b2c86df-17b1-4dee-a9fa-019d51d4246d",
                        Name = "Client"
                    });
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

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
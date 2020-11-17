﻿// <auto-generated />
using System;
using MbmStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MbmStore.Migrations
{
    [DbContext(typeof(MbmStoreContext))]
    [Migration("20201115124155_ProductCreatedDateAttribute")]
    partial class ProductCreatedDateAttribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MbmStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Irisdahlsvej 32",
                            Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Århus N",
                            Firstname = "Tina",
                            Lastname = "Petterson",
                            Zip = "8200"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Solsikkevej 32",
                            Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Århus C",
                            Firstname = "Thomas",
                            Lastname = "Larsson",
                            Zip = "8000"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            InvoiceId = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            InvoiceId = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2018, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            InvoiceId = 1,
                            ProductId = 7,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 2,
                            InvoiceId = 1,
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 3,
                            InvoiceId = 2,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 4,
                            InvoiceId = 2,
                            ProductId = 3,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("MbmStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Composer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int?>("MusicCDProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.HasIndex("MusicCDProductId");

                    b.ToTable("Track");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 4, 20, 0),
                            Title = "Come Together"
                        },
                        new
                        {
                            TrackId = 2,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 3, 3, 0),
                            Title = "Something"
                        },
                        new
                        {
                            TrackId = 3,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 3, 29, 0),
                            Title = "Maxwell's Silver Hammer"
                        },
                        new
                        {
                            TrackId = 4,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 3, 26, 0),
                            Title = "Oh! Darling"
                        },
                        new
                        {
                            TrackId = 5,
                            Composer = "Starkey",
                            Length = new TimeSpan(0, 0, 2, 51, 0),
                            Title = "Octopus's Garden"
                        },
                        new
                        {
                            TrackId = 6,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 7, 47, 0),
                            Title = "I Want You (She's So Heavy)"
                        },
                        new
                        {
                            TrackId = 7,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 3, 5, 0),
                            Title = "Here Comes The Sun"
                        },
                        new
                        {
                            TrackId = 8,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 45, 0),
                            Title = "Because"
                        },
                        new
                        {
                            TrackId = 9,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 4, 2, 0),
                            Title = "You Never Give Me Your Money"
                        },
                        new
                        {
                            TrackId = 10,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 26, 0),
                            Title = "Sun King"
                        },
                        new
                        {
                            TrackId = 11,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 6, 0),
                            Title = "Mean Mr. Mustard"
                        },
                        new
                        {
                            TrackId = 12,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 12, 0),
                            Title = "Polythene Pam"
                        },
                        new
                        {
                            TrackId = 13,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 57, 0),
                            Title = "She Came In Through The Bathroom Window"
                        },
                        new
                        {
                            TrackId = 14,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 31, 0),
                            Title = "Golden Slumbers"
                        },
                        new
                        {
                            TrackId = 15,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 36, 0),
                            Title = "Carry That Weight"
                        },
                        new
                        {
                            TrackId = 16,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 19, 0),
                            Title = "The End"
                        },
                        new
                        {
                            TrackId = 17,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 0, 23, 0),
                            Title = "Her Majesty"
                        },
                        new
                        {
                            TrackId = 18,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            Title = "Taxman"
                        },
                        new
                        {
                            TrackId = 19,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 6, 0),
                            Title = "Eleanor Rigby"
                        },
                        new
                        {
                            TrackId = 20,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 3, 0, 0),
                            Title = "I'm Only Sleeping"
                        },
                        new
                        {
                            TrackId = 21,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 2, 59, 0),
                            Title = "Love You To"
                        },
                        new
                        {
                            TrackId = 22,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 2, 23, 0),
                            Title = "Here, There And Everywhere"
                        },
                        new
                        {
                            TrackId = 23,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 38, 0),
                            Title = "Yellow Submarine"
                        },
                        new
                        {
                            TrackId = 24,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 36, 0),
                            Title = "She Said She Said"
                        },
                        new
                        {
                            TrackId = 25,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 9, 0),
                            Title = "Good Day Sunshine"
                        },
                        new
                        {
                            TrackId = 26,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 0, 0),
                            Title = "And Your Bird Can Sing"
                        },
                        new
                        {
                            TrackId = 27,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 59, 0),
                            Title = "For No One"
                        },
                        new
                        {
                            TrackId = 28,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 1, 14, 0),
                            Title = "Doctor Robert"
                        },
                        new
                        {
                            TrackId = 29,
                            Composer = "Harrison",
                            Length = new TimeSpan(0, 0, 2, 27, 0),
                            Title = "I Want To Tell You"
                        },
                        new
                        {
                            TrackId = 30,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 2, 29, 0),
                            Title = "Got To Get You Into My Life"
                        },
                        new
                        {
                            TrackId = 31,
                            Composer = "Lennon, McCartney",
                            Length = new TimeSpan(0, 0, 3, 1, 0),
                            Title = "Tomorrow Newer Knows"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Book", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Published")
                        .HasColumnType("smallint");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Book");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Book",
                            ImageUrl = "A_Hard_Days_Write.jpg",
                            Price = 150.00m,
                            Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ",
                            Author = "Steve Turner",
                            ISBN = "978-0060844097",
                            Published = (short)2005,
                            Publisher = "It Books"
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Book",
                            ImageUrl = "The Making of Sgt. Pepper.jpg",
                            Price = 180.00m,
                            Title = "With a Little Help from My Friends: The Making of Sgt. Pepper",
                            Author = "Georg Martin",
                            ISBN = "0316547832",
                            Published = (short)1995,
                            Publisher = "Little Brown & Co"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Movie", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Released")
                        .HasColumnType("smallint");

                    b.HasDiscriminator().HasValue("Movie");

                    b.HasData(
                        new
                        {
                            ProductId = 5,
                            Category = "Movie",
                            ImageUrl = "junglebook.jpg",
                            Price = 160.50m,
                            Title = "Jungle Book",
                            Director = "Jon Favreau",
                            Released = (short)0
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Movie",
                            ImageUrl = "gladiator.jpg",
                            Price = 49.95m,
                            Title = "Gladiator",
                            Director = "Ridley Scott",
                            Released = (short)0
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Movie",
                            ImageUrl = "forrest-gump.jpg",
                            Price = 160.50m,
                            Title = "Forrest Gump",
                            Director = "Robert Zemeckis",
                            Released = (short)0
                        });
                });

            modelBuilder.Entity("MbmStore.Models.MusicCD", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Released")
                        .HasColumnName("MusicCD_Released")
                        .HasColumnType("smallint");

                    b.HasDiscriminator().HasValue("MusicCD");

                    b.HasData(
                        new
                        {
                            ProductId = 3,
                            Category = "Music",
                            ImageUrl = "abbey_road.jpg",
                            Price = 128.00m,
                            Title = "Abbey Road (Remastered)",
                            Artist = "Beatles",
                            Label = "EMI",
                            Released = (short)2009
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Music",
                            ImageUrl = "revolver.jpg",
                            Price = 128.00m,
                            Title = "Revolver (Remastered)",
                            Artist = "The Beatles",
                            Label = "EMI",
                            Released = (short)2009
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.HasOne("MbmStore.Models.Invoice", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MbmStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.HasOne("MbmStore.Models.MusicCD", null)
                        .WithMany("Tracks")
                        .HasForeignKey("MusicCDProductId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PublisherData;

#nullable disable

namespace PublisherData.Migrations
{
    [DbContext(typeof(PubContext))]
    [Migration("20240625215203_AANDCSeed")]
    partial class AANDCSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArtistCover", b =>
                {
                    b.Property<int>("ArtistsArtistId")
                        .HasColumnType("int");

                    b.Property<int>("CoversCoverId")
                        .HasColumnType("int");

                    b.HasKey("ArtistsArtistId", "CoversCoverId");

                    b.HasIndex("CoversCoverId");

                    b.ToTable("ArtistCover");
                });

            modelBuilder.Entity("PublisherDomain.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            FirstName = "Pablo",
                            LastName = "Picasso"
                        },
                        new
                        {
                            ArtistId = 2,
                            FirstName = "Dee",
                            LastName = "Bell"
                        },
                        new
                        {
                            ArtistId = 3,
                            FirstName = "Katharine",
                            LastName = "Kuharic"
                        });
                });

            modelBuilder.Entity("PublisherDomain.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Josie",
                            LastName = "Newf"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Jill",
                            LastName = "Hill"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Jack",
                            LastName = "Black"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Jen",
                            LastName = "Ken"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "Jennifer",
                            LastName = "Kensington"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Sam",
                            LastName = "Rami"
                        });
                });

            modelBuilder.Entity("PublisherDomain.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("PublishDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            BasePrice = 19.99m,
                            PublishDate = new DateOnly(2021, 10, 12),
                            Title = "The Book of Josie"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 1,
                            BasePrice = 29.99m,
                            PublishDate = new DateOnly(2022, 10, 12),
                            Title = "The Book of Josie 2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            BasePrice = 19.99m,
                            PublishDate = new DateOnly(2021, 10, 12),
                            Title = "The Book of Jill"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 2,
                            BasePrice = 29.99m,
                            PublishDate = new DateOnly(2022, 10, 12),
                            Title = "The Book of Jill 2"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 3,
                            BasePrice = 19.99m,
                            PublishDate = new DateOnly(2021, 10, 12),
                            Title = "The Book of Jack"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 3,
                            BasePrice = 29.99m,
                            PublishDate = new DateOnly(2022, 10, 12),
                            Title = "The Book of Jack 2"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 6,
                            BasePrice = 29.99m,
                            PublishDate = new DateOnly(2022, 10, 12),
                            Title = "The Book of Sam"
                        });
                });

            modelBuilder.Entity("PublisherDomain.Cover", b =>
                {
                    b.Property<int>("CoverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoverId"));

                    b.Property<string>("DesignIdeas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DigitalOnly")
                        .HasColumnType("bit");

                    b.HasKey("CoverId");

                    b.ToTable("Covers");

                    b.HasData(
                        new
                        {
                            CoverId = 1,
                            DesignIdeas = "How about a left hand in the dark?",
                            DigitalOnly = false
                        },
                        new
                        {
                            CoverId = 2,
                            DesignIdeas = "Should we put a clock?",
                            DigitalOnly = true
                        },
                        new
                        {
                            CoverId = 3,
                            DesignIdeas = "A big ear in the clouds?",
                            DigitalOnly = false
                        });
                });

            modelBuilder.Entity("ArtistCover", b =>
                {
                    b.HasOne("PublisherDomain.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PublisherDomain.Cover", null)
                        .WithMany()
                        .HasForeignKey("CoversCoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PublisherDomain.Book", b =>
                {
                    b.HasOne("PublisherDomain.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("PublisherDomain.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

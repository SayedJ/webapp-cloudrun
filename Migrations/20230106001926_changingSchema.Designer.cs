﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapp_cloudrun.Context;

#nullable disable

namespace webappcloudrun.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20230106001926_changingSchema")]
    partial class changingSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("main")
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapp_cloudrun.Models.Director", b =>
                {
                    b.Property<int?>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.ToTable("directors", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.ImageUrl", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<int?>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.HasKey("ImageId");

                    b.ToTable("imageUrl", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.Movie", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<long?>("Year")
                        .HasColumnType("bigint")
                        .HasColumnName("year");

                    b.ToTable("movies", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.MyFavMovies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int>("userId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("FavMovies", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.Person", b =>
                {
                    b.Property<long?>("Birth")
                        .HasColumnType("bigint")
                        .HasColumnName("birth");

                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.ToTable("people", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.Rating", b =>
                {
                    b.Property<int?>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<float?>("Rating1")
                        .HasColumnType("real")
                        .HasColumnName("rating");

                    b.Property<int?>("Votes")
                        .HasColumnType("int")
                        .HasColumnName("votes");

                    b.ToTable("ratings", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.Star", b =>
                {
                    b.Property<int?>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.ToTable("stars", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("FilmUser", "main");
                });

            modelBuilder.Entity("webapp_cloudrun.Models.UserLogin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("confirm_password");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("FilmAddict", "main");
                });
#pragma warning restore 612, 618
        }
    }
}

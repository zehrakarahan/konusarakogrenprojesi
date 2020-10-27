﻿// <auto-generated />
using KonusarakOgren.WebUI.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KonusarakOgren.WebUI.Migrations
{
    [DbContext(typeof(KonusarakOgrenContext))]
    partial class KonusarakOgrenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("KonusarakOgren.WebUI.Models.Context.ExamQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aoption")
                        .HasColumnType("TEXT");

                    b.Property<string>("Boption")
                        .HasColumnType("TEXT");

                    b.Property<string>("Coption")
                        .HasColumnType("TEXT");

                    b.Property<string>("Doption")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .HasColumnType("TEXT");

                    b.Property<string>("Response")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("KonusarakOgren.WebUI.Models.Context.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

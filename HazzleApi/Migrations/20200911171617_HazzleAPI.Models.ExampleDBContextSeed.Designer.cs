﻿// <auto-generated />
using HazzleApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HazzleApi.Migrations
{
    [DbContext(typeof(ExampleDBContext))]
    [Migration("20200911171617_HazzleAPI.Models.ExampleDBContextSeed")]
    partial class HazzleAPIModelsExampleDBContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HazzleApi.Models.ExampleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 33,
                            JobTitle = "Master of None",
                            Name = "Jamppa Javonen",
                            Username = "MoN"
                        },
                        new
                        {
                            Id = 2,
                            Age = 33,
                            JobTitle = "Master of None",
                            Name = "Jamppa Javonen",
                            Username = "MoN"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

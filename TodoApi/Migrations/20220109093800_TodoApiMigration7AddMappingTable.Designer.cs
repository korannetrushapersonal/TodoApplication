﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.EntityFramework;

namespace TodoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220109093800_TodoApiMigration7AddMappingTable")]
    partial class TodoApiMigration7AddMappingTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApi.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TodoApi.Entities.PersonItemMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemIdId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemIdId");

                    b.HasIndex("PersonIdId");

                    b.ToTable("PersonItemMappings");
                });

            modelBuilder.Entity("TodoApi.Entities.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Please send the work email to Mark",
                            Title = "Send Email to Mark"
                        });
                });

            modelBuilder.Entity("TodoApi.Entities.PersonItemMapping", b =>
                {
                    b.HasOne("TodoApi.Entities.Person", "ItemId")
                        .WithMany()
                        .HasForeignKey("ItemIdId");

                    b.HasOne("TodoApi.Entities.TodoItem", "PersonId")
                        .WithMany()
                        .HasForeignKey("PersonIdId");
                });
#pragma warning restore 612, 618
        }
    }
}

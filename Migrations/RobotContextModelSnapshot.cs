﻿// <auto-generated />
using System;
using BlazorServerTestIis.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerTestIis.Migrations
{
    [DbContext(typeof(RobotContext))]
    partial class RobotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorServerTestIis.Domain.CyberBrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("CyberQi")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CyberBrains");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Cost = 567,
                            CyberQi = 120,
                            Label = "SpeedResponseAlgebra-6700"
                        },
                        new
                        {
                            Id = 12,
                            Cost = 845,
                            CyberQi = 132,
                            Label = "Alpha-One-77TT"
                        },
                        new
                        {
                            Id = 13,
                            Cost = 1234,
                            CyberQi = 160,
                            Label = "Razor-flight-500"
                        },
                        new
                        {
                            Id = 14,
                            Cost = 1409,
                            CyberQi = 205,
                            Label = "SRAlgebra2-9900"
                        },
                        new
                        {
                            Id = 15,
                            Cost = 7172,
                            CyberQi = 320,
                            Label = "Futuratron-tronic-ct56"
                        });
                });

            modelBuilder.Entity("BlazorServerTestIis.Domain.Robot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CyberBrainId")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CyberBrainId");

                    b.ToTable("Robots");
                });

            modelBuilder.Entity("BlazorServerTestIis.Domain.Robot", b =>
                {
                    b.HasOne("BlazorServerTestIis.Domain.CyberBrain", "CyberBrain")
                        .WithMany()
                        .HasForeignKey("CyberBrainId");

                    b.Navigation("CyberBrain");
                });
#pragma warning restore 612, 618
        }
    }
}

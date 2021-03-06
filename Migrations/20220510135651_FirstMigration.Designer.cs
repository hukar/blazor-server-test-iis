// <auto-generated />
using System;
using BlazorServerTestIis.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerTestIis.Migrations
{
    [DbContext(typeof(RobotContext))]
    [Migration("20220510135651_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cyberQi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CyberBrains");
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

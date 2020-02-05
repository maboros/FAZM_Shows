﻿// <auto-generated />
using FAZM_Shows.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAZM_Shows.Migrations
{
    [DbContext(typeof(FAZM_ShowsContext))]
    partial class FAZM_ShowsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAZM_Shows.Models.Show.Show", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("date")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("section")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("id");

                    b.ToTable("Show");
                });
#pragma warning restore 612, 618
        }
    }
}

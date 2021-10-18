﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScholarlySummaries.Pages;

namespace ScholarlySummaries.Migrations
{
    [DbContext(typeof(PageContext))]
    partial class PageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScholarlySummaries.Pages.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSegment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Page");
                });

            modelBuilder.Entity("ScholarlySummaries.Pages.StartPage", b =>
                {
                    b.HasBaseType("ScholarlySummaries.Pages.Page");

                    b.Property<string>("Blocks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeroHeading")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("StartPage");
                });
#pragma warning restore 612, 618
        }
    }
}
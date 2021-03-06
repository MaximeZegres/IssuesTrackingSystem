﻿// <auto-generated />
using System;
using IssuesTrackingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IssuesTrackingSystem.Migrations
{
    [DbContext(typeof(IssueContext))]
    partial class IssueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IssuesTrackingSystem.Models.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsComplete");

                    b.Property<int>("Priority");

                    b.Property<string>("Title");

                    b.Property<string>("UserPC");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}

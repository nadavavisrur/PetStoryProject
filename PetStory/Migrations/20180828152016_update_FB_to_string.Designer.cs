﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetStory.Models;

namespace PetStory.Migrations
{
    [DbContext(typeof(PetStoryContext))]
    [Migration("20180828152016_update_FB_to_string")]
    partial class update_FB_to_string
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetStory.Models.Owner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("birthday");

                    b.Property<string>("city");

                    b.Property<string>("facebookID");

                    b.Property<string>("image");

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("PetStory.Models.Park", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<int>("likes");

                    b.Property<string>("name");

                    b.Property<int>("zipCode");

                    b.HasKey("ID");

                    b.ToTable("Park");
                });

            modelBuilder.Entity("PetStory.Models.Pet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("age");

                    b.Property<string>("animalType");

                    b.Property<string>("image");

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}

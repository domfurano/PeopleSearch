﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PeopleSearch.Models;

namespace PeopleSearch.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20170208044612_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("PeopleSearch.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<string>("Interests");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.HasKey("ID");

                    b.ToTable("People");
                });
        }
    }
}

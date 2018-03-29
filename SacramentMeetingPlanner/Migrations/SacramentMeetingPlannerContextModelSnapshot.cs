﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SacramentMeetingPlanner.Models;
using System;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Planner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Benediction");

                    b.Property<string>("ClosingHymn");

                    b.Property<string>("Conducting");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Invocation");

                    b.Property<string>("OpeningHymn");

                    b.Property<string>("Presiding");

                    b.Property<string>("SacramentHymn");

                    b.Property<string>("SacramentPrayer");

                    b.Property<string>("SpeakerOne");

                    b.Property<string>("SpeakerThree");

                    b.Property<string>("SpeakerTwo");

                    b.Property<string>("TopicOne");

                    b.Property<string>("TopicThree");

                    b.Property<string>("TopicTwo");

                    b.HasKey("ID");

                    b.ToTable("Planner");
                });
#pragma warning restore 612, 618
        }
    }
}
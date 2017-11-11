﻿// <auto-generated />
using MessageBoardBackend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MessageBoardBackend.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MessageBoardBackend.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Owner");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MessageBoardBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MessageBoardBackend.MyModels.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("building");

                    b.Property<string>("date_closed");

                    b.Property<string>("date_completed");

                    b.Property<string>("date_dispatched");

                    b.Property<string>("date_due");

                    b.Property<string>("date_received");

                    b.Property<string>("date_responded");

                    b.Property<string>("floor");

                    b.Property<int>("priority");

                    b.Property<bool>("proactive");

                    b.Property<string>("property");

                    b.Property<string>("request_type");

                    b.Property<string>("schedule_id");

                    b.Property<string>("status");

                    b.Property<string>("suite");

                    b.Property<string>("tenant");

                    b.Property<string>("trade");

                    b.Property<string>("wo_description");

                    b.Property<string>("wo_detail");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}

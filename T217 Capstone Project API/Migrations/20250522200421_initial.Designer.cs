﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T217_Capstone_Project_API;

#nullable disable

namespace T217_Capstone_Project_API.Migrations
{
    [DbContext(typeof(StakeholderRisksContext))]
    [Migration("20250522200421_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EditDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.ProjectUser", b =>
                {
                    b.Property<int>("ProjectUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProjectUserID"));

                    b.Property<bool>("CanEdit")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanRead")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanWrite")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ProjectUserID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.Stakeholder", b =>
                {
                    b.Property<int>("StakeholderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StakeholderID"));

                    b.Property<int>("BlobID")
                        .HasColumnType("int");

                    b.Property<string>("CaFI")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EditDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("StakeholderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StakeholderID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Stakeholders");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.EnvironmentalRisks", b =>
                {
                    b.Property<int>("EnvironmentalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EnvironmentalRiskID"));

                    b.Property<int>("ChangeVolume")
                        .HasColumnType("int");

                    b.Property<int>("Culture")
                        .HasColumnType("int");

                    b.Property<int>("Industry")
                        .HasColumnType("int");

                    b.Property<int>("Infrastructure")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("OfficePolitics")
                        .HasColumnType("int");

                    b.Property<int>("StakeholderID")
                        .HasColumnType("int");

                    b.HasKey("EnvironmentalRiskID");

                    b.HasIndex("StakeholderID");

                    b.ToTable("EnvironmentalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.InterpersonalRisks", b =>
                {
                    b.Property<int>("InterpersonalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("InterpersonalRiskID"));

                    b.Property<int>("Communication")
                        .HasColumnType("int");

                    b.Property<int>("Respect")
                        .HasColumnType("int");

                    b.Property<int>("SharingSuccess")
                        .HasColumnType("int");

                    b.Property<int>("StakeholderID")
                        .HasColumnType("int");

                    b.Property<int>("Support")
                        .HasColumnType("int");

                    b.Property<int>("SupportiveManagement")
                        .HasColumnType("int");

                    b.Property<int>("Trust")
                        .HasColumnType("int");

                    b.HasKey("InterpersonalRiskID");

                    b.HasIndex("StakeholderID");

                    b.ToTable("InterpersonalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.PersonalRisks", b =>
                {
                    b.Property<int>("PersonalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PersonalRiskID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("EducationTraining")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("History")
                        .HasColumnType("int");

                    b.Property<int>("Impact")
                        .HasColumnType("int");

                    b.Property<int>("Interest")
                        .HasColumnType("int");

                    b.Property<int>("Involvement")
                        .HasColumnType("int");

                    b.Property<int>("Kpi")
                        .HasColumnType("int");

                    b.Property<int>("Personalities")
                        .HasColumnType("int");

                    b.Property<int>("PriorRole")
                        .HasColumnType("int");

                    b.Property<int>("RoleType")
                        .HasColumnType("int");

                    b.Property<int>("ServiceLength")
                        .HasColumnType("int");

                    b.Property<int>("StakeholderID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Workload")
                        .HasColumnType("int");

                    b.HasKey("PersonalRiskID");

                    b.HasIndex("StakeholderID");

                    b.ToTable("PersonalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.ProjectRisks", b =>
                {
                    b.Property<int>("ProjectRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProjectRiskID"));

                    b.Property<int>("CulturalAlignment")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectGoals")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectLength")
                        .HasColumnType("int");

                    b.Property<int>("Resourcing")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfChange")
                        .HasColumnType("int");

                    b.HasKey("ProjectRiskID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.ProjectUser", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("T217_Capstone_Project_API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.Stakeholder", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.EnvironmentalRisks", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Stakeholder", "Stakeholder")
                        .WithMany()
                        .HasForeignKey("StakeholderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stakeholder");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.InterpersonalRisks", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Stakeholder", "Stakeholder")
                        .WithMany()
                        .HasForeignKey("StakeholderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stakeholder");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.PersonalRisks", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Stakeholder", "Stakeholder")
                        .WithMany()
                        .HasForeignKey("StakeholderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stakeholder");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.ProjectRisks", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}

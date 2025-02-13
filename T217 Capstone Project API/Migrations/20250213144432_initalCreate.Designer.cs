﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T217_Capstone_Project_API;

#nullable disable

namespace T217_Capstone_Project_API.Migrations
{
    [DbContext(typeof(StakeholderRisksContext))]
    [Migration("20250213144432_initalCreate")]
    partial class initalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EditDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.ProjectUser", b =>
                {
                    b.Property<int>("ProjectUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanEdit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanRead")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanWrite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectUserID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.Stakeholder", b =>
                {
                    b.Property<int>("StakeholderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CaFI")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EditDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("StakeholderGroupID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StakeholderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TestData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StakeholderID");

                    b.HasIndex("StakeholderGroupID");

                    b.ToTable("Stakeholders");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", b =>
                {
                    b.Property<int>("StakeholderGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StakeholderGroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StakeholderGroupID");

                    b.HasIndex("ProjectID");

                    b.ToTable("StakeholderGroups");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.EnvironmentalRisk", b =>
                {
                    b.Property<int>("EnvironmentalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChangeVolume")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Industry")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Infrastructure")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfficePolitics")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StakeholderGroupID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EnvironmentalRiskID");

                    b.HasIndex("StakeholderGroupID");

                    b.ToTable("EnvironmentalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.InterpersonalRisk", b =>
                {
                    b.Property<int>("InterpersonalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Communication")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Respect")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SharingSuccess")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StakeholderGroupID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Support")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SupportiveManagement")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Trust")
                        .HasColumnType("INTEGER");

                    b.HasKey("InterpersonalRiskID");

                    b.HasIndex("StakeholderGroupID");

                    b.ToTable("InterpersonalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.PersonalRisk", b =>
                {
                    b.Property<int>("PersonalRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EducationTraining")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("History")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Impact")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Interest")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Involvement")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kpi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Location")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Personalities")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriorRole")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceLength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StakeholderGroupID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Workload")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonalRiskID");

                    b.HasIndex("StakeholderGroupID");

                    b.ToTable("PersonalRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.ProjectRisk", b =>
                {
                    b.Property<int>("ProjectRiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CulturalAlignment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Culture")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectGoals")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectLength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Resourcing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StakeholderGroupID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeOfChange")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectRiskID");

                    b.HasIndex("StakeholderGroupID");

                    b.ToTable("ProjectRisks");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", "StakeholderGroup")
                        .WithMany()
                        .HasForeignKey("StakeholderGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StakeholderGroup");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.EnvironmentalRisk", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", "StakeholderGroup")
                        .WithMany()
                        .HasForeignKey("StakeholderGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StakeholderGroup");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.InterpersonalRisk", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", "StakeholderGroup")
                        .WithMany()
                        .HasForeignKey("StakeholderGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StakeholderGroup");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.PersonalRisk", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", "StakeholderGroup")
                        .WithMany()
                        .HasForeignKey("StakeholderGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StakeholderGroup");
                });

            modelBuilder.Entity("T217_Capstone_Project_API.Models.Risks.ProjectRisk", b =>
                {
                    b.HasOne("T217_Capstone_Project_API.Models.Projects.StakeholderGroup", "StakeholderGroup")
                        .WithMany()
                        .HasForeignKey("StakeholderGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StakeholderGroup");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using T217_Capstone_Project_API.Models;
using T217_Capstone_Project_API.Models.Projects;
using T217_Capstone_Project_API.Models.Risks;

namespace T217_Capstone_Project_API
{
    public class StakeholderRisksContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        // Project DbSets
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectUser> ProjectUsers { get; set; }

        // Stakeholder DbSets
        public DbSet<StakeholderGroup> StakeholderGroups { get; set; }
        public DbSet<Stakeholder> Stakeholders { get; set; }

        // Risks DbSets
        public DbSet<EnvironmentalRisk> EnvironmentalRisks { get; set; }
        public DbSet<InterpersonalRisk> InterpersonalRisks { get; set; }
        public DbSet<PersonalRisk> PersonalRisks { get; set; }
        public DbSet<ProjectRisk> ProjectRisks { get; set; }

        public StakeholderRisksContext(DbContextOptions options) : base (options) { }

        // For SQLite
        //public string DbPath { get; }

        //public StakeholderRisksContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);           
        //    DbPath = System.IO.Path.Join(path, "stakeholderRisks.db");
        //}

        //// The following configures EF to create a Sqlite database file in the
        //// special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");
    }
}

﻿// <auto-generated />
using System;
using ExpressoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpressoApi.Migrations
{
    [DbContext(typeof(ExpressoDbContext))]
    [Migration("20201113095716_addlangandcertskill")]
    partial class addlangandcertskill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExpressoApi.Models.BusSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Proficiency");

                    b.HasKey("Id");

                    b.ToTable("BusSkill");
                });

            modelBuilder.Entity("ExpressoApi.Models.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Proficiency");

                    b.HasKey("Id");

                    b.ToTable("Certification");
                });

            modelBuilder.Entity("ExpressoApi.Models.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Proficiency");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ExpressoApi.Models.Proficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Proficiency");
                });

            modelBuilder.Entity("ExpressoApi.Models.ProficiencyGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ProficiencyId");

                    b.HasKey("Id");

                    b.HasIndex("ProficiencyId");

                    b.ToTable("ProficiencyGroup");
                });

            modelBuilder.Entity("ExpressoApi.Models.SkillGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("SkillsId");

                    b.HasKey("Id");

                    b.HasIndex("SkillsId");

                    b.ToTable("SkillGroup");
                });

            modelBuilder.Entity("ExpressoApi.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ExpressoApi.Models.TechSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Proficiency");

                    b.HasKey("Id");

                    b.ToTable("TechSkill");
                });

            modelBuilder.Entity("ExpressoApi.Models.UserFinal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Id_UserSkills");

                    b.Property<string>("Proficiency");

                    b.Property<string>("Skill");

                    b.HasKey("Id");

                    b.HasIndex("Id_UserSkills");

                    b.ToTable("UserFinal");
                });

            modelBuilder.Entity("ExpressoApi.Models.UserSkillGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Proficiency");

                    b.Property<string>("Skill");

                    b.Property<int?>("UserSkillsId");

                    b.HasKey("Id");

                    b.HasIndex("UserSkillsId");

                    b.ToTable("UserSkillGroup");
                });

            modelBuilder.Entity("ExpressoApi.Models.UserSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("ExpressoApi.Models.ProficiencyGroup", b =>
                {
                    b.HasOne("ExpressoApi.Models.Proficiency")
                        .WithMany("ProficiencyGroup")
                        .HasForeignKey("ProficiencyId");
                });

            modelBuilder.Entity("ExpressoApi.Models.SkillGroup", b =>
                {
                    b.HasOne("ExpressoApi.Models.Skills")
                        .WithMany("SkillGroup")
                        .HasForeignKey("SkillsId");
                });

            modelBuilder.Entity("ExpressoApi.Models.UserFinal", b =>
                {
                    b.HasOne("ExpressoApi.Models.UserSkills", "UserSkills")
                        .WithMany()
                        .HasForeignKey("Id_UserSkills");
                });

            modelBuilder.Entity("ExpressoApi.Models.UserSkillGroup", b =>
                {
                    b.HasOne("ExpressoApi.Models.UserSkills")
                        .WithMany("UserSkillGroup")
                        .HasForeignKey("UserSkillsId");
                });
#pragma warning restore 612, 618
        }
    }
}

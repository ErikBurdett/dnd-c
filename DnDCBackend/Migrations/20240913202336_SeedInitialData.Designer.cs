﻿// <auto-generated />
using DnDCBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnDCBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240913202336_SeedInitialData")]
    partial class SeedInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("DnDCBackend.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Charisma")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Constitution")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wisdom")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Charisma = 15,
                            Class = "Wizard",
                            Constitution = 16,
                            Dexterity = 12,
                            Intelligence = 20,
                            Level = 20,
                            Name = "Gandalf",
                            Race = "Maia",
                            Strength = 18,
                            Wisdom = 18
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.ClassFeature", b =>
                {
                    b.Property<int>("ClassFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClassFeatureId");

                    b.HasIndex("CharacterId");

                    b.ToTable("ClassFeatures");

                    b.HasData(
                        new
                        {
                            ClassFeatureId = 1,
                            CharacterId = 1,
                            Description = "At 18th level, you have achieved such mastery over certain spells that you can cast them at will.",
                            Name = "Spell Mastery"
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.InventoryItem", b =>
                {
                    b.Property<int>("InventoryItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("InventoryItemId");

                    b.HasIndex("CharacterId");

                    b.ToTable("InventoryItems");

                    b.HasData(
                        new
                        {
                            InventoryItemId = 1,
                            CharacterId = 1,
                            Description = "A powerful magical staff used by wizards.",
                            Name = "Staff of Power",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.Proficiency", b =>
                {
                    b.Property<int>("ProficiencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProficiencyId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Proficiencies");

                    b.HasData(
                        new
                        {
                            ProficiencyId = 1,
                            CharacterId = 1,
                            Name = "Arcana"
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.SavingThrow", b =>
                {
                    b.Property<int>("SavingThrowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SavingThrowId");

                    b.HasIndex("CharacterId");

                    b.ToTable("SavingThrows");

                    b.HasData(
                        new
                        {
                            SavingThrowId = 1,
                            CharacterId = 1,
                            Name = "Wisdom"
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SkillId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            CharacterId = 1,
                            Name = "Spellcasting"
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.Spell", b =>
                {
                    b.Property<int>("SpellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Components")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SpellId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Spells");

                    b.HasData(
                        new
                        {
                            SpellId = 1,
                            CastingTime = "1 Action",
                            CharacterId = 1,
                            Components = "V, S, M",
                            Description = "A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame.",
                            Duration = "Instantaneous",
                            Level = "3",
                            Name = "Fireball",
                            Range = "150 feet",
                            School = "Evocation"
                        });
                });

            modelBuilder.Entity("DnDCBackend.Models.ClassFeature", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("ClassFeatures")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.InventoryItem", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("Inventory")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.Proficiency", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("Proficiencies")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.SavingThrow", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("SavingThrows")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.Skill", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.Spell", b =>
                {
                    b.HasOne("DnDCBackend.Models.Character", "Character")
                        .WithMany("Spells")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCBackend.Models.Character", b =>
                {
                    b.Navigation("ClassFeatures");

                    b.Navigation("Inventory");

                    b.Navigation("Proficiencies");

                    b.Navigation("SavingThrows");

                    b.Navigation("Skills");

                    b.Navigation("Spells");
                });
#pragma warning restore 612, 618
        }
    }
}

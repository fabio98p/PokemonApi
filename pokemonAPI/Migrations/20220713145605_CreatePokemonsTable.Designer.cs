﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pokemonAPI.Data;

#nullable disable

namespace pokemonAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220713145605_CreatePokemonsTable")]
    partial class CreatePokemonsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CharacterSkill");
                });

            modelBuilder.Entity("pokemonAPI.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RpgClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("pokemonAPI.Models.Move", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActualPP")
                        .HasColumnType("int");

                    b.Property<Guid>("MoveTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MoveTemplateId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("pokemonAPI.Models.MoveTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Accuraty")
                        .HasColumnType("int");

                    b.Property<bool>("AgainstFoe")
                        .HasColumnType("bit");

                    b.Property<int>("BuffAccuracy")
                        .HasColumnType("int");

                    b.Property<int>("BuffAttack")
                        .HasColumnType("int");

                    b.Property<int>("BuffDefense")
                        .HasColumnType("int");

                    b.Property<int>("BuffHp")
                        .HasColumnType("int");

                    b.Property<int>("BuffSpecialAttack")
                        .HasColumnType("int");

                    b.Property<int>("BuffSpecialDefence")
                        .HasColumnType("int");

                    b.Property<int>("BuffSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxPP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PokemonTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PokemonTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("MoveTemplates");
                });

            modelBuilder.Entity("pokemonAPI.Models.Pokemon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActualAvoidance")
                        .HasColumnType("int");

                    b.Property<int>("Actual_Hp")
                        .HasColumnType("int");

                    b.Property<int>("Actual_Xp")
                        .HasColumnType("int");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Avoidance")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("MaxHp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewLevelXp")
                        .HasColumnType("int");

                    b.Property<Guid?>("PokemonTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Special_Attack")
                        .HasColumnType("int");

                    b.Property<int>("Special_Defense")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PokemonTemplateId");

                    b.HasIndex("StatusId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("pokemonAPI.Models.PokemonTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("AttackLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<float>("DefenseLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("HpLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SpecialAttackLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<float>("SpecialDefenseLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<float>("SpeedLevelMoltiplicator")
                        .HasColumnType("real");

                    b.Property<float>("XpLevelMoltiplicator")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("PokemonTemplates");
                });

            modelBuilder.Entity("pokemonAPI.Models.PokemonType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("pokemonAPI.Models.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("pokemonAPI.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Danage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("pokemonAPI.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuperHeroes");
                });

            modelBuilder.Entity("pokemonAPI.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("pokemonAPI.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("PokemonTemplatePokemonType", b =>
                {
                    b.Property<Guid>("PokemonTemplatesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PokemonTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PokemonTemplatesId", "PokemonTypeId");

                    b.HasIndex("PokemonTypeId");

                    b.ToTable("PokemonTemplatePokemonType");
                });

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.HasOne("pokemonAPI.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pokemonAPI.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pokemonAPI.Character", b =>
                {
                    b.HasOne("pokemonAPI.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("pokemonAPI.Models.Move", b =>
                {
                    b.HasOne("pokemonAPI.Models.MoveTemplate", "MoveTemplate")
                        .WithMany("Moves")
                        .HasForeignKey("MoveTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MoveTemplate");
                });

            modelBuilder.Entity("pokemonAPI.Models.MoveTemplate", b =>
                {
                    b.HasOne("pokemonAPI.Models.PokemonType", "PokemonType")
                        .WithMany("MoveTemplates")
                        .HasForeignKey("PokemonTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pokemonAPI.Models.Status", "Status")
                        .WithMany("MoveTemplates")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokemonType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("pokemonAPI.Models.Pokemon", b =>
                {
                    b.HasOne("pokemonAPI.Models.PokemonTemplate", null)
                        .WithMany("Pokemons")
                        .HasForeignKey("PokemonTemplateId");

                    b.HasOne("pokemonAPI.Models.Status", "Status")
                        .WithMany("Pokemons")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("pokemonAPI.Weapon", b =>
                {
                    b.HasOne("pokemonAPI.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("pokemonAPI.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("PokemonTemplatePokemonType", b =>
                {
                    b.HasOne("pokemonAPI.Models.PokemonTemplate", null)
                        .WithMany()
                        .HasForeignKey("PokemonTemplatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pokemonAPI.Models.PokemonType", null)
                        .WithMany()
                        .HasForeignKey("PokemonTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pokemonAPI.Character", b =>
                {
                    b.Navigation("Weapon")
                        .IsRequired();
                });

            modelBuilder.Entity("pokemonAPI.Models.MoveTemplate", b =>
                {
                    b.Navigation("Moves");
                });

            modelBuilder.Entity("pokemonAPI.Models.PokemonTemplate", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("pokemonAPI.Models.PokemonType", b =>
                {
                    b.Navigation("MoveTemplates");
                });

            modelBuilder.Entity("pokemonAPI.Models.Status", b =>
                {
                    b.Navigation("MoveTemplates");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("pokemonAPI.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}

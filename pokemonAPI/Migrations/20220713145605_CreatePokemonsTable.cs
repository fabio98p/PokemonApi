using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokemonAPI.Migrations
{
    public partial class CreatePokemonsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HpLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    DefenseLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    SpecialDefenseLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    AttackLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    SpecialAttackLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    SpeedLevelMoltiplicator = table.Column<float>(type: "real", nullable: false),
                    XpLevelMoltiplicator = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTemplatePokemonType",
                columns: table => new
                {
                    PokemonTemplatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PokemonTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTemplatePokemonType", x => new { x.PokemonTemplatesId, x.PokemonTypeId });
                    table.ForeignKey(
                        name: "FK_PokemonTemplatePokemonType_PokemonTemplates_PokemonTemplatesId",
                        column: x => x.PokemonTemplatesId,
                        principalTable: "PokemonTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTemplatePokemonType_PokemonTypes_PokemonTypeId",
                        column: x => x.PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgainstFoe = table.Column<bool>(type: "bit", nullable: false),
                    Accuraty = table.Column<int>(type: "int", nullable: false),
                    MaxPP = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    BuffDefense = table.Column<int>(type: "int", nullable: false),
                    BuffSpecialDefence = table.Column<int>(type: "int", nullable: false),
                    BuffAttack = table.Column<int>(type: "int", nullable: false),
                    BuffSpecialAttack = table.Column<int>(type: "int", nullable: false),
                    BuffSpeed = table.Column<int>(type: "int", nullable: false),
                    BuffAccuracy = table.Column<int>(type: "int", nullable: false),
                    BuffHp = table.Column<int>(type: "int", nullable: false),
                    PokemonTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveTemplates_PokemonTypes_PokemonTypeId",
                        column: x => x.PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveTemplates_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxHp = table.Column<int>(type: "int", nullable: false),
                    Actual_Hp = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Special_Defense = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Special_Attack = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Actual_Xp = table.Column<int>(type: "int", nullable: false),
                    NewLevelXp = table.Column<int>(type: "int", nullable: false),
                    Avoidance = table.Column<int>(type: "int", nullable: false),
                    ActualAvoidance = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PokemonTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTemplates_PokemonTemplateId",
                        column: x => x.PokemonTemplateId,
                        principalTable: "PokemonTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokemons_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualPP = table.Column<int>(type: "int", nullable: false),
                    MoveTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_MoveTemplates_MoveTemplateId",
                        column: x => x.MoveTemplateId,
                        principalTable: "MoveTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moves_MoveTemplateId",
                table: "Moves",
                column: "MoveTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveTemplates_PokemonTypeId",
                table: "MoveTemplates",
                column: "PokemonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveTemplates_StatusId",
                table: "MoveTemplates",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonTemplateId",
                table: "Pokemons",
                column: "PokemonTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_StatusId",
                table: "Pokemons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTemplatePokemonType_PokemonTypeId",
                table: "PokemonTemplatePokemonType",
                column: "PokemonTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonTemplatePokemonType");

            migrationBuilder.DropTable(
                name: "MoveTemplates");

            migrationBuilder.DropTable(
                name: "PokemonTemplates");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}

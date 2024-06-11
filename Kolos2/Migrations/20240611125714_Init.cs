using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kolos2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "backpacks",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CharacterTitleCharacterId = table.Column<int>(type: "int", nullable: true),
                    CharacterTitleTitleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backpacks", x => new { x.CharacterId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: false),
                    BackpackCharacterId = table.Column<int>(type: "int", nullable: true),
                    BackpackItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characters_backpacks_BackpackCharacterId_BackpackItemId",
                        columns: x => new { x.BackpackCharacterId, x.BackpackItemId },
                        principalTable: "backpacks",
                        principalColumns: new[] { "CharacterId", "ItemId" });
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    BackpackCharacterId = table.Column<int>(type: "int", nullable: true),
                    BackpackItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_items_backpacks_BackpackCharacterId_BackpackItemId",
                        columns: x => new { x.BackpackCharacterId, x.BackpackItemId },
                        principalTable: "backpacks",
                        principalColumns: new[] { "CharacterId", "ItemId" });
                });

            migrationBuilder.CreateTable(
                name: "character_titles",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    AcquiredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CharacterTitleCharacterId = table.Column<int>(type: "int", nullable: true),
                    CharacterTitleTitleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character_titles", x => new { x.CharacterId, x.TitleId });
                    table.ForeignKey(
                        name: "FK_character_titles_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                        columns: x => new { x.CharacterTitleCharacterId, x.CharacterTitleTitleId },
                        principalTable: "character_titles",
                        principalColumns: new[] { "CharacterId", "TitleId" });
                    table.ForeignKey(
                        name: "FK_character_titles_characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_character_titles_titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "characters",
                columns: new[] { "Id", "BackpackCharacterId", "BackpackItemId", "CurrentWeight", "FirstName", "LastName", "MaxWeight" },
                values: new object[,]
                {
                    { 1, null, null, 10, "Jan", "Kowalski", 100 },
                    { 2, null, null, 40, "Anna", "Nowak", 200 }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "BackpackCharacterId", "BackpackItemId", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, null, null, "Sword", 10 },
                    { 2, null, null, "Shield", 15 }
                });

            migrationBuilder.InsertData(
                table: "titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Knight" },
                    { 2, "Barbarian" }
                });

            migrationBuilder.InsertData(
                table: "backpacks",
                columns: new[] { "CharacterId", "ItemId", "Amount", "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[,]
                {
                    { 1, 1, 30, null, null },
                    { 1, 2, 40, null, null },
                    { 2, 1, 22, null, null },
                    { 2, 2, 34, null, null }
                });

            migrationBuilder.InsertData(
                table: "character_titles",
                columns: new[] { "CharacterId", "TitleId", "AcquiredAt", "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 1, 2, new DateTime(2010, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, 2, new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_backpacks_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" });

            migrationBuilder.CreateIndex(
                name: "IX_backpacks_ItemId",
                table: "backpacks",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "character_titles",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" });

            migrationBuilder.CreateIndex(
                name: "IX_character_titles_TitleId",
                table: "character_titles",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_BackpackCharacterId_BackpackItemId",
                table: "characters",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" });

            migrationBuilder.CreateIndex(
                name: "IX_items_BackpackCharacterId_BackpackItemId",
                table: "items",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                principalTable: "character_titles",
                principalColumns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_items_ItemId",
                table: "backpacks",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_items_ItemId",
                table: "backpacks");

            migrationBuilder.DropTable(
                name: "character_titles");

            migrationBuilder.DropTable(
                name: "titles");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "backpacks");
        }
    }
}

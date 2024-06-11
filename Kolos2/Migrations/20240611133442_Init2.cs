using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolos2.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_character_titles_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "character_titles");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_backpacks_BackpackCharacterId_BackpackItemId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_items_backpacks_BackpackCharacterId_BackpackItemId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_BackpackCharacterId_BackpackItemId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_characters_BackpackCharacterId_BackpackItemId",
                table: "characters");

            migrationBuilder.DropIndex(
                name: "IX_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "character_titles");

            migrationBuilder.DropIndex(
                name: "IX_backpacks_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks");

            migrationBuilder.DropColumn(
                name: "BackpackCharacterId",
                table: "items");

            migrationBuilder.DropColumn(
                name: "BackpackItemId",
                table: "items");

            migrationBuilder.DropColumn(
                name: "BackpackCharacterId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "BackpackItemId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "CharacterTitleCharacterId",
                table: "character_titles");

            migrationBuilder.DropColumn(
                name: "CharacterTitleTitleId",
                table: "character_titles");

            migrationBuilder.DropColumn(
                name: "CharacterTitleCharacterId",
                table: "backpacks");

            migrationBuilder.DropColumn(
                name: "CharacterTitleTitleId",
                table: "backpacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackpackCharacterId",
                table: "items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackpackItemId",
                table: "items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackpackCharacterId",
                table: "characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackpackItemId",
                table: "characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterTitleCharacterId",
                table: "character_titles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterTitleTitleId",
                table: "character_titles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterTitleCharacterId",
                table: "backpacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterTitleTitleId",
                table: "backpacks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "characters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_items_BackpackCharacterId_BackpackItemId",
                table: "items",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" });

            migrationBuilder.CreateIndex(
                name: "IX_characters_BackpackCharacterId_BackpackItemId",
                table: "characters",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" });

            migrationBuilder.CreateIndex(
                name: "IX_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "character_titles",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" });

            migrationBuilder.CreateIndex(
                name: "IX_backpacks_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "backpacks",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                principalTable: "character_titles",
                principalColumns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_character_titles_character_titles_CharacterTitleCharacterId_CharacterTitleTitleId",
                table: "character_titles",
                columns: new[] { "CharacterTitleCharacterId", "CharacterTitleTitleId" },
                principalTable: "character_titles",
                principalColumns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_characters_backpacks_BackpackCharacterId_BackpackItemId",
                table: "characters",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                principalTable: "backpacks",
                principalColumns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_items_backpacks_BackpackCharacterId_BackpackItemId",
                table: "items",
                columns: new[] { "BackpackCharacterId", "BackpackItemId" },
                principalTable: "backpacks",
                principalColumns: new[] { "CharacterId", "ItemId" });
        }
    }
}

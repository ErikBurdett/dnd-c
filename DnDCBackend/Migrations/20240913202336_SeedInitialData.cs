using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCBackend.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Charisma", "Class", "Constitution", "Dexterity", "Intelligence", "Level", "Name", "Race", "Strength", "Wisdom" },
                values: new object[] { 1, 15, "Wizard", 16, 12, 20, 20, "Gandalf", "Maia", 18, 18 });

            migrationBuilder.InsertData(
                table: "ClassFeatures",
                columns: new[] { "ClassFeatureId", "CharacterId", "Description", "Name" },
                values: new object[] { 1, 1, "At 18th level, you have achieved such mastery over certain spells that you can cast them at will.", "Spell Mastery" });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "InventoryItemId", "CharacterId", "Description", "Name", "Quantity" },
                values: new object[] { 1, 1, "A powerful magical staff used by wizards.", "Staff of Power", 1 });

            migrationBuilder.InsertData(
                table: "Proficiencies",
                columns: new[] { "ProficiencyId", "CharacterId", "Name" },
                values: new object[] { 1, 1, "Arcana" });

            migrationBuilder.InsertData(
                table: "SavingThrows",
                columns: new[] { "SavingThrowId", "CharacterId", "Name" },
                values: new object[] { 1, 1, "Wisdom" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "CharacterId", "Name" },
                values: new object[] { 1, 1, "Spellcasting" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "SpellId", "CastingTime", "CharacterId", "Components", "Description", "Duration", "Level", "Name", "Range", "School" },
                values: new object[] { 1, "1 Action", 1, "V, S, M", "A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame.", "Instantaneous", "3", "Fireball", "150 feet", "Evocation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassFeatures",
                keyColumn: "ClassFeatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "InventoryItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proficiencies",
                keyColumn: "ProficiencyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SavingThrows",
                keyColumn: "SavingThrowId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);
        }
    }
}

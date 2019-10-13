using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicCardsGraphQL.Migrations
{
    public partial class UpdateCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "ColectorNumber",
                table: "Cards",
                newName: "ManaCost");

            migrationBuilder.AddColumn<string>(
                name: "Colors",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubType",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuperType",
                table: "Cards",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colors",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SubType",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SuperType",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "ManaCost",
                table: "Cards",
                newName: "ColectorNumber");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Cards",
                nullable: false,
                defaultValue: 0);
        }
    }
}

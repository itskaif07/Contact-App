using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Migrations
{
    /// <inheritdoc />
    public partial class updatedname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "ContactItems");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ContactItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ContactItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ContactItems");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ContactItems");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "ContactItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}

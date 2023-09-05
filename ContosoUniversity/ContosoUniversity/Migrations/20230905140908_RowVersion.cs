using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class RowVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RowvVersion",
                table: "Department",
                newName: "RowVersion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RowVersion",
                table: "Department",
                newName: "RowvVersion");
        }
    }
}

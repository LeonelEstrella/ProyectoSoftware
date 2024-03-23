using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccessData.Migrations
{
    /// <inheritdoc />
    public partial class DataSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Electrodomésticos" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}

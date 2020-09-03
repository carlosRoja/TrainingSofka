using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSofka.Web.Migrations
{
    public partial class NewAtribbute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Travels",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Travels");
        }
    }
}

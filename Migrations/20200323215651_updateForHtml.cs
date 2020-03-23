using Microsoft.EntityFrameworkCore.Migrations;

namespace EmailService.Migrations
{
    public partial class updateForHtml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Emails");

            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Emails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Html",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Emails");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Emails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

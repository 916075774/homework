using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class InviteBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InviteById",
                table: "_users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__users_InviteById",
                table: "_users",
                column: "InviteById");

            migrationBuilder.AddForeignKey(
                name: "FK__users__users_InviteById",
                table: "_users",
                column: "InviteById",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__users__users_InviteById",
                table: "_users");

            migrationBuilder.DropIndex(
                name: "IX__users_InviteById",
                table: "_users");

            migrationBuilder.DropColumn(
                name: "InviteById",
                table: "_users");
        }
    }
}

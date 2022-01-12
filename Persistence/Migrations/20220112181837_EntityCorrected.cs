using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class EntityCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Activities_AcitvityId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Comments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "AcitvityId",
                table: "Comments",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AcitvityId",
                table: "Comments",
                newName: "IX_Comments_ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Comments",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "Comments",
                newName: "AcitvityId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ActivityId",
                table: "Comments",
                newName: "IX_Comments_AcitvityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Activities_AcitvityId",
                table: "Comments",
                column: "AcitvityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

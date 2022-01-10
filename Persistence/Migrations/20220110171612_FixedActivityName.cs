using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixedActivityName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityAttendees_Activities_ActvityId",
                table: "ActivityAttendees");

            migrationBuilder.RenameColumn(
                name: "isHost",
                table: "ActivityAttendees",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "ActvityId",
                table: "ActivityAttendees",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivityAttendees_ActvityId",
                table: "ActivityAttendees",
                newName: "IX_ActivityAttendees_ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityAttendees_Activities_ActivityId",
                table: "ActivityAttendees",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityAttendees_Activities_ActivityId",
                table: "ActivityAttendees");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "ActivityAttendees",
                newName: "isHost");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "ActivityAttendees",
                newName: "ActvityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivityAttendees_ActivityId",
                table: "ActivityAttendees",
                newName: "IX_ActivityAttendees_ActvityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityAttendees_Activities_ActvityId",
                table: "ActivityAttendees",
                column: "ActvityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

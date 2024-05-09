using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehycle.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Vehycles_VehycleId",
                table: "Photos");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Vehycles_VehycleId",
                table: "Photos",
                column: "VehycleId",
                principalTable: "Vehycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Vehycles_VehycleId",
                table: "Photos");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Vehycles_VehycleId",
                table: "Photos",
                column: "VehycleId",
                principalTable: "Vehycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

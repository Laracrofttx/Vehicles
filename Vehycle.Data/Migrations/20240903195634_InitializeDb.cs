using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehycle.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Vehycles");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Vehycles");

            migrationBuilder.DropColumn(
                name: "FormFile",
                table: "Vehycles");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    VehycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Vehycles_VehycleId",
                        column: x => x.VehycleId,
                        principalTable: "Vehycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_VehycleId",
                table: "Photos",
                column: "VehycleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Vehycles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Vehycles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FormFile",
                table: "Vehycles",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}

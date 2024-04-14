using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vehycle.Data.Migrations
{
    /// <inheritdoc />
    public partial class Updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

          

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Photos",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

          

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldDefaultValue: "Smith");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldDefaultValue: "John");

         

      
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Vehycles_VehycleId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_VehycleId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Photos",
                table: "Vehycles");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "VehycleId",
                table: "Photos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "VehycleId1",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "Smith",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "John",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cars" },
                    { 2, "Motorcycles" },
                    { 3, "Buses" },
                    { 4, "Trucks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_VehycleId1",
                table: "Photos",
                column: "VehycleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Vehycles_VehycleId1",
                table: "Photos",
                column: "VehycleId1",
                principalTable: "Vehycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

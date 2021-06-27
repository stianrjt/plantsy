using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plantsy.Server.Data.Migrations
{
    public partial class AddedImageToPlant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Plants_PlantID",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PlantID",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageID",
                table: "Plants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageID1",
                table: "Plants",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_ImageID1",
                table: "Plants",
                column: "ImageID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Images_ImageID1",
                table: "Plants",
                column: "ImageID1",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Images_ImageID1",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_ImageID1",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "ImageID1",
                table: "Plants");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PlantID",
                table: "Images",
                column: "PlantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Plants_PlantID",
                table: "Images",
                column: "PlantID",
                principalTable: "Plants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

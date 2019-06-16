using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Star.Data.Migrations
{
    public partial class ConvertedContentfulPropertyFromStringToGuidAndUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ContentfulId",
                table: "Office",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContentfulId",
                table: "Office",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}

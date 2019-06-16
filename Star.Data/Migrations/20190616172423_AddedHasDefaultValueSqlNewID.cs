using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Star.Data.Migrations
{
	public partial class AddedHasDefaultValueSqlNewID : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<Guid>(
				name: "ContentfulId",
				table: "Office",
				nullable: false,
				defaultValueSql: "NEWID()",
				oldClrType: typeof(Guid));
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<Guid>(
				name: "ContentfulId",
				table: "Office",
				nullable: false,
				oldClrType: typeof(Guid),
				oldDefaultValueSql: "NEWID()");
		}
	}
}

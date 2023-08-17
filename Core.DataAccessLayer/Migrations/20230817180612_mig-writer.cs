using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DataAccessLayer.Migrations
{
	/// <inheritdoc />
	public partial class migwriter : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<bool>(
				name: "WriterStatus",
				table: "Writers",
				type: "bit",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AddColumn<int>(
				name: "WriterId",
				table: "Blogs",
				type: "int",
				nullable: true,
				defaultValue: 0);

			migrationBuilder.CreateIndex(
				name: "IX_Blogs_WriterId",
				table: "Blogs",
				column: "WriterId");

			migrationBuilder.AddForeignKey(
				name: "FK_Blogs_Writers_WriterId",
				table: "Blogs",
				column: "WriterId",
				principalTable: "Writers",
				principalColumn: "WriterID",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Blogs_Writers_WriterId",
				table: "Blogs");

			migrationBuilder.DropIndex(
				name: "IX_Blogs_WriterId",
				table: "Blogs");

			migrationBuilder.DropColumn(
				name: "WriterId",
				table: "Blogs");

			migrationBuilder.AlterColumn<string>(
				name: "WriterStatus",
				table: "Writers",
				type: "nvarchar(max)",
				nullable: false,
				oldClrType: typeof(bool),
				oldType: "bit");
		}
	}
}

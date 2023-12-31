﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class newsLetter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Blogs",
                newName: "WriterID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_WriterId",
                table: "Blogs",
                newName: "IX_Blogs_WriterID");

            migrationBuilder.CreateTable(
                name: "NewsLetter",
                columns: table => new
                {
                    MailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetter", x => x.MailId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "NewsLetter");

            migrationBuilder.RenameColumn(
                name: "WriterID",
                table: "Blogs",
                newName: "WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                newName: "IX_Blogs_WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

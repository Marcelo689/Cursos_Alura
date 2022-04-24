using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class IndiceAtorUltimoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "language_id",
                table: "film",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "original_language_id",
                table: "film",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_actor_first_name_last_name",
                table: "actor",
                columns: new[] { "first_name", "last_name" });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    language_id = table.Column<byte>(type: "tinyint", nullable: false),
                    language_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.language_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_film_language_id",
                table: "film",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_film_original_language_id",
                table: "film",
                column: "original_language_id");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_actor_id",
                table: "Elenco",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "actor",
                column: "last_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Elenco_actor_actor_id",
                table: "Elenco",
                column: "actor_id",
                principalTable: "actor",
                principalColumn: "actor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Elenco_film_film_id",
                table: "Elenco",
                column: "film_id",
                principalTable: "film",
                principalColumn: "film_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_language_id",
                table: "film",
                column: "language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film",
                column: "original_language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elenco_actor_actor_id",
                table: "Elenco");

            migrationBuilder.DropForeignKey(
                name: "FK_Elenco_film_film_id",
                table: "Elenco");

            migrationBuilder.DropForeignKey(
                name: "FK_film_language_language_id",
                table: "film");

            migrationBuilder.DropForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropIndex(
                name: "IX_film_language_id",
                table: "film");

            migrationBuilder.DropIndex(
                name: "IX_film_original_language_id",
                table: "film");

            migrationBuilder.DropIndex(
                name: "IX_Elenco_actor_id",
                table: "Elenco");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_actor_first_name_last_name",
                table: "actor");

            migrationBuilder.DropIndex(
                name: "idx_actor_last_name",
                table: "actor");

            migrationBuilder.DropColumn(
                name: "language_id",
                table: "film");

            migrationBuilder.DropColumn(
                name: "original_language_id",
                table: "film");
        }
    }
}

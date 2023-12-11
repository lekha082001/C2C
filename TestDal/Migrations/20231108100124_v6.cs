﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "school",
                table: "Parents");

            migrationBuilder.CreateTable(
                name: "Manys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToMany2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToMany2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManyToMany2",
                columns: table => new
                {
                    ManysId = table.Column<int>(type: "int", nullable: false),
                    ToMany2sId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyToMany2", x => new { x.ManysId, x.ToMany2sId });
                    table.ForeignKey(
                        name: "FK_ManyToMany2_Manys_ManysId",
                        column: x => x.ManysId,
                        principalTable: "Manys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManyToMany2_ToMany2s_ToMany2sId",
                        column: x => x.ToMany2sId,
                        principalTable: "ToMany2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManyToMany2_ToMany2sId",
                table: "ManyToMany2",
                column: "ToMany2sId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManyToMany2");

            migrationBuilder.DropTable(
                name: "Manys");

            migrationBuilder.DropTable(
                name: "ToMany2s");

            migrationBuilder.AddColumn<string>(
                name: "school",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

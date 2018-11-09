using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TotalClean.Migrations
{
    public partial class qwe4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hogar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Ciudad = table.Column<string>(nullable: false),
                    Dia = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Distrito = table.Column<string>(nullable: false),
                    Horas = table.Column<int>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hogar", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hogar");
        }
    }
}

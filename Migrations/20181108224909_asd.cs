using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TotalClean.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Apellidos = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ciudad = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    Dia = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Distrito = table.Column<string>(nullable: false),
                    Empresa = table.Column<string>(maxLength: 40, nullable: false),
                    Horas = table.Column<int>(nullable: false),
                    RUC = table.Column<int>(nullable: false),
                    Telefono = table.Column<int>(nullable: true),
                    User = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Apellidos = table.Column<string>(nullable: false),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    ConfirmarCorreo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    User = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Oficina");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

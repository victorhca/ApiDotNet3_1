﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseApi.Migrations
{
    public partial class Criandotabelacotacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeMoedaCode = table.Column<string>(nullable: true),
                    DeMoedaId = table.Column<int>(nullable: false),
                    ParaMoedaCode = table.Column<string>(nullable: true),
                    ParaMoedaId = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ProcessSrv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotations");
        }
    }
}

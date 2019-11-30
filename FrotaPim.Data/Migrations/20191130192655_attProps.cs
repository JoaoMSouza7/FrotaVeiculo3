﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FrotaPim.Data.Migrations
{
    public partial class attProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorSeguro",
                table: "seguro",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorSeguro",
                table: "seguro");
        }
    }
}

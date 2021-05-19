using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EjercicioDesarrolloAplicacion.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermitType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermitType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permit",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: false),
                    EmployeeLastName = table.Column<string>(nullable: false),
                    PermitTypeId = table.Column<int>(nullable: false),
                    PermitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permit", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Permit_PermitType_PermitTypeId",
                        column: x => x.PermitTypeId,
                        principalTable: "PermitType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermitType",
                columns: new[] { "ID", "Description" },
                values: new object[] { 1, "Sickness" });

            migrationBuilder.InsertData(
                table: "PermitType",
                columns: new[] { "ID", "Description" },
                values: new object[] { 2, "Errands" });

            migrationBuilder.InsertData(
                table: "PermitType",
                columns: new[] { "ID", "Description" },
                values: new object[] { 3, "Other" });

            migrationBuilder.CreateIndex(
                name: "IX_Permit_PermitTypeId",
                table: "Permit",
                column: "PermitTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "PermitType");
        }
    }
}

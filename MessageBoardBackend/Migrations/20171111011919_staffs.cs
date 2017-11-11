using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MessageBoardBackend.Migrations
{
    public partial class staffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_completed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_dispatched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_due = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_received = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_responded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priority = table.Column<int>(type: "int", nullable: false),
                    proactive = table.Column<bool>(type: "bit", nullable: false),
                    property = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    schedule_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    suite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wo_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wo_detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

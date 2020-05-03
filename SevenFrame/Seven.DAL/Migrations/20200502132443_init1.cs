using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Seven.DAL.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CrateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserID = table.Column<string>(nullable: true),
                    EnumEntityState = table.Column<int>(nullable: false),
                    ParentID = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(nullable: true),
                    Admin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    OrgCode = table.Column<string>(nullable: true),
                    ExtentFild = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CrateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserID = table.Column<string>(nullable: true),
                    EnumEntityState = table.Column<int>(nullable: false),
                    LonginID = table.Column<string>(nullable: true),
                    Account = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

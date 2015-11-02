using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace IAT.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apps",
                columns: table => new
                {
                    AppID = table.Column<int>(isNullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn),
                    AppName = table.Column<string>(isNullable: true),
                    CreatedBy = table.Column<string>(isNullable: true),
                    CreatedOn = table.Column<DateTime>(isNullable: false),
                    Icon = table.Column<byte[]>(isNullable: true),
                    ModifiedBy = table.Column<string>(isNullable: true),
                    ModifiedOn = table.Column<DateTime>(isNullable: false),
                    RecordStatus = table.Column<int>(isNullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_App", x => x.AppID);
                });
            migrationBuilder.CreateTable(
                name: "Exceptions",
                columns: table => new
                {
                    AppExcetionID = table.Column<int>(isNullable: false),
                    AppName = table.Column<string>(isNullable: true),
                    CreatedBy = table.Column<string>(isNullable: true),
                    CreatedOn = table.Column<DateTime>(isNullable: false),
                    Date = table.Column<DateTime>(isNullable: false),
                    ExceptionMessage = table.Column<string>(isNullable: true),
                    ExceptionStackTrace = table.Column<string>(isNullable: true),
                    ExceptionTitle = table.Column<string>(isNullable: true),
                    ModifiedBy = table.Column<string>(isNullable: true),
                    ModifiedOn = table.Column<DateTime>(isNullable: false),
                    RecordStatus = table.Column<int>(isNullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppException", x => x.AppExcetionID);
                });
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(isNullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(isNullable: true),
                    CreatedOn = table.Column<DateTime>(isNullable: false),
                    Firstname = table.Column<string>(isNullable: true),
                    Image = table.Column<byte[]>(isNullable: true),
                    Lastname = table.Column<string>(isNullable: true),
                    Middlename = table.Column<string>(isNullable: true),
                    ModifiedBy = table.Column<string>(isNullable: true),
                    ModifiedOn = table.Column<DateTime>(isNullable: false),
                    Password = table.Column<string>(isNullable: true),
                    RecordStatus = table.Column<int>(isNullable: false),
                    Username = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Apps");
            migrationBuilder.DropTable("Exceptions");
            migrationBuilder.DropTable("Users");
        }
    }
}

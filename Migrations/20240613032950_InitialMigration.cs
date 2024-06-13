using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPM.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authentications",
                columns: table => new
                {
                    AuthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserRole = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DateLogin = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    TimeLogin = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    DateLogout = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    TimeLogout = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FlagStatus = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentications", x => x.AuthId);
                });

            migrationBuilder.CreateTable(
                name: "JobRequests",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRequest = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    TimeRequest = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    UserName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StartPoint = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Destination = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MaterialName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    UrgentType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PatientType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PersonId = table.Column<int>(type: "int", unicode: false, maxLength: 8, nullable: false),
                    TimeClose = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    DateClase = table.Column<DateTime>(type: "datetime2", unicode: false, maxLength: 8, nullable: false),
                    Remark = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRequests", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "UrgentTypes",
                columns: table => new
                {
                    UrgentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrgentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgentTypes", x => x.UrgentId);
                });

            migrationBuilder.InsertData(
                table: "Authentications",
                columns: new[] { "AuthId", "DateCreate", "DateLogin", "DateLogout", "Department", "FirstName", "FlagStatus", "LastName", "Password", "PhoneNumber", "TimeLogin", "TimeLogout", "UserName", "UserRole" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Test", "Test", "Test", "Test", "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HPMTest", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authentications");

            migrationBuilder.DropTable(
                name: "JobRequests");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "UrgentTypes");
        }
    }
}

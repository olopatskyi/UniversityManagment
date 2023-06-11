using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupTeacher",
                columns: table => new
                {
                    GroupsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TeachersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTeacher", x => new { x.GroupsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_GroupTeacher_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTeacher_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineStudent",
                columns: table => new
                {
                    DisciplinesId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineStudent", x => new { x.DisciplinesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_DisciplineStudent_Disciplines_DisciplinesId",
                        column: x => x.DisciplinesId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplineStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDisciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisciplineId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDisciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDisciplines_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"), "aad86da0-a9d3-4079-93df-61f365239f77", "Teacher", "TEACHER" },
                    { new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"), "7dc68bce-3a0f-4b40-a7af-15a9c6a3b3f4", "Student", "STUDENT" },
                    { new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"), "7822dda2-9594-439a-87df-202c5a6afe24", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("537826d9-90b5-4d70-9606-addbd078d509"), 0, "9cd54cec-ae67-4f48-9fe7-8f6c1576d2a2", "artur.bondar@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAECKfk8CwzNqJEHvYV1gXq04m2gEL85CfkNCTKlake9CfRzJfd+oMR4qduDFL4X55eA==", null, true, "16f2a9b9-6f89-4854-90ae-1a362c10b8fb", false, "Artur Bondar" },
                    { new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"), 0, "a56a7470-00b1-4090-b085-8586df14148a", "admin@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAELdHfYATd8uQz8BUhnli68kmKgz6maE6bwsVhnpDpSF26r3qClQiSvQSy6Zd+JMcmQ==", null, true, "1ccd41cb-faa8-481a-82f7-2bfce01e8f19", false, "Admin" },
                    { new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"), 0, "7f6b2379-6a90-4021-af5a-58733f57ddf7", "volodymyr.tymofiyovych@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEG9Bd4b4iuhyIcfAm77hDbb5Ra6ebJKUnibU4Muomi7reRFYIkEZBv1AzCBjBtSu4g==", null, true, "315044fc-eaf8-41e6-b79d-9c876c29bdc7", false, "Volodymyr Tymofiyovych" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 49, "get:student", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 50, "create:student", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 51, "delete:student", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 52, "update:student", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 53, "get:teacher", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 54, "create:teacher", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 55, "delete:teacher", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 56, "update:teacher", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 57, "get:discipline", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 58, "create:discipline", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 59, "delete:discipline", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 60, "update:discipline", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 61, "get:faculty", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 62, "create:faculty", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 63, "delete:faculty", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 64, "update:faculty", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 65, "get:semester", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 66, "create:semester", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 67, "delete:semester", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 68, "update:semester", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 69, "get:group", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 70, "create:group", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 71, "delete:group", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 72, "get:student", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 73, "update:student", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 74, "get:teacher", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 75, "create:teacher", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 76, "update:teacher", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 77, "delete:teacher", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 78, "get:discipline", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 79, "create:discipline", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 80, "update:discipline", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 81, "delete:discipline", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 82, "get:faculty", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 83, "get:semester", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 84, "get:group", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 85, "create:group", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 86, "update:group", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 87, "delete:group", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 88, "get:student", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 89, "create:student", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 90, "delete:student", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 91, "update:student", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 92, "get:teacher", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 93, "get:discipline", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 94, "get:faculty", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 95, "get:semester", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 96, "get:group", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"), new Guid("537826d9-90b5-4d70-9606-addbd078d509") },
                    { new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"), new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa") },
                    { new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"), new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FacultyId", "GroupId" },
                values: new object[] { new Guid("537826d9-90b5-4d70-9606-addbd078d509"), null, null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FacultyId" },
                values: new object[] { new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"), null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_SemesterId",
                table: "Disciplines",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineStudent_StudentsId",
                table: "DisciplineStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTeacher_TeachersId",
                table: "GroupTeacher",
                column: "TeachersId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDisciplines_DisciplineId",
                table: "StudentDisciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDisciplines_StudentId",
                table: "StudentDisciplines",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_FacultyId",
                table: "Teachers",
                column: "FacultyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DisciplineStudent");

            migrationBuilder.DropTable(
                name: "GroupTeacher");

            migrationBuilder.DropTable(
                name: "StudentDisciplines");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}

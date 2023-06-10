using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "Students",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bded3de8-0e1c-4b77-9ff3-68f44fc04020", "AQAAAAIAAYagAAAAELJBE7rHYMnGA2lMhtFGCXWJogSdMlypY12/Sa69idXSSLVFKpvkHuKiin/yJsFp8w==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("537826d9-90b5-4d70-9606-addbd078d509"), 0, "26c8f946-0ace-4e40-aa0a-904cad133d5a", "artur.bondar@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEAJovClLV1kVqnaqy3ugAxGSx5Wjdh2rMnEW7AWgpNG+NSSwxVcCtRNLEjCFdlAG0w==", null, true, null, false, "Artur Bondar" },
                    { new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"), 0, "f96057e4-d034-48c8-a5a3-14065567b669", "volodymyr.tymofiyovych@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEO706KEGCy0l1rsTQK/rni0lXoej250koSlPCjieVP1QZxz5j9EZ4uK6ebIWiYVfaQ==", null, true, null, false, "Volodymyr Tymofiyovych" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"), new Guid("537826d9-90b5-4d70-9606-addbd078d509") },
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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"), new Guid("537826d9-90b5-4d70-9606-addbd078d509") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"), new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "Students",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da697c07-41a7-41c7-99c8-9b502179b221", "AQAAAAIAAYagAAAAEL9xYeh+iW3EbWSCDnqQeYMLEpRw/CAvTbhBM030oVfDDC62h+04D40zbfxfLeoEIQ==" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FacultyId" },
                values: new object[] { new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

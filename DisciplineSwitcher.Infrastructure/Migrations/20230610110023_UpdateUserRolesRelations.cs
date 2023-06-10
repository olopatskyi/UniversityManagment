using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserRolesRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d") });

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Teachers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"), null, "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"), 0, "d85d58f7-67ed-44e1-9ed0-5539dddbe8ff", "admin@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEI4ApKV8tJcpzpAN+iG1gBfknndtCV1IAzmZPrQMg0jhbflfHd9iNB8iK5HUeUt9wg==", null, true, null, false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"), new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa") });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FacultyId" },
                values: new object[] { new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"), new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa") });

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"));

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Teachers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Teachers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("313f353f-2ac2-4e56-9904-8826767b9c6a"), new Guid("21789e0e-1737-4545-862d-fc3fbae3bc6d") });
        }
    }
}

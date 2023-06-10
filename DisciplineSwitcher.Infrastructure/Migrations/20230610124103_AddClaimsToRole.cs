using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClaimsToRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 49, "student:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 50, "student:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 51, "student:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 52, "student:update", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 53, "teacher:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 54, "teacher:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 55, "teacher:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 56, "teacher:update", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 57, "discipline:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 58, "discipline:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 59, "discipline:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 60, "discipline:update", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 61, "faculty:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 62, "faculty:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 63, "faculty:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 64, "faculty:update", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 65, "semester:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 66, "semester:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 67, "semester:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 68, "semester:update", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 69, "group:get", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 70, "group:create", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") },
                    { 71, "group:delete", null, new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e") }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"), null, "Teacher", null },
                    { new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"), null, "Student", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da697c07-41a7-41c7-99c8-9b502179b221", "AQAAAAIAAYagAAAAEL9xYeh+iW3EbWSCDnqQeYMLEpRw/CAvTbhBM030oVfDDC62h+04D40zbfxfLeoEIQ==" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 72, "student:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 73, "student:update", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 74, "teacher:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 75, "teacher:create", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 76, "teacher:update", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 77, "teacher:delete", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 78, "discipline:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 79, "discipline:create", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 80, "discipline:update", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 81, "discipline:delete", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 82, "faculty:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 83, "semester:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 84, "group:get", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 85, "group:create", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 86, "group:update", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 87, "group:delete", null, new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f") },
                    { 88, "student:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 89, "student:create", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 90, "student:delete", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 91, "student:update", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 92, "teacher:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 93, "discipline:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 94, "faculty:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 95, "semester:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") },
                    { 96, "group:get", null, new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d85d58f7-67ed-44e1-9ed0-5539dddbe8ff", "AQAAAAIAAYagAAAAEI4ApKV8tJcpzpAN+iG1gBfknndtCV1IAzmZPrQMg0jhbflfHd9iNB8iK5HUeUt9wg==" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoleConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "ff9a18c6-0dfb-4c78-88b0-27312dfa2f19", "TEACHER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "ac6b028d-383f-41d2-aed5-b2d3bbf68a97", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "85f27631-b8be-44d2-a20e-da5aefc43aa2", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fe4e7af-396b-442d-97ae-e0ef9e6324a6", "AQAAAAIAAYagAAAAEHEzwI89mOSSfzkjH0KtnGM2oSFifkqYgqqm9oqR9e+YqRabfXT+Dl+AdIeK11/cNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9093a6e3-4876-4d52-a215-4f2b008d89a7", "AQAAAAIAAYagAAAAEL/VBrEu88a44XUI1Gjuor8xTfp1GyskRG/drWNWVHwkDEuq3/MIiVEvfybfhkpD/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21ba73a8-6c10-42a5-bcb4-f99d91d20b6d", "AQAAAAIAAYagAAAAEEjPIa2AJIL4ndA+x6Ixb2cbJSXGded3OxjGx0uE197D1iqEWcHr14TqhnIfi3sA4w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f321288b-95b1-4093-be0d-4a41b51f1234", "AQAAAAIAAYagAAAAEH8spuhCR9sP/sb1ghvYnN8ilOGqBE9CJPBufIJ6lQDEHZproiOrTpIvm4SbL4nN5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc199d9e-f63c-4ddc-806f-a163b123e303", "AQAAAAIAAYagAAAAELDvt9qcPSjmJs64P6F8JgMRvZnuqBfyVUHlkiFpotFQXPB9fJovN3XU9YlTU+bGtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd76bf94-1fe3-4355-bf51-469a27526e93", "AQAAAAIAAYagAAAAEEYMlEcLDPJXmHlmv3dufiak2J0ZEEdvS80HqaAGJKiDF2NJv1tlLXxwLOX6VT9Kgg==" });
        }
    }
}

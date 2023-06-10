using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConcurrencyStampForTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                column: "ConcurrencyStamp",
                value: "6bde5916-de4c-4455-afe8-c4a48b0840bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                column: "ConcurrencyStamp",
                value: "80b452b2-6e63-4f8b-aab7-58f424940b2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                column: "ConcurrencyStamp",
                value: "829d1889-42d0-4f86-bac0-a7a32cb6cf61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7aa5ed02-b8ec-4120-b0f8-b09285ea67a0", "AQAAAAIAAYagAAAAEBUiQFHISQ6SZvKzvUPmmTRSzB5hDGBJeceptv8JQGMIAYuxB5U6zkfqj5/loMtUkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f47de272-e977-45e9-9417-fd0182864796", "AQAAAAIAAYagAAAAEGqETzbybD5drWa3xOiQPQ6J8TBgcA1iJxK/zv9SdvFvTZmr9xsLp34FLI0669zdnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d056582-a252-4af0-97a9-35f0d40d9608", "AQAAAAIAAYagAAAAEOBlFkRyysZFYj9Ujtj6hRfipJMduRKvsxZT6fGhWkvI0Qzow2zOBD49+Zitk9KzTw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                column: "ConcurrencyStamp",
                value: "ff9a18c6-0dfb-4c78-88b0-27312dfa2f19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                column: "ConcurrencyStamp",
                value: "ac6b028d-383f-41d2-aed5-b2d3bbf68a97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                column: "ConcurrencyStamp",
                value: "85f27631-b8be-44d2-a20e-da5aefc43aa2");

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
    }
}

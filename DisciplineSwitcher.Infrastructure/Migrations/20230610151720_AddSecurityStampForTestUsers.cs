using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSecurityStampForTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                column: "ConcurrencyStamp",
                value: "0bd11313-98d0-41ea-a7b3-4fbc27280bf3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                column: "ConcurrencyStamp",
                value: "298115c4-13db-4d44-ae22-02715bc01489");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                column: "ConcurrencyStamp",
                value: "5b7ec08c-c0df-4e73-b268-7f744dbbc7c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f26a85ce-64b0-4d0a-8909-f4e28982f478", "AQAAAAIAAYagAAAAEELP6H3qebiJTsrdAbiA8dHReL1f77L/ZUAb2HT51QRE+fI62GPw71YnFrF+dJk+cQ==", "dc744de3-c207-4a1e-a4a9-1d26844813a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab03d0ad-4f8e-4f49-8890-74ede9c859cd", "AQAAAAIAAYagAAAAEPxnD0DkKjZvyevhbeLWSlXsUiP9y2U2YmBDXbEyILCM53gbworPwpTzCJGpAV+2Wg==", "408d2bb5-097f-4abe-9143-c78164ee0b1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07291ec9-9a36-4258-99bb-11dec113764a", "AQAAAAIAAYagAAAAELQ4L0sOYYXwNMS2ZNvPujTmJlX0Ywia0Drmw9D6GNVDoE/sN3ph5SzjCsjMJ94c9A==", "8ba2e92d-93b0-4df3-ad7a-58833bb30201" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa5ed02-b8ec-4120-b0f8-b09285ea67a0", "AQAAAAIAAYagAAAAEBUiQFHISQ6SZvKzvUPmmTRSzB5hDGBJeceptv8JQGMIAYuxB5U6zkfqj5/loMtUkw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f47de272-e977-45e9-9417-fd0182864796", "AQAAAAIAAYagAAAAEGqETzbybD5drWa3xOiQPQ6J8TBgcA1iJxK/zv9SdvFvTZmr9xsLp34FLI0669zdnQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d056582-a252-4af0-97a9-35f0d40d9608", "AQAAAAIAAYagAAAAEOBlFkRyysZFYj9Ujtj6hRfipJMduRKvsxZT6fGhWkvI0Qzow2zOBD49+Zitk9KzTw==", null });
        }
    }
}

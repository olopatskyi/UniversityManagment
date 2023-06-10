using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisciplineSwitcher.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangePermissionNameConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "ClaimType",
                value: "get:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "ClaimType",
                value: "create:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "ClaimType",
                value: "delete:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "ClaimType",
                value: "update:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "ClaimType",
                value: "get:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "ClaimType",
                value: "create:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "ClaimType",
                value: "delete:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "ClaimType",
                value: "update:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "ClaimType",
                value: "get:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "ClaimType",
                value: "create:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "ClaimType",
                value: "delete:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "ClaimType",
                value: "update:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 61,
                column: "ClaimType",
                value: "get:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 62,
                column: "ClaimType",
                value: "create:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 63,
                column: "ClaimType",
                value: "delete:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 64,
                column: "ClaimType",
                value: "update:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 65,
                column: "ClaimType",
                value: "get:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 66,
                column: "ClaimType",
                value: "create:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 67,
                column: "ClaimType",
                value: "delete:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 68,
                column: "ClaimType",
                value: "update:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 69,
                column: "ClaimType",
                value: "get:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 70,
                column: "ClaimType",
                value: "create:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 71,
                column: "ClaimType",
                value: "delete:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 72,
                column: "ClaimType",
                value: "get:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 73,
                column: "ClaimType",
                value: "update:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 74,
                column: "ClaimType",
                value: "get:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 75,
                column: "ClaimType",
                value: "create:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 76,
                column: "ClaimType",
                value: "update:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 77,
                column: "ClaimType",
                value: "delete:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 78,
                column: "ClaimType",
                value: "get:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 79,
                column: "ClaimType",
                value: "create:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 80,
                column: "ClaimType",
                value: "update:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 81,
                column: "ClaimType",
                value: "delete:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 82,
                column: "ClaimType",
                value: "get:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 83,
                column: "ClaimType",
                value: "get:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 84,
                column: "ClaimType",
                value: "get:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 85,
                column: "ClaimType",
                value: "create:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 86,
                column: "ClaimType",
                value: "update:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 87,
                column: "ClaimType",
                value: "delete:group");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 88,
                column: "ClaimType",
                value: "get:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 89,
                column: "ClaimType",
                value: "create:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 90,
                column: "ClaimType",
                value: "delete:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 91,
                column: "ClaimType",
                value: "update:student");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 92,
                column: "ClaimType",
                value: "get:teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 93,
                column: "ClaimType",
                value: "get:discipline");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 94,
                column: "ClaimType",
                value: "get:faculty");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 95,
                column: "ClaimType",
                value: "get:semester");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 96,
                column: "ClaimType",
                value: "get:group");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "ClaimType",
                value: "student:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "ClaimType",
                value: "student:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "ClaimType",
                value: "student:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "ClaimType",
                value: "student:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "ClaimType",
                value: "teacher:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "ClaimType",
                value: "teacher:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "ClaimType",
                value: "teacher:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "ClaimType",
                value: "teacher:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "ClaimType",
                value: "discipline:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "ClaimType",
                value: "discipline:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "ClaimType",
                value: "discipline:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "ClaimType",
                value: "discipline:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 61,
                column: "ClaimType",
                value: "faculty:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 62,
                column: "ClaimType",
                value: "faculty:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 63,
                column: "ClaimType",
                value: "faculty:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 64,
                column: "ClaimType",
                value: "faculty:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 65,
                column: "ClaimType",
                value: "semester:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 66,
                column: "ClaimType",
                value: "semester:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 67,
                column: "ClaimType",
                value: "semester:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 68,
                column: "ClaimType",
                value: "semester:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 69,
                column: "ClaimType",
                value: "group:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 70,
                column: "ClaimType",
                value: "group:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 71,
                column: "ClaimType",
                value: "group:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 72,
                column: "ClaimType",
                value: "student:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 73,
                column: "ClaimType",
                value: "student:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 74,
                column: "ClaimType",
                value: "teacher:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 75,
                column: "ClaimType",
                value: "teacher:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 76,
                column: "ClaimType",
                value: "teacher:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 77,
                column: "ClaimType",
                value: "teacher:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 78,
                column: "ClaimType",
                value: "discipline:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 79,
                column: "ClaimType",
                value: "discipline:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 80,
                column: "ClaimType",
                value: "discipline:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 81,
                column: "ClaimType",
                value: "discipline:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 82,
                column: "ClaimType",
                value: "faculty:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 83,
                column: "ClaimType",
                value: "semester:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 84,
                column: "ClaimType",
                value: "group:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 85,
                column: "ClaimType",
                value: "group:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 86,
                column: "ClaimType",
                value: "group:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 87,
                column: "ClaimType",
                value: "group:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 88,
                column: "ClaimType",
                value: "student:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 89,
                column: "ClaimType",
                value: "student:create");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 90,
                column: "ClaimType",
                value: "student:delete");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 91,
                column: "ClaimType",
                value: "student:update");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 92,
                column: "ClaimType",
                value: "teacher:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 93,
                column: "ClaimType",
                value: "discipline:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 94,
                column: "ClaimType",
                value: "faculty:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 95,
                column: "ClaimType",
                value: "semester:get");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 96,
                column: "ClaimType",
                value: "group:get");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537826d9-90b5-4d70-9606-addbd078d509"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26c8f946-0ace-4e40-aa0a-904cad133d5a", "AQAAAAIAAYagAAAAEAJovClLV1kVqnaqy3ugAxGSx5Wjdh2rMnEW7AWgpNG+NSSwxVcCtRNLEjCFdlAG0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bded3de8-0e1c-4b77-9ff3-68f44fc04020", "AQAAAAIAAYagAAAAELJBE7rHYMnGA2lMhtFGCXWJogSdMlypY12/Sa69idXSSLVFKpvkHuKiin/yJsFp8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f96057e4-d034-48c8-a5a3-14065567b669", "AQAAAAIAAYagAAAAEO706KEGCy0l1rsTQK/rni0lXoej250koSlPCjieVP1QZxz5j9EZ4uK6ebIWiYVfaQ==" });
        }
    }
}

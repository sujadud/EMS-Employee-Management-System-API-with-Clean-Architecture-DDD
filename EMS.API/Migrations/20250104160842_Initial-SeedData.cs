using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeCode", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), "E001", "Md. Sujad-ud Doula", 35000.00m },
                    { new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), "E002", "John Doe", 50000.00m }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "Date", "EmployeeId", "Status" },
                values: new object[,]
                {
                    { new Guid("30a66e72-88bf-4e1c-b358-bb11aaf02505"), new DateTime(2025, 1, 4, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4092), new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), 1 },
                    { new Guid("3694941f-c9f9-4d7a-ae74-b417781670c3"), new DateTime(2025, 1, 1, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4098), new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), 0 },
                    { new Guid("4510953c-aead-4a2e-91e8-4f006a3beda8"), new DateTime(2025, 1, 2, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4051), new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), 0 },
                    { new Guid("6af4a763-1545-4888-bb9a-7a29ed2558db"), new DateTime(2025, 1, 4, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4105), new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), 1 },
                    { new Guid("a49f3ea0-5522-43c8-98ce-509eb522d166"), new DateTime(2024, 12, 31, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4096), new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), 1 },
                    { new Guid("ba2e79dc-2274-444b-bcec-6a56c7caa65b"), new DateTime(2024, 12, 31, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4085), new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), 0 },
                    { new Guid("d7677131-1818-48ed-b048-bf35fe2db204"), new DateTime(2025, 1, 3, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4090), new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), 2 },
                    { new Guid("dd1abaff-4c5d-4599-8b95-e32e5bf72f96"), new DateTime(2025, 1, 2, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4094), new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), 0 },
                    { new Guid("f3357838-b8a8-4d0b-a504-007d5bc49bbf"), new DateTime(2025, 1, 1, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4088), new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), 0 },
                    { new Guid("ff96918b-b392-44fb-a4b7-c0f4ed63856e"), new DateTime(2025, 1, 3, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4100), new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("30a66e72-88bf-4e1c-b358-bb11aaf02505"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3694941f-c9f9-4d7a-ae74-b417781670c3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4510953c-aead-4a2e-91e8-4f006a3beda8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6af4a763-1545-4888-bb9a-7a29ed2558db"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a49f3ea0-5522-43c8-98ce-509eb522d166"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ba2e79dc-2274-444b-bcec-6a56c7caa65b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("d7677131-1818-48ed-b048-bf35fe2db204"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("dd1abaff-4c5d-4599-8b95-e32e5bf72f96"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f3357838-b8a8-4d0b-a504-007d5bc49bbf"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ff96918b-b392-44fb-a4b7-c0f4ed63856e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"));
        }
    }
}

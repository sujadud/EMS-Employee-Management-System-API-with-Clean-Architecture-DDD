using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdateFluentAPIRelationshipConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeCode", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), "E002", "John Doe", 50000.00m },
                    { new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), "E001", "Md. Sujad-ud Doula", 35000.00m }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "Date", "EmployeeId", "Status" },
                values: new object[,]
                {
                    { new Guid("04e85637-51a2-4c67-8d69-cc99ed67caae"), new DateTime(2025, 1, 4, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8261), new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), 0 },
                    { new Guid("2f80bfa7-c328-4585-8731-a2480befb140"), new DateTime(2025, 1, 5, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8172), new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), 0 },
                    { new Guid("3b2fb565-18e7-4efa-a2a1-d1d89341e63d"), new DateTime(2025, 1, 6, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8243), new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), 2 },
                    { new Guid("3f40815b-6570-479b-9900-6be47ca7dcfe"), new DateTime(2025, 1, 6, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8267), new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), 2 },
                    { new Guid("4b8a5ebd-8c83-43cb-91e6-309e16d9fd01"), new DateTime(2025, 1, 3, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8258), new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), 1 },
                    { new Guid("503530a7-db1d-44c2-92fc-38b70c823e27"), new DateTime(2025, 1, 7, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8249), new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), 1 },
                    { new Guid("beb7c4bc-b6d4-4b1d-b0e0-bcdbbe52e8bf"), new DateTime(2025, 1, 5, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8252), new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), 0 },
                    { new Guid("d020971a-025e-44b8-92ec-ef85e1dc14e5"), new DateTime(2025, 1, 4, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8210), new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), 0 },
                    { new Guid("d4455b99-0c70-48ab-a788-df9540994b03"), new DateTime(2025, 1, 3, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8203), new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"), 0 },
                    { new Guid("e1b25349-3482-477a-bfe4-547855f126aa"), new DateTime(2025, 1, 7, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8270), new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("04e85637-51a2-4c67-8d69-cc99ed67caae"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2f80bfa7-c328-4585-8731-a2480befb140"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3b2fb565-18e7-4efa-a2a1-d1d89341e63d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3f40815b-6570-479b-9900-6be47ca7dcfe"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4b8a5ebd-8c83-43cb-91e6-309e16d9fd01"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("503530a7-db1d-44c2-92fc-38b70c823e27"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("beb7c4bc-b6d4-4b1d-b0e0-bcdbbe52e8bf"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("d020971a-025e-44b8-92ec-ef85e1dc14e5"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("d4455b99-0c70-48ab-a788-df9540994b03"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e1b25349-3482-477a-bfe4-547855f126aa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeCode", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"), "E002", "John Doe", 50000.00m },
                    { new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"), "E001", "Md. Sujad-ud Doula", 35000.00m }
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
    }
}

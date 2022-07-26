using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireMeApi.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IotDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("692d1515-ee4b-497c-8151-733e292dbe47"), "This is a very long description about device 3", "Device 3" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("700e4109-d340-4316-9c39-8c0b64c60fd4"), "This is a very long description about device 9", "Device 9" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("83682980-59b1-4784-97df-260ced1f8d5e"), "This is a very long description about device 2", "Device 2" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("85a9f92e-1869-4a53-be14-17baeea0b3ca"), "This is a very long description about device 4", "Device 4" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("bafa65a7-1865-4478-9f18-836640e7395b"), "This is a very long description about device 7", "Device 7" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("bb35d8af-352d-4387-9b3e-925e97506020"), "This is a very long description about device 10", "Device 10" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("bedb5752-53c9-4723-9cb1-c68803e40f34"), "This is a very long description about device 8", "Device 8" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("c9994f3c-96e8-491a-b6ac-18150707c154"), "This is a very long description about device 6", "Device 6" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("d96dd728-f987-4d0b-b070-15d5b51276f9"), "This is a very long description about device 1", "Device 1" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("fb6eca2d-878b-4828-abfc-83bb43609a40"), "This is a very long description about device 5", "Device 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IotDevices");
        }
    }
}

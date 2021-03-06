﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage_2._0_MPT.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 31, 15, 7, 43, 976, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 15, 7, 43, 976, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkInDate", "ParkOutDate" },
                values: new object[] { new DateTime(2019, 1, 28, 15, 7, 43, 976, DateTimeKind.Local).AddTicks(9557), new DateTime(2019, 1, 30, 14, 10, 2, 976, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 31, 14, 7, 43, 976, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 14, 7, 43, 976, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 6,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 28, 15, 7, 43, 976, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 7,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 31, 15, 7, 42, 976, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 8,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 15, 7, 41, 976, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 9,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 28, 15, 7, 40, 976, DateTimeKind.Local).AddTicks(9653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 8, 43, 7, 582, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 29, 8, 43, 7, 582, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkInDate", "ParkOutDate" },
                values: new object[] { new DateTime(2019, 1, 27, 8, 43, 7, 582, DateTimeKind.Local).AddTicks(9800), new DateTime(2019, 1, 29, 7, 45, 26, 582, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 7, 43, 7, 582, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 29, 7, 43, 7, 582, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 6,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 27, 8, 43, 7, 582, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 7,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 30, 8, 43, 6, 582, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 8,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 29, 8, 43, 5, 582, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 9,
                column: "ParkInDate",
                value: new DateTime(2019, 1, 27, 8, 43, 4, 582, DateTimeKind.Local).AddTicks(9896));
        }
    }
}

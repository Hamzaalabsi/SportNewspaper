using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class BB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(6746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 372, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 372, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 426, DateTimeKind.Local).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 371, DateTimeKind.Local).AddTicks(4004));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 372, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 372, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 28, 18, 58, 21, 371, DateTimeKind.Local).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 426, DateTimeKind.Local).AddTicks(2483));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class Updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 981, DateTimeKind.Local).AddTicks(1923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 180, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 980, DateTimeKind.Local).AddTicks(633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 179, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 979, DateTimeKind.Local).AddTicks(2824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 178, DateTimeKind.Local).AddTicks(7305));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 180, DateTimeKind.Local).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 981, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 179, DateTimeKind.Local).AddTicks(4596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 980, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 178, DateTimeKind.Local).AddTicks(7305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 979, DateTimeKind.Local).AddTicks(2824));
        }
    }
}

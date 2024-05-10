using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 219, DateTimeKind.Local).AddTicks(774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 380, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 217, DateTimeKind.Local).AddTicks(2495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 216, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(2447));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 380, DateTimeKind.Local).AddTicks(786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 219, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(9574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 217, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 19, 23, 3, 216, DateTimeKind.Local).AddTicks(3931));
        }
    }
}

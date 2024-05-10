using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class kk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 380, DateTimeKind.Local).AddTicks(786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 981, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(9574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 980, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 979, DateTimeKind.Local).AddTicks(2824));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 981, DateTimeKind.Local).AddTicks(1923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 380, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 980, DateTimeKind.Local).AddTicks(633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 58, 12, 979, DateTimeKind.Local).AddTicks(2824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(2447));
        }
    }
}

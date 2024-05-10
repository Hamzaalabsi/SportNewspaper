using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class cc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 180, DateTimeKind.Local).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 179, DateTimeKind.Local).AddTicks(4596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.AlterColumn<int>(
                name: "CompetaitionId",
                table: "news",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 178, DateTimeKind.Local).AddTicks(7305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 426, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.AddForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news",
                column: "CompetaitionId",
                principalTable: "competaitions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(6746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 180, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 429, DateTimeKind.Local).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 179, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.AlterColumn<int>(
                name: "CompetaitionId",
                table: "news",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "matches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 29, 1, 26, 38, 426, DateTimeKind.Local).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 29, 1, 37, 29, 178, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.AddForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news",
                column: "CompetaitionId",
                principalTable: "competaitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

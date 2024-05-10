using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class AddRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 233, DateTimeKind.Local).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "userSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "userSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "teamsMatshs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 232, DateTimeKind.Local).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "teamsMatshs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "teamsMatshs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 233, DateTimeKind.Local).AddTicks(3193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "teamNews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "teamNews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompetaitionId",
                table: "news",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompetaitionId",
                table: "competaitionTems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemsId",
                table: "competaitionTems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_userSubscriptions_SubscriptionId",
                table: "userSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_userSubscriptions_UserId",
                table: "userSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_teamsMatshs_MatchId",
                table: "teamsMatshs",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_teamsMatshs_TeamId",
                table: "teamsMatshs",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_teamNews_NewsId",
                table: "teamNews",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_teamNews_TeamId",
                table: "teamNews",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_news_CompetaitionId",
                table: "news",
                column: "CompetaitionId");

            migrationBuilder.CreateIndex(
                name: "IX_competaitionTems_CompetaitionId",
                table: "competaitionTems",
                column: "CompetaitionId");

            migrationBuilder.CreateIndex(
                name: "IX_competaitionTems_TemsId",
                table: "competaitionTems",
                column: "TemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_competaitionTems_competaitions_CompetaitionId",
                table: "competaitionTems",
                column: "CompetaitionId",
                principalTable: "competaitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_competaitionTems_teams_TemsId",
                table: "competaitionTems",
                column: "TemsId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news",
                column: "CompetaitionId",
                principalTable: "competaitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teamNews_news_NewsId",
                table: "teamNews",
                column: "NewsId",
                principalTable: "news",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teamNews_teams_TeamId",
                table: "teamNews",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teamsMatshs_matches_MatchId",
                table: "teamsMatshs",
                column: "MatchId",
                principalTable: "matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teamsMatshs_teams_TeamId",
                table: "teamsMatshs",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userSubscriptions_subscriptions_SubscriptionId",
                table: "userSubscriptions",
                column: "SubscriptionId",
                principalTable: "subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userSubscriptions_users_UserId",
                table: "userSubscriptions",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_competaitionTems_competaitions_CompetaitionId",
                table: "competaitionTems");

            migrationBuilder.DropForeignKey(
                name: "FK_competaitionTems_teams_TemsId",
                table: "competaitionTems");

            migrationBuilder.DropForeignKey(
                name: "FK_news_competaitions_CompetaitionId",
                table: "news");

            migrationBuilder.DropForeignKey(
                name: "FK_teamNews_news_NewsId",
                table: "teamNews");

            migrationBuilder.DropForeignKey(
                name: "FK_teamNews_teams_TeamId",
                table: "teamNews");

            migrationBuilder.DropForeignKey(
                name: "FK_teamsMatshs_matches_MatchId",
                table: "teamsMatshs");

            migrationBuilder.DropForeignKey(
                name: "FK_teamsMatshs_teams_TeamId",
                table: "teamsMatshs");

            migrationBuilder.DropForeignKey(
                name: "FK_userSubscriptions_subscriptions_SubscriptionId",
                table: "userSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_userSubscriptions_users_UserId",
                table: "userSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_userSubscriptions_SubscriptionId",
                table: "userSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_userSubscriptions_UserId",
                table: "userSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_teamsMatshs_MatchId",
                table: "teamsMatshs");

            migrationBuilder.DropIndex(
                name: "IX_teamsMatshs_TeamId",
                table: "teamsMatshs");

            migrationBuilder.DropIndex(
                name: "IX_teamNews_NewsId",
                table: "teamNews");

            migrationBuilder.DropIndex(
                name: "IX_teamNews_TeamId",
                table: "teamNews");

            migrationBuilder.DropIndex(
                name: "IX_news_CompetaitionId",
                table: "news");

            migrationBuilder.DropIndex(
                name: "IX_competaitionTems_CompetaitionId",
                table: "competaitionTems");

            migrationBuilder.DropIndex(
                name: "IX_competaitionTems_TemsId",
                table: "competaitionTems");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "userSubscriptions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "userSubscriptions");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "teamsMatshs");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "teamsMatshs");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "teamNews");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "teamNews");

            migrationBuilder.DropColumn(
                name: "CompetaitionId",
                table: "news");

            migrationBuilder.DropColumn(
                name: "CompetaitionId",
                table: "competaitionTems");

            migrationBuilder.DropColumn(
                name: "TemsId",
                table: "competaitionTems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "userSubscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(9505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 233, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "teamsMatshs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(7185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 232, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "teamNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(8369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 26, 8, 7, 3, 233, DateTimeKind.Local).AddTicks(3193));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
                    table.CheckConstraint("Ch_Admin_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");
                    table.CheckConstraint("Ch_Admin_Name", "len(Name)>5");
                    table.CheckConstraint("Ch_Admin_Password", "LEN(password) >= 8 AND LEN(password) <= 16");
                    table.CheckConstraint("Ch_Admin_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))");
                });

            migrationBuilder.CreateTable(
                name: "competaitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    continent = table.Column<int>(type: "int", nullable: false),
                    sports = table.Column<int>(type: "int", nullable: false),
                    countries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competaitions", x => x.Id);
                    table.CheckConstraint("CH_Competaition_Name", "len(Name)>5");
                });

            migrationBuilder.CreateTable(
                name: "competaitionTems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competaitionTems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StadiumName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefereeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsImportant = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    continent = table.Column<int>(type: "int", nullable: false),
                    sports = table.Column<int>(type: "int", nullable: false),
                    countries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VedeoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImportant = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    continent = table.Column<int>(type: "int", nullable: false),
                    sports = table.Column<int>(type: "int", nullable: false),
                    countries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    subscriptionType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => x.Id);
                    table.CheckConstraint("Ch_Subscription_price", "Price>=0");
                });

            migrationBuilder.CreateTable(
                name: "teamNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(8369))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FoundingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoachName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    continent = table.Column<int>(type: "int", nullable: false),
                    sports = table.Column<int>(type: "int", nullable: false),
                    countries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                    table.CheckConstraint("CH_Competaition_Name1", "len(Name)>5");
                });

            migrationBuilder.CreateTable(
                name: "teamsMatshs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(7185))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamsMatshs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.CheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");
                    table.CheckConstraint("CH_User_Name", "len(Name)>5");
                    table.CheckConstraint("CH_User_Password", "LEN(password) >= 8 AND LEN(password) <= 16");
                    table.CheckConstraint("ch_User_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))");
                });

            migrationBuilder.CreateTable(
                name: "userSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 26, 7, 49, 11, 922, DateTimeKind.Local).AddTicks(9505))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_admins_Email",
                table: "admins",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_admins_PhoneNumber",
                table: "admins",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_competaitions_Name",
                table: "competaitions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_Name",
                table: "teams",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_PhoneNumber",
                table: "users",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "competaitions");

            migrationBuilder.DropTable(
                name: "competaitionTems");

            migrationBuilder.DropTable(
                name: "matches");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "subscriptions");

            migrationBuilder.DropTable(
                name: "teamNews");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "teamsMatshs");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "userSubscriptions");
        }
    }
}

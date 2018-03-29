using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Benediction = table.Column<string>(nullable: true),
                    ClosingHymn = table.Column<string>(nullable: true),
                    Conducting = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Invocation = table.Column<string>(nullable: true),
                    OpeningHymn = table.Column<string>(nullable: true),
                    Presiding = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    SacramentPrayer = table.Column<string>(nullable: true),
                    SpeakerOne = table.Column<string>(nullable: true),
                    SpeakerThree = table.Column<string>(nullable: true),
                    SpeakerTwo = table.Column<string>(nullable: true),
                    TopicOne = table.Column<string>(nullable: true),
                    TopicThree = table.Column<string>(nullable: true),
                    TopicTwo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}

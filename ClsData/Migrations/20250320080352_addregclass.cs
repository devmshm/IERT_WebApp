using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClsData.Migrations
{
    /// <inheritdoc />
    public partial class addregclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidate_doc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thumb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate_doc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personal_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mother_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    domicile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    caste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    income = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personal_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passed_year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_marks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obt_marks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    college = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qualification", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidate_doc");

            migrationBuilder.DropTable(
                name: "personal_Details");

            migrationBuilder.DropTable(
                name: "qualification");
        }
    }
}

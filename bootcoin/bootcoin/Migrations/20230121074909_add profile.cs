using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootcoin.Migrations
{
    /// <inheritdoc />
    public partial class addprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "profile",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Mbti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zodiac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunFact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profile", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_profile_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_profile_UserId",
                table: "profile",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profile");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user",
                newName: "Id");
        }
    }
}
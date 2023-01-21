using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootcoin.Migrations
{
    /// <inheritdoc />
    public partial class oneusertooneprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_user_UserId",
                table: "profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_profile",
                table: "profile");

            migrationBuilder.DropIndex(
                name: "IX_profile_UserId",
                table: "profile");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "profile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_profile",
                table: "profile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_profile_UserId1",
                table: "profile",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_profile_user_UserId1",
                table: "profile",
                column: "UserId1",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_user_UserId1",
                table: "profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_profile",
                table: "profile");

            migrationBuilder.DropIndex(
                name: "IX_profile_UserId1",
                table: "profile");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "profile");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profile",
                table: "profile",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_profile_UserId",
                table: "profile",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_profile_user_UserId",
                table: "profile",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

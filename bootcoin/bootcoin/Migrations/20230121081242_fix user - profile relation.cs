using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootcoin.Migrations
{
    /// <inheritdoc />
    public partial class fixuserprofilerelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_user_UserId1",
                table: "profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_profile",
                table: "profile");

            migrationBuilder.DropIndex(
                name: "IX_profile_UserId1",
                table: "profile");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "profile");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "profile",
                newName: "Profile");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                columns: new[] { "ProfileId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_UserId",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "profile");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "profile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "UserId");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootcoin.Migrations
{
    /// <inheritdoc />
    public partial class fixusertransactionrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetail_TransactionHeader_TransactionId",
                table: "TransactionDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionHeader",
                table: "TransactionHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDetail",
                table: "TransactionDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TransactionHeader",
                newName: "TransactionHeaders");

            migrationBuilder.RenameTable(
                name: "TransactionDetail",
                newName: "TransactionDetails");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_UserId",
                table: "Profiles",
                newName: "IX_Profiles_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionHeaders",
                table: "TransactionHeaders",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDetails",
                table: "TransactionDetails",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                columns: new[] { "ProfileId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHeaders_SourceId",
                table: "TransactionHeaders",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHeaders_TargetId",
                table: "TransactionHeaders",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_TransactionHeaders_TransactionId",
                table: "TransactionDetails",
                column: "TransactionId",
                principalTable: "TransactionHeaders",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHeaders_Users_SourceId",
                table: "TransactionHeaders",
                column: "SourceId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHeaders_Users_TargetId",
                table: "TransactionHeaders",
                column: "TargetId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_TransactionHeaders_TransactionId",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHeaders_Users_SourceId",
                table: "TransactionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHeaders_Users_TargetId",
                table: "TransactionHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionHeaders",
                table: "TransactionHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHeaders_SourceId",
                table: "TransactionHeaders");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHeaders_TargetId",
                table: "TransactionHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDetails",
                table: "TransactionDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TransactionHeaders",
                newName: "TransactionHeader");

            migrationBuilder.RenameTable(
                name: "TransactionDetails",
                newName: "TransactionDetail");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profile");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_UserId",
                table: "Profile",
                newName: "IX_Profile_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionHeader",
                table: "TransactionHeader",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDetail",
                table: "TransactionDetail",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                columns: new[] { "ProfileId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetail_TransactionHeader_TransactionId",
                table: "TransactionDetail",
                column: "TransactionId",
                principalTable: "TransactionHeader",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

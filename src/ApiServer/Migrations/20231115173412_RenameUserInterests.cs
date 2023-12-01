using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiServer.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserInterests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInterests_ProductGroups_ProductId",
                table: "UserInterests");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "UserInterests",
                newName: "InterestId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInterests_ProductId",
                table: "UserInterests",
                newName: "IX_UserInterests_InterestId");

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterests_Interests_InterestId",
                table: "UserInterests",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInterests_Interests_InterestId",
                table: "UserInterests");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.RenameColumn(
                name: "InterestId",
                table: "UserInterests",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInterests_InterestId",
                table: "UserInterests",
                newName: "IX_UserInterests_ProductId");

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterests_ProductGroups_ProductId",
                table: "UserInterests",
                column: "ProductId",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

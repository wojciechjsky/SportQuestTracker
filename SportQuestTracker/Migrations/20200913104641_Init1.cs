using Microsoft.EntityFrameworkCore.Migrations;

namespace SportQuestTracker.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TransactionId",
                table: "Companies",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Transactions_TransactionId",
                table: "Companies",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Transactions_TransactionId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_TransactionId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Companies");
        }
    }
}

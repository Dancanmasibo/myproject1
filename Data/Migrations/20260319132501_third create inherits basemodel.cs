using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myproject1.Migrations
{
    /// <inheritdoc />
    public partial class thirdcreateinheritsbasemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");


            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "Expenses");


            migrationBuilder.AddColumn<int>(
                name: "ExpenseId",
                table: "Expenses",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");


            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");


            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Expenses");

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseId",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "ExpenseId");
        }
    }
}

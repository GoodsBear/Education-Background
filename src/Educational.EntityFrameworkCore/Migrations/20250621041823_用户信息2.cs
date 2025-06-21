using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational.Migrations
{
    /// <inheritdoc />
    public partial class 用户信息2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_staffInfos",
                table: "staffInfos");

            migrationBuilder.RenameTable(
                name: "staffInfos",
                newName: "Educational_StaffInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educational_StaffInfo",
                table: "Educational_StaffInfo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Educational_StaffInfo",
                table: "Educational_StaffInfo");

            migrationBuilder.RenameTable(
                name: "Educational_StaffInfo",
                newName: "staffInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffInfos",
                table: "staffInfos",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerTestIis.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cyberQi",
                table: "CyberBrains",
                newName: "CyberQi");

            migrationBuilder.InsertData(
                table: "CyberBrains",
                columns: new[] { "Id", "Cost", "CyberQi", "Label" },
                values: new object[,]
                {
                    { 11, 567, 120, "SpeedResponseAlgebra-6700" },
                    { 12, 845, 132, "Alpha-One-77TT" },
                    { 13, 1234, 160, "Razor-flight-500" },
                    { 14, 1409, 205, "SRAlgebra2-9900" },
                    { 15, 7172, 320, "Futuratron-tronic-ct56" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CyberBrains",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CyberBrains",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CyberBrains",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CyberBrains",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CyberBrains",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.RenameColumn(
                name: "CyberQi",
                table: "CyberBrains",
                newName: "cyberQi");
        }
    }
}

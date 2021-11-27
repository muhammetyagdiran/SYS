using Microsoft.EntityFrameworkCore.Migrations;

namespace SYS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SporcuBilgiler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", nullable: true),
                    Soyad = table.Column<string>(type: "varchar(50)", nullable: true),
                    DogumYeri = table.Column<string>(type: "varchar(50)", nullable: true),
                    DogumTarihi = table.Column<string>(type: "varchar(50)", nullable: true),
                    EvTelefon = table.Column<string>(type: "varchar(50)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    EvAdresi = table.Column<string>(type: "varchar(250)", nullable: true),
                    KanGrubu = table.Column<string>(type: "varchar(50)", nullable: true),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    OkuduguOkul = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporcuBilgiler", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SporcuBilgiler");
        }
    }
}

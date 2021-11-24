using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExportGarPostgreSQLCore.Migrations
{
    public partial class ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "b4_gar_addr_obj",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    objectid = table.Column<long>(type: "bigint", nullable: false),
                    objectguid = table.Column<Guid>(type: "uuid", nullable: false),
                    changeid = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    typename = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<string>(type: "text", nullable: true),
                    opertypeid = table.Column<int>(type: "integer", nullable: false),
                    previd = table.Column<long>(type: "bigint", nullable: false),
                    nextid = table.Column<long>(type: "bigint", nullable: false),
                    updatedate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    startdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    enddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isactual = table.Column<int>(type: "integer", nullable: false),
                    isactive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b4_gar_addr_obj", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "b4_gar_adm_hierchy",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    objectid = table.Column<long>(type: "bigint", nullable: false),
                    parentobjid = table.Column<long>(type: "bigint", nullable: false),
                    changeid = table.Column<long>(type: "bigint", nullable: false),
                    regioncode = table.Column<string>(type: "text", nullable: true),
                    areacode = table.Column<string>(type: "text", nullable: true),
                    citycode = table.Column<string>(type: "text", nullable: true),
                    placecode = table.Column<string>(type: "text", nullable: true),
                    plancode = table.Column<string>(type: "text", nullable: true),
                    streetcode = table.Column<string>(type: "text", nullable: true),
                    previd = table.Column<long>(type: "bigint", nullable: false),
                    nextid = table.Column<long>(type: "bigint", nullable: false),
                    updatedate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    startdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    enddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isactive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b4_gar_adm_hierchy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "b4_gar_houses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    objectid = table.Column<long>(type: "bigint", nullable: false),
                    objectguid = table.Column<Guid>(type: "uuid", nullable: false),
                    changeid = table.Column<long>(type: "bigint", nullable: false),
                    housenum = table.Column<string>(type: "text", nullable: true),
                    addnum1 = table.Column<string>(type: "text", nullable: true),
                    addnum2 = table.Column<string>(type: "text", nullable: true),
                    housetype = table.Column<int>(type: "integer", nullable: true),
                    addtype1 = table.Column<int>(type: "integer", nullable: true),
                    addtype2 = table.Column<int>(type: "integer", nullable: true),
                    opertypeid = table.Column<int>(type: "integer", nullable: true),
                    previd = table.Column<long>(type: "bigint", nullable: false),
                    nextid = table.Column<long>(type: "bigint", nullable: false),
                    updatedate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    startdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    enddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isactual = table.Column<int>(type: "integer", nullable: false),
                    isactive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b4_gar_houses", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "b4_gar_addr_obj");

            migrationBuilder.DropTable(
                name: "b4_gar_adm_hierchy");

            migrationBuilder.DropTable(
                name: "b4_gar_houses");
        }
    }
}

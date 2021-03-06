// <auto-generated />
using System;
using ExportGarPostgreSQLCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExportGarPostgreSQLCore.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ExportGarPostgreSQLCore.FromADDRXML", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("changeid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("enddate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("isactive")
                        .HasColumnType("integer");

                    b.Property<int>("isactual")
                        .HasColumnType("integer");

                    b.Property<string>("level")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<long>("nextid")
                        .HasColumnType("bigint");

                    b.Property<Guid>("objectguid")
                        .HasColumnType("uuid");

                    b.Property<long>("objectid")
                        .HasColumnType("bigint");

                    b.Property<int>("opertypeid")
                        .HasColumnType("integer");

                    b.Property<long>("previd")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("startdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("typename")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("b4_gar_addr_obj");
                });

            modelBuilder.Entity("ExportGarPostgreSQLCore.FromADMINHIERXML", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("areacode")
                        .HasColumnType("text");

                    b.Property<long>("changeid")
                        .HasColumnType("bigint");

                    b.Property<string>("citycode")
                        .HasColumnType("text");

                    b.Property<DateTime>("enddate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("isactive")
                        .HasColumnType("integer");

                    b.Property<long>("nextid")
                        .HasColumnType("bigint");

                    b.Property<long>("objectid")
                        .HasColumnType("bigint");

                    b.Property<long>("parentobjid")
                        .HasColumnType("bigint");

                    b.Property<string>("placecode")
                        .HasColumnType("text");

                    b.Property<string>("plancode")
                        .HasColumnType("text");

                    b.Property<long>("previd")
                        .HasColumnType("bigint");

                    b.Property<string>("regioncode")
                        .HasColumnType("text");

                    b.Property<DateTime>("startdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("streetcode")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.ToTable("b4_gar_adm_hierchy");
                });

            modelBuilder.Entity("ExportGarPostgreSQLCore.FromHouseXML", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("addnum1")
                        .HasColumnType("text");

                    b.Property<string>("addnum2")
                        .HasColumnType("text");

                    b.Property<int?>("addtype1")
                        .HasColumnType("integer");

                    b.Property<int?>("addtype2")
                        .HasColumnType("integer");

                    b.Property<long>("changeid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("enddate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("housenum")
                        .HasColumnType("text");

                    b.Property<int?>("housetype")
                        .HasColumnType("integer");

                    b.Property<int>("isactive")
                        .HasColumnType("integer");

                    b.Property<int>("isactual")
                        .HasColumnType("integer");

                    b.Property<long>("nextid")
                        .HasColumnType("bigint");

                    b.Property<Guid>("objectguid")
                        .HasColumnType("uuid");

                    b.Property<long>("objectid")
                        .HasColumnType("bigint");

                    b.Property<int?>("opertypeid")
                        .HasColumnType("integer");

                    b.Property<long>("previd")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("startdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("b4_gar_houses");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academias",
                columns: table => new
                {
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademiaNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academias", x => x.AcademiaId);
                });

            migrationBuilder.CreateTable(
                name: "DireccionEntity",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionCalle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DireccionNoExt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionNoInt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionCp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionMunicipio = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionEntity", x => x.DireccionId);
                });

            migrationBuilder.CreateTable(
                name: "Plazas",
                columns: table => new
                {
                    PlazaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlazaTipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plazas", x => x.PlazaId);
                });

            migrationBuilder.CreateTable(
                name: "Planteles",
                columns: table => new
                {
                    PlantelId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantelNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planteles", x => x.PlantelId);
                    table.ForeignKey(
                        name: "FK_Planteles_DireccionEntity_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "DireccionEntity",
                        principalColumn: "DireccionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    TrabajadorNomina = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    TrabajadorRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrabajadorNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorApPaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorApMaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorCurp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorTelefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorCelular = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlantelId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    PlazaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.TrabajadorNomina);
                    table.ForeignKey(
                        name: "FK_Trabajadores_DireccionEntity_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "DireccionEntity",
                        principalColumn: "DireccionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trabajadores_Planteles_PlantelId",
                        column: x => x.PlantelId,
                        principalTable: "Planteles",
                        principalColumn: "PlantelId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Trabajadores_Plazas_PlazaId",
                        column: x => x.PlazaId,
                        principalTable: "Plazas",
                        principalColumn: "PlazaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jefes",
                columns: table => new
                {
                    JefeId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jefes", x => x.JefeId);
                    table.ForeignKey(
                        name: "FK_Jefes_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "AcademiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jefes_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    PuestoId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlazaFechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.PuestoId);
                    table.ForeignKey(
                        name: "FK_Puestos_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "AcademiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Puestos_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermisoTipo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PermisoFechaElaboracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoFechaAplicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoFechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoMotivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermisoEstado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    JefeInmediatoId = table.Column<int>(type: "int", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK_Permisos_Jefes_JefeInmediatoId",
                        column: x => x.JefeInmediatoId,
                        principalTable: "Jefes",
                        principalColumn: "JefeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permisos_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Academias",
                columns: new[] { "AcademiaId", "AcademiaNombre" },
                values: new object[,]
                {
                    { 1, "Computacion" },
                    { 2, "Redes y sistemas" },
                    { 3, "Informatica" }
                });

            migrationBuilder.InsertData(
                table: "DireccionEntity",
                columns: new[] { "DireccionId", "DireccionCalle", "DireccionCp", "DireccionMunicipio", "DireccionNoExt", "DireccionNoInt" },
                values: new object[,]
                {
                    { 19, "Felix Mendelssohn", "45030", "Zapopan", "5682", "" },
                    { 18, "Agustin Lara", "45037", "Zapopan", "5774", "" },
                    { 17, "Economos", "45037", "Zapopan", "5524", "" },
                    { 16, "Av Moctezuma", "45050", "Zapopan", "348", "" },
                    { 15, "Kabah", "45050", "Zapopan", "1475", "" },
                    { 14, "Av Mayas", "44670", "Gualadajara", "3322", "" },
                    { 13, "Domingo Sarmiento", "44670", "Gualadajara", "2922", "" },
                    { 12, "Calle Jose Enrique Rodo", "44670", "Gualadajara", "2783", "" },
                    { 11, "Milan", "44630", "Gualadajara", "2654", "" },
                    { 9, "Calle Montreal", "44630", "Gualadajara", "1587", "" },
                    { 8, "Calle Nicolas Romero", "44260", "Gualadajara", "1328A", "" },
                    { 7, "Avenida Alcalde", "45190", "Zapopan", "2510", "6" },
                    { 6, "Domingo de Alzola", "44220", "Gualadajara", "1134", "" },
                    { 5, "Santa Elena Alcalde", "44220", "Gualadajara", "56", "" },
                    { 4, "Salto del Agua", "44210", "Gualadajara", "2415", "" },
                    { 3, "Loma Dorada Norte", "45418", "Tonala", "8962", "" },
                    { 2, "Camino a Matatlan", "45435", "Tonala", "2400", "" },
                    { 1, "Calle Nueva Escocia", "44630", "Guadalajara", "1885", "" },
                    { 10, "Valparaiso", "44630", "Gualadajara", "2579", "" }
                });

            migrationBuilder.InsertData(
                table: "Plazas",
                columns: new[] { "PlazaId", "PlazaTipo" },
                values: new object[,]
                {
                    { 1, "fija" },
                    { 2, "no fija" }
                });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 1, 1, "CETI Colomos" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 2, 2, "CETI Rio Santiago" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 3, 3, "CETI Tonala" });

            migrationBuilder.InsertData(
                table: "Trabajadores",
                columns: new[] { "TrabajadorNomina", "DireccionId", "PlantelId", "PlazaId", "TrabajadorApMaterno", "TrabajadorApPaterno", "TrabajadorCelular", "TrabajadorCurp", "TrabajadorEmail", "TrabajadorFechaNacimiento", "TrabajadorNombre", "TrabajadorRegistro", "TrabajadorTelefono" },
                values: new object[,]
                {
                    { "836", 4, 1, 1, "GONZÁLEZ", "GÓMEZ", "3345678901", "XEXX010101MNEXXXA8", "zbins@mills.biz", new DateTime(1976, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "YESENIA", "0706901f-30a4-433e-908b-9505279e4115", "3318826414" },
                    { "520", 5, 1, 1, "LOZANO", "ABRAHAM", "3391176908", "XEXX010101HNEXXXA4", "mmoore@gmail.com", new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AKIRA", "c4e70ee4-49cd-49b7-b8fd-980ba8093138", "3372586983" },
                    { "969", 6, 1, 1, "HERNÁNDEZ", "FERRER", "3332185477", "XEXX010101MNEXXXA8", "josiah.pacocha@gmail.com", new DateTime(1983, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUSANA ELIZABETH", "9c4976f2-b47f-4e67-b753-096de2c672e2", "3319871231" },
                    { "662", 7, 1, 1, "HERNÁNDEZ", "FERRER", "3333244215", "XEXX010101MNEXXXA8", "stoltenberg.keshawn@yahoo.com", new DateTime(1984, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUSANA ELIZABETH", "96b9eb48-cf6c-48b7-b862-8398ef2e8800", "3361564758" },
                    { "870", 8, 1, 1, "DAMIAN", "GARCÍA", "3390971710", "XEXX010101HNEXXXA4", "piper33@block.org", new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "JUAN MANUEL", "8b28a9da-168c-4acf-ad1b-ce919991069a", "3389908711" },
                    { "142", 9, 2, 1, "COLIN", "SANTANA", "3387144259", "XEXX010101HNEXXXA4", "pbalistreri@gmail.com", new DateTime(1986, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "CARLOS TOMAS", "873486d1-38fd-4478-9657-130c220d0605", "3312160223" },
                    { "106", 10, 2, 1, "OYARZABAL", "PLAZA", "3341024910", "XEXX010101HNEXXXA4", "benedict73@yahoo.com", new DateTime(1987, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ERNESTO ALEJANDRO", "ff64d681-4335-4287-8d1c-9edac64dd6d3", "3363713078" },
                    { "728", 11, 2, 1, "GÓMEZ", "VARGAS", "3347681797", "XEXX010101MNEXXXA8", "abigayle.mann@gmail.com", new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AGUSTINA", "801cf1ed-cfc0-4414-a09d-2fe1723af290", "3347681797" },
                    { "861", 12, 2, 1, "CANTÚ", "GÁNDARA", "3301261506", "XEXX010101MNEXXXA8", "eddie.prosacco@will.com", new DateTime(1989, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "LOURDES", "4c6f2ba3-3799-4a75-8a12-f6ed4cce66b7", "3344970611" },
                    { "675", 13, 2, 1, "GONZÁLEZ", "LOZANO", "3315038946", "XEXX010101HNEXXXA4", "purdy.leonora@hudson.com", new DateTime(1979, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANTONIO", "852e076c-1f06-448d-83f4-8cb4b79109b9", "3392928159" },
                    { "972", 14, 3, 1, "DURÁN", "GARCÍA", "3317914443", "XEXX010101MNEXXXA8", "frami.terence@dubuque.com", new DateTime(1977, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLARA GABRIELA", "4ed7576b-a77d-4f4d-8424-ac3f04422d9b", "3339752838" },
                    { "779", 15, 3, 1, "CAMPA", "PAMPLONA", "3326431305", "XEXX010101HNEXXXA4", "bradtke.torrey@yahoo.com", new DateTime(1978, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "JORGE", "3e1b7bd9-d146-4b94-bae0-8ca41fbf6a84", "3320068241" },
                    { "656", 16, 3, 1, "TORRES", "IBAÑEZ", "3330028955", "XEXX010101MNEXXXA8", "thora.hirthe@gmail.com", new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SONIA ERIKA", "fa674223-72f5-4657-8fa7-e464737c35e9", "3307889594" },
                    { "991", 17, 3, 1, "TORRES", "ALCARAZ", "3361607678", "XEXX010101MNEXXXA8", "vicenta72@gmail.com", new DateTime(1980, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALEJANDRA", "1cdecc73-47a4-4c20-9ec6-1931053da335", "3379836327" },
                    { "669", 18, 3, 1, "CARGÍA", "CORNEJO", "3345559416", "XEXX010101MNEXXXA8", "xgoodwin@schinner.com", new DateTime(1970, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "MARTHA", "9d9435a8-103c-4349-bcec-7443a44a581d", "3330112050" },
                    { "500", 19, 3, 1, "DELGADO", "BECERRA", "3370661957", "XEXX010101HNEXXXA4", "nelson45@yahoo.com", new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SERGIO", "4d42ce0f-7b27-4d57-b895-31159f9cadb4", "3348810059" }
                });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "JefeId", "AcademiaId", "TrabajadorId" },
                values: new object[,]
                {
                    { 1, 1, "836" },
                    { 2, 2, "728" },
                    { 3, 3, "500" }
                });

            migrationBuilder.InsertData(
                table: "Puestos",
                columns: new[] { "PuestoId", "AcademiaId", "PlazaFechaInicio", "TrabajadorId" },
                values: new object[,]
                {
                    { 15, 3, new DateTime(2014, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "669" },
                    { 14, 3, new DateTime(2013, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "991" },
                    { 13, 3, new DateTime(2012, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "656" },
                    { 12, 3, new DateTime(2011, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "779" },
                    { 11, 3, new DateTime(2010, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "972" },
                    { 10, 2, new DateTime(2009, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "675" },
                    { 9, 2, new DateTime(2008, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "861" },
                    { 8, 2, new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "728" },
                    { 6, 2, new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "142" },
                    { 5, 1, new DateTime(2004, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "870" },
                    { 4, 1, new DateTime(2003, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "662" },
                    { 3, 1, new DateTime(2002, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "969" },
                    { 2, 1, new DateTime(2001, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "520" },
                    { 1, 1, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "836" },
                    { 7, 2, new DateTime(2006, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "106" },
                    { 16, 3, new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "500" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jefes_AcademiaId",
                table: "Jefes",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jefes_TrabajadorId",
                table: "Jefes",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_JefeInmediatoId",
                table: "Permisos",
                column: "JefeInmediatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TrabajadorId",
                table: "Permisos",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Planteles_DireccionId",
                table: "Planteles",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Puestos_AcademiaId",
                table: "Puestos",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puestos_TrabajadorId",
                table: "Puestos",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_DireccionId",
                table: "Trabajadores",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_PlantelId",
                table: "Trabajadores",
                column: "PlantelId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_PlazaId",
                table: "Trabajadores",
                column: "PlazaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "Jefes");

            migrationBuilder.DropTable(
                name: "Academias");

            migrationBuilder.DropTable(
                name: "Trabajadores");

            migrationBuilder.DropTable(
                name: "Planteles");

            migrationBuilder.DropTable(
                name: "Plazas");

            migrationBuilder.DropTable(
                name: "DireccionEntity");
        }
    }
}
